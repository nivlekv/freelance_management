using HotelLiveDAL.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelLiveDAL
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                //Log parameter values
                .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAdminGroup>().HasMany(c => c.TblAdmins).WithOne(e => e.TblAdminGroup).IsRequired();
            base.OnModelCreating(modelBuilder);            
        }

        public DbSet<TblAdmin> TblAdmin { get; set; }
        public DbSet<TblAdminAccessRights> TblAdminAccessRights { get; set; }
        public DbSet<TblAdminLog> TblAdminLog { get; set; }
        public DbSet<TblAdminGroup> TblAdminGroup { get; set; }
        public DbSet<TblAccessRights> TblAccessRights { get; set; }
        public DbSet<TblBooking> TblBookings { get; set; }
        public DbSet<TblBookingPayment> TblBookingPayments { get; set; }
        public DbSet<TblBookingPackage> TblBookingPackages { get; set; }
        public DbSet<TblBookingProduct> TblBookingProducts { get; set; }
        public DbSet<TblConfig> TblConfig { get; set; }
        public DbSet<TblExpenses> TblExpenses { get; set; }
        public DbSet<TblMassauer> TblMassauer { get; set; }
        public DbSet<TblMassauerAttendance> tblMassauerAttendances { get; set; }
        public DbSet<TblMassauerComission> TblMassauerComission { get; set; }
        public DbSet<TblMember> TblMember { get; set; }
        public DbSet<TblMemberCreditMovement> TblMemberCreditMovements { get; set; }
        public DbSet<TblMemberLog> TblMemberLog { get; set; }
        public DbSet<TblNote> TblNotes { get; set; }
        public DbSet<TblPackage> TblPackages { get; set; }
        public DbSet<TblPaymentMethod> TblPaymentMethods { get; set; }
        public DbSet<TblProduct> TblProducts { get; set; }
        public DbSet<TblShop> TblShops { get; set; }
        public DbSet<TblSystemDocNumber> TblSystemDocNumbers { get; set; }
        public DbSet<TblTopup> TblTopups { get; set; }
        public DbSet<TblTopupPlan> TblTopupPlans { get; set; }
    }
}
