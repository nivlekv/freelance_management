namespace FreelancersModel.WebApiModel
{
    public class BaseResponseModel:BaseModel
    {
        public ResponseStatusEnum Status { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public BaseResponseModel(ResponseStatusEnum status, string msg , string token="")
        {
            this.Status  = status;
            this.Message = msg;
            this.Token   = token;
        }        
    }

    public class ContentResponseModel<T> : BaseResponseModel
    {
        public T Content { get; set; }
        public ContentResponseModel(ResponseStatusEnum status, string message, T content, string token = "") : base(status, message, token)
        {
            this.Status  = status;
            this.Message = message;
            this.Token   = token;
            this.Content = content;
        }
    }

    public class ListResponseModel<T> : BaseResponseModel
    {
        public long TotalItem { get; set; }
        public IEnumerable<T> Content { get; set; }
        public ListResponseModel(ResponseStatusEnum status, string message, IEnumerable<T> content, long totalItem, string token = "") : base(status, message, token)
        {
            this.Status    = status;
            this.Message   = message;
            this.Token     = token;
            this.Content   = content;
            this.TotalItem = totalItem;
        }
    }
}
