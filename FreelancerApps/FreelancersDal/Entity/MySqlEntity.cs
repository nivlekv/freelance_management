namespace FreelancersDal
{
    public abstract class MySqlEntity : IEntity
    {
        [Key]
        [Column(TypeName = "BIGINT(20)")]
        public long ID { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public string CreateBy { get; set; } = string.Empty;

        [Column("CreateDate", TypeName = "DateTime")]
        public DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public string ModifiedBy { get; set; } = string.Empty;

        [Column("ModifiedDate", TypeName = "DateTime")]
        public DateTime ModifiedDate { get; set; }
    }
}
