using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("system_docnumbering")]
    public class TblSystemDocNumber : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string DocCode { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Prefix { get; set; }

        [Column(TypeName = "int(11)")]
        public int RunningNumber { get; set; }

        [Column(TypeName = "int(11)")]
        public int LeadingZero { get; set; }

        public bool LeadZero { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string TableName { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string FieldName { get; set; }

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
