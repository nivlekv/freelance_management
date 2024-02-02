using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class AdminResponseModel : BaseModel
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public long GroupId { get; set; }

        public string GroupName { get; set; }

        public string Name { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public short ShopID { get; set; }

        public ShopEntryTypeEnum ShopEntryType { get; set; }
        
        public bool IsParadigm { get; set; }

        public string ParadigmCode { get; set; }

        public IEnumerable<AccessRightModel> AccessRightsList { get; set; }
    }

    public class AdminDetailResponseModel : BaseModel
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public long GroupId { get; set; }

        public string GroupName { get; set; }

        public string Name { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }
        public bool Status { get; set; }
        public string Picture { get; set; }
    }

    public class AdminListResponseModel : BaseModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string GroupName { get; set; }

        public string Name { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string LastLoginIP { get; set; }
        public bool Status { get; set; }
    }
    #endregion

    #region RequestModel

    // Request Model
    public class AdminRequestModel : BaseRequestModel
    {
        public string Username { get; set; }
        public long GroupId { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; } 
        public string RequestBy { get; set; }
    }
    public class AdminCreateRequestModel : AdminRequestModel
    {
        public string Password { get; set; }        
    }
    public class AdminDetailRequestModel : AdminRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
    }
    public class AdminUpdateRequestModel : AdminRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    public class AdminListRequestModel : ListRequestModel
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public bool? Status { get; set; }
    }
    
    public class AccessRightModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public bool Status { get; set; }
        public string Locale { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
    }

    #endregion
}
