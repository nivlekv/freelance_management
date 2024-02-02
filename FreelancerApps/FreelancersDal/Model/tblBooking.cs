using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("booking")]
    public class TblBooking : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [ForeignKey("TblMembers")]
        public long MemberID { get; set; }

        [ForeignKey("TblPackages")]
        public long PackageID { get; set; }

        [ForeignKey("TblMassauers")]
        public long MassauersID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string DocNo { get; set; }


        [Column(TypeName = "int(11)")]
        public int Duration { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ProductCharges { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRate { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Comission { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Bonus { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ProductComission { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalComission { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal DiscountPercent { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal GrandTotal { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal CashCollect { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Balance { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CheckInDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CheckOutDate { get; set; }
        public BookingStatusEnum Status { get; set; }
        public BookingTypeEnum BookingType { get; set; }

        public DateTime PaymentDate { get; set; }
        public string PaymentBy { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }

        public virtual TblMember TblMembers { get; set; }
        public virtual TblPackage TblPackages { get; set; }
        public virtual TblMassauer TblMassauers { get; set; }

        public virtual ICollection<TblBookingProduct> TblBookingProducts { get; set; } = new List<TblBookingProduct>();
        public virtual ICollection<TblBookingPayment> TblBookingPayments { get; set; } = new List<TblBookingPayment>();

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }
    }

    [Table("booking_product")]
    public class TblBookingProduct : MySqlEntity
    {
        [ForeignKey("TblBookings")]
        public long BookingID { get; set; }

        [ForeignKey("TblProducts")]
        public long ProductID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Comission { get; set; }

        public virtual TblBooking TblBookings { get; set; }
        
        public virtual TblProduct TblProducts { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }
    }


    [Table("booking_package")]
    public class TblBookingPackage : MySqlEntity
    {
        [ForeignKey("TblBookings")]
        public long BookingID { get; set; }

        [Column(TypeName = "bigint(20)")]
        public long PackageID { get; set; }

        [ForeignKey("TblMassauers")]
        public long MassauerID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string PackageName { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "int(11)")]
        public int Duration { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Comission { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Bonus { get; set; }

        public virtual TblBooking TblBookings { get; set; }

        public virtual TblMassauer TblMassauers { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }
    }

    [Table("booking_payment")]
    public class TblBookingPayment : MySqlEntity
    {
        [ForeignKey("TblBookings")]
        public long BookingID { get; set; }

        public PaymentTypeEnum PaymentType { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }

        public string PaymentBy { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PaymentAmount { get; set; }

        public virtual TblBooking TblBookings { get; set; }        

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }
    }
}