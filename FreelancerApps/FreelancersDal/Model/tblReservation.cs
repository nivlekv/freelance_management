using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("reservation")]
    public class TblReservation : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }
       
        [ForeignKey("TblMassauers")]
        public long MassauersID { get; set; }

        [Column(TypeName = "int(11)")]
        public int Duration { get; set; }
        
        [Column(TypeName = "datetime")]
        public DateTime ReserveStartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ReserveEndDate { get; set; }
        
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