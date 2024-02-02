using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelLiveModel.Entity;

namespace HotelLiveDAL
{
    public abstract class MySqlEntity : IEntity
    {
        [Key]
        [Column(TypeName = "BIGINT(20)")]
        public long ID { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public abstract string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public abstract DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public abstract string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public abstract DateTime ModifiedDate { get; set; }
    }
}
