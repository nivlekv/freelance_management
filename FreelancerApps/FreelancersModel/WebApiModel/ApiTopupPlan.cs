using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    // Response Model
    public class TopupPlanDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public string PlanName { get; set; }
        public decimal Point { get; set; }
        public decimal BonusPoint { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }

    public class TopupPlanListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public string PlanName { get; set; }
        public decimal Point { get; set; }
        public decimal BonusPoint { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }

    // Request Model   
    public class TopupPlanCreateRequestModel : BaseRequestModel
    {
        public string PlanName { get; set; }
        public decimal Point { get; set; }
        public decimal BonusPoint { get; set; }
        public decimal Price { get; set; }
        public string RequestBy { get; set; }
    }

    public class TopupPlanDetailRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
    }

    public class TopupPlanUpdateRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public string PlanName { get; set; }
        public decimal Point { get; set; }
        public decimal BonusPoint { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public string RequestBy { get; set; }
        public bool UpdateStatus { get; set; } = false;
        public bool UpdateFull { get; set; } = false;

    }

    public class TopupPlanListRequestModel : ListRequestModel
    {
        public string PlanName { get; set; }
        public bool? Status { get; set; }
    }


 
}
