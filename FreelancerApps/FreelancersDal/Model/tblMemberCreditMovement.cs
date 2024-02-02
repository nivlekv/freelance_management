using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("member_credit_movement")]
    public class TblMemberCreditMovement : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [ForeignKey("TblMembers")]
        public long MemberID { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Description { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal BeforeBalance { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Debit { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Credit { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal AfterBalance { get; set; }
        public MemberCreditMovementEnum MovementType { get; set; }
        public virtual TblMember TblMembers { get; set; }

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
