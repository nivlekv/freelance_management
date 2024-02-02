using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("admin_access_rights")]
    public class TblAdminAccessRights : MySqlEntity
    {
        [ForeignKey("TblAdminGroups")]
        public long AdminGroupID { get; set; }

        [ForeignKey("TblAccessRightss")]
        public long AccessRightsID { get; set; }

        public bool Status { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }

        public virtual TblAdminGroup TblAdminGroups { get; set; }
        public virtual TblAccessRights TblAccessRightss { get; set; }
    }


}
