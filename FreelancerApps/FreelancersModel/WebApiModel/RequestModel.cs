namespace FreelancersModel.WebApiModel
{
    public class BaseRequestModel : BaseModel
    {
        public string Cmd { get; set; } = string.Empty;
        public Guid SeqNo { get; set; } = Guid.NewGuid();
        public long TimeSpan { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        public string ApiKey { get; set; } = string.Empty; //No use for easier demo, usage is for Hash key in Signature 
        public string Ip { get; set; } = string.Empty;
        public string Signature { get; set; } = string.Empty;  // No use for easier demo, Usage is for Verified the Parameter Value Integrity 
        public string AppVersion { get; set; } = "v1.0";        

        public BaseRequestModel()
        {
            Cmd = GetType().Name.Replace("RequestModel", "");
        }

    }
    public class ListRequestModel : BaseRequestModel
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public SortOrderEnum OrderBy { get; set; } = SortOrderEnum.CreateDate;
        public SortEnum Asc { get; set; } =  SortEnum.ASC;
        public bool AllData { get; set; } = false;        
        public ListRequestModel()
        {
            Cmd =  GetType().Name.Replace("RequestModel", "");
        }
    }

    public class UpdateRequestModel : BaseRequestModel
    {
        public long ID { get; set; }
        public bool Status { get; set; }
        public short StatusNum { get; set; }
        public UpdateRequestModel()
        {
            Cmd = GetType().Name.Replace("RequestModel", "");
        }
    }
}
