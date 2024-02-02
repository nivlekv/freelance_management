namespace FreelancersDal
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = true;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                //Log parameter values
                .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
        }

        public DbSet<TblUser> TblUsers { get; set; }
        public DbSet<TblUserHobby> TblUserHobbies { get; set; }
        public DbSet<TblUserSkillSet> TblUserSkillSets { get; set; }
       
    }
}
