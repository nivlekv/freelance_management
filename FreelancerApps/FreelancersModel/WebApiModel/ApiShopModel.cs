using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class ShopListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }        
        public string BusinessRegNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
    public class ShopDetailResponseModel : BaseModel
    {
        public long Id { get; set; }

        public string CompanyName { get; set; }
        public string BusinessRegNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool IsParadigm { get; set; }
        public string ParadigmCode { get; set; }
        public ShopEntryTypeEnum EntryType { get; set; }
    }
    #endregion

    #region Request Model
    public class ShopRequestModel : BaseRequestModel
    {
        public string CompanyName { get; set; }
        public string BusinessRegNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string RequestBy { get; set; }
    }
    public class ShopListRequestModel : ListRequestModel
    {
        public string CompanyName { get; set; }
        public string BusinessRegNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool? Status { get; set; }   
    }
    public class ShopListAdminRequestModel : ListRequestModel
    {
        public bool? Status { get; set; }
    }
    public class ShopCreateRequestModel : ShopRequestModel
    {
    }
    public class ShopDetailRequestModel : ShopRequestModel
    {
        public long Id { get; set; }
        
    }
    public class ShopUpdateRequestModel : ShopRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    #endregion
}
