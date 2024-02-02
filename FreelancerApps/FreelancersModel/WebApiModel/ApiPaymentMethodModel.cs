using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class PaymentMethodListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public PaymentTypeEnum PaymentMethod { get; set; }        
        public string Description { get; set; }        
        public bool Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
    public class PaymentMethodDetailResponseModel : BaseModel
    {
        public long Id { get; set; }

        public PaymentTypeEnum PaymentMethod { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
    #endregion

    #region Request Model
    public class PaymentMethodRequestModel : BaseRequestModel
    {
        public PaymentTypeEnum PaymentMethod { get; set; }
        public string Description { get; set; }
        public string RequestBy { get; set; }
    }
    public class PaymentMethodListRequestModel : ListRequestModel
    {
        public PaymentTypeEnum PaymentMethod { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }   
    }   
    public class PaymentMethodCreateRequestModel : PaymentMethodRequestModel
    {
    }
    public class PaymentMethodDetailRequestModel : PaymentMethodRequestModel
    {
        public long Id { get; set; }
        
    }
    public class PaymentMethodUpdateRequestModel : PaymentMethodRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    #endregion
}
