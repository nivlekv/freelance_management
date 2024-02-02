using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("admin_log")]
    public class TblAdminLog : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Username { get; set; }
        [Column(TypeName = "smallint(6)")]
        public AdminActionEnum Action { get; set; }
        [Column(TypeName = "text")]
        public string ModelString { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string IpAddress { get; set; }

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