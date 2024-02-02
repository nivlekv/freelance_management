using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HotelLiveModel.WebApiModel
{
    public class BaseRequestModel : BaseModel
    {
        public string Cmd { get; set; }
        public Guid SeqNo { get; set; } = Guid.NewGuid();
        public long TimeSpan { get; set; }
        public string ApiKey { get; set; } //Public Key
        public string Ip { get; set; }
        public string Signature { get; set; }
        public string AppVersion { get; set; }
        public short ShopID { get; set; }

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
    public class LoginRequestModel : BaseRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public LoginRequestModel()
        {
            Cmd = GetType().Name.Replace("RequestModel", "");
        }
    }

    public class InitialRequestModel : BaseRequestModel
    {
        public InitialRequestModel()
        {
            Cmd = GetType().Name.Replace("RequestModel", "");
        }
    }

    public class RefreshTokenRequestModel : BaseRequestModel
    {
        public string UserName { get; set; }
        public RefreshTokenRequestModel()
        {
            Cmd = GetType().Name.Replace("RequestModel", "");
        }
    }

    public class ChangePasswordRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }        
        public string RequestBy { get; set; }
    }

    public class ResetPasswordRequestModel : BaseRequestModel
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
        public string ResetToken { get; set; }
    }
}
