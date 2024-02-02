using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("access_rights")]
    public class TblAccessRights : MySqlEntity
    {
        //Menu Name
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
        //Controller Name in Web
        [Column(TypeName = "varchar(20)")]
        public string Controller { get; set; }
        //Action Name in Web
        [Column(TypeName = "varchar(20)")]
        public string Action { get; set; }
        //Area Name in Web
        [Column(TypeName = "varchar(20)")]
        public string Area { get; set; }
        //i18 Locale variables
        [Column(TypeName = "varchar(30)")]
        public string Locale { get; set; }

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
