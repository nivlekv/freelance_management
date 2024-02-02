namespace FreelancersModel.WebApiModel
{
    // Response Model
    public class UserDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Status { get; set; }
        public List<UserSkillSetModel>? SkillSets { get; set; }
        public List<UserHobbyModel>? Hobby { get; set; }
    }

    public class UserListResponseModel : BaseModel
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Status { get; set; }
        public IEnumerable<UserSkillSetModel>? SkillSets { get; set; }
        public IEnumerable<UserHobbyModel>? Hobby { get; set; }

        public DateTime LastUpdateDate { get; set; }                
        
    }

    public class UserSkillSetModel
    {
        public long Id { get; set; }
        public string SkillName { get; set; } = string.Empty;
        public SkillSetProficienyEnum Proficieny { get; set; }
    }

    public class UserHobbyModel
    {
        public long Id { get; set; }
        public string Hobby { get; set; } = string.Empty;
    }

    // Request Model   
    public class UserCreateRequestModel : BaseRequestModel
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<UserSkillSetModel>? SkillSets { get; set; }
        public List<UserHobbyModel>? Hobby { get; set; }
        public string RequestBy { get; set; } = string.Empty;
    }

    public class UserDetailRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
    }

    public class UserUpdateRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Status { get; set; }
        public List<UserSkillSetModel>? SkillSets { get; set; }
        public List<UserHobbyModel>? Hobby { get; set; }
        public string RequestBy { get; set; } = string.Empty;

    }

    public class UserListRequestModel : ListRequestModel
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool? Status { get; set; }
    }



}
