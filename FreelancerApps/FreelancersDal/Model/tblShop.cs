using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("shop")]
    public class TblShop : MySqlEntity
    {
        [Column(TypeName = "varchar(200)")]
        public string CompanyName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string BusinessRegNo { get; set; } //Business Reg No

        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string ContactNo { get; set; }

        [Column(TypeName = "smallint(6)")]
        public ShopEntryTypeEnum EntryType { get; set; }

        [Column(TypeName = "smallint(6)")]
        public ShopItemDisplayEnum ItemDisplay { get; set; }

        public bool IsParadigm { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string ParadigmCode { get; set; }


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
