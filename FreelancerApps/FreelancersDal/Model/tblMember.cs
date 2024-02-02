using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("member")]
    public class TblMember : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public short ShopID { get; set; }

        // Basic Info
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string ICNo { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string PhoneNo { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Nationality { get; set; }

        public MemberTypeEnum MemberType { get; set; }

        public MemberRoleEnum MemberRole { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Credit { get; set; }

        public MemberStatusEnum Status { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime LastCheckInDate { get; set; }

        public virtual ICollection<TblBooking> TblBookings { get; set; } = new List<TblBooking>();
        public virtual ICollection<TblTopup> TblTopups { get; set; } = new List<TblTopup>();

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
