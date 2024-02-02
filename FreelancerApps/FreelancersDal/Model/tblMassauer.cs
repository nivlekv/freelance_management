using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("massauer")]
    public class TblMassauer : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string MassauerName { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string MassauerCode { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string FinNo { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string ContactNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateJoin { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CheckupDate { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Remark { get; set; }

        [Column(TypeName = "smallint(6)")]
        public int Priority { get; set; }

        public ComissionTypeEnum ComissionType { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRateBooked { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRateOther { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRateOtherBooked { get; set; }

        public BonusTypeEnum BonusType { get; set; }

        public bool Status { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }

        public virtual ICollection<TblMassauerComission> TblMassauerComissions { get; set; } = new List<TblMassauerComission>();
        public virtual ICollection<TblBooking> TblBookings { get; set; } = new List<TblBooking>();
    }
}