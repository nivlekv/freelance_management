using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("room")]
    public class TblRoom : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }
        [Column(TypeName = "varchar(8)")]
        public string RoomNo { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string RoomName { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Facilities { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Remark { get; set; }

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