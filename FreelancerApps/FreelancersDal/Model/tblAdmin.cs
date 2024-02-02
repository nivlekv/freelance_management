using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("admin")]
    public class TblAdmin : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Username { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string ContactNo { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Picture { get; set; }
        public bool Status { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Remark { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string DefaultLanguage { get; set; }

        public DateTime LastLoginDate { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string LastLoginIP { get; set; }
        
        [ForeignKey("TblAdminGroup")]
        public long GroupId { get; set; }

        public virtual TblAdminGroup TblAdminGroup { get; set; }

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
