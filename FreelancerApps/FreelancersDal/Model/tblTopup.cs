using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("topup")]
    public class TblTopup : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [ForeignKey("TblMembers")]
        public long MemberID { get; set; }

        [ForeignKey("TblTopupPlans")]
        public long TopupPlanID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string TopupPlanName { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Point { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal BonusPoint { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public PaymentTypeEnum PaymentType { get; set; }

        public TopupStatusEnum Status { get; set; }
        public virtual TblMember TblMembers { get; set; }

        public virtual TblTopupPlan TblTopupPlans { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }

    }

    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("topup_plan")]
    public class TblTopupPlan : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string PlanName { get; set; } 

        [Column(TypeName = "decimal(10,2)")]
        public decimal Point { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal BonusPoint { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public bool Status { get; set; }

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
