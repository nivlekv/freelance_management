using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    [Table("package")]
    public class TblPackage : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PackageCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string PackageName { get; set; }

        [Column(TypeName = "smallint(6)")]
        public int Duration { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        
        public PackageTypeEnum PackageType { get; set; }

        public bool Status { get; set; }

        public ColorEnum Color { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Remark { get; set; }

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