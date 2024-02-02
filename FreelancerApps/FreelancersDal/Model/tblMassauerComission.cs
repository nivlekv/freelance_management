using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("massauer_comission")]
    public class TblMassauerComission : MySqlEntity
    {
        [ForeignKey("TblMassauers")]
        public long MassauerID { get; set; }

        public ComissionTypeRateEnum ComissionType { get; set; }

        [Column(TypeName = "int(11)")]
        public int MinValue { get; set; }

        [Column(TypeName = "int(11)")]
        public int MaxValue { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRateBooked { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRateOther { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ComissionRateOtherBooked { get; set; }


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
}