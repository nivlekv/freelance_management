using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("massauer_attendance")]
    public class TblMassauerAttendance : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime AttendanceDate { get; set; }

        [ForeignKey("TblMassauers")]
        public long MassauerID { get; set; }

        [Column(TypeName = "smallint(6)")]
        public int Priority { get; set; }
        public bool Status { get; set; }
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
