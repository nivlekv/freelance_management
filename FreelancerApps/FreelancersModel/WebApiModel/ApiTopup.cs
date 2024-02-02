using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    // Response Model
    public class TopupDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string PlanId { get; set; }
        public string PlanName { get; set; }
        public decimal Point { get; set; }
        public decimal BonusPoint { get; set; }
        public decimal Price { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
    }

    public class TopupListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public string MemberName { get; set; }
        public string PlanName { get; set; }
        public decimal Point { get; set; }
        public decimal BonusPoint { get; set; }
        public decimal Price { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public TopupStatusEnum Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }

    // Request Model   
    public class TopupCreateRequestModel : BaseRequestModel
    {
        public long MemberId { get; set; }
        public long PlanId { get; set; }      
        public PaymentTypeEnum PaymentType { get; set; }
        public string RequestBy { get; set; }
    }

    public class TopupDetailRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
    }

    public class TopupUpdateRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public TopupStatusEnum Status { get; set; }
        public bool UpdateStatus { get; set; } = true;
        public string RequestBy { get; set; }
    }

    public class TopupListRequestModel : ListRequestModel
    {
        public string DateRange { get; set; }
        public string MemberName { get; set; }
        public string PlanId { get; set; }
        public TopupStatusEnum? Status { get; set; }
    }


 
}
