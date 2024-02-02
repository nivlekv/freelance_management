using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class ExpensesListResponseModel : BaseModel
    {
        public string Id { get; set; }

        public DateTime ExpensesDate { get; set; }
        public ExpensesTypeEnum ExpensesType { get; set; }
        public decimal Amount { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

    }
    public class ExpensesDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public DateTime ExpensesDate { get; set; }
        public ExpensesTypeEnum ExpensesType { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
    }
    #endregion

    #region Request Model
    public class ExpensesRequestModel : BaseRequestModel
    {
        public DateTime ExpensesDate { get; set; }
        public ExpensesTypeEnum ExpensesType { get; set; }
        public decimal Amount { get; set; }
        public string RequestBy { get; set; }
    }
    public class ExpensesListRequestModel : ListRequestModel
    {
        public string DateRange { get; set; }
        public ExpensesTypeEnum? ExpensesType { get; set; }
        public bool? Status { get; set; }
    }
    public class ExpensesListAdminRequestModel : ListRequestModel
    {
        public bool? Status { get; set; }
    }
    public class ExpensesCreateRequestModel : ExpensesRequestModel
    {
      
    }
    public class ExpensesDetailRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
    }
    public class ExpensesUpdateRequestModel : ExpensesRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    #endregion
}
