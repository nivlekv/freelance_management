namespace FreelancersDal.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("user")]
    public class TblUser : MySqlEntity
    {
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "varchar(30)")]
        public string PhoneNo { get; set; } = string.Empty;
       
        public bool Status { get; set; }

        public virtual ICollection<TblUserSkillSet> TblUserSkillSets { get; set; } = new List<TblUserSkillSet>();
        public virtual ICollection<TblUserHobby> TblUserHobbies { get; set; } = new List<TblUserHobby>();
    }

    [Table("user_skillsets")]
    public class TblUserSkillSet : MySqlEntity
    {
        [ForeignKey("TblUsers")]
        public long UserId { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string SkillName { get; set; } = string.Empty;

        [Column(TypeName = "varchar(30)")]
        public SkillSetProficienyEnum Proficieny { get; set; }

        public virtual TblUser TblUsers { get; set; }
    }

    [Table("user_hobbies")]
    public class TblUserHobby : MySqlEntity
    {
        [ForeignKey("TblUsers")]
        public long UserId { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Hobby { get; set; } = string.Empty;

        public virtual TblUser TblUsers { get; set; }
    }

}
