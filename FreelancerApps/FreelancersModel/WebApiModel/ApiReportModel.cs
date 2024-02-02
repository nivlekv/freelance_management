using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class ReportStatisticResponseModel : BaseModel
    {
        public DateTime SalesDate { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalSalesBooked { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalDiscountBooked { get; set; }
        public decimal TotalComission { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalNetProfit { get; set; }
        public int TotalDuration { get; set; }
        public int TotalDurationBooked { get; set; }
        public int TotalNewMember { get; set; }
        public decimal TotalTopupAmount { get; set; }
        public long TotalTopup { get; set; }
        public decimal TotalTopupPoint { get; set; }
        public PaymentTypeEnum PaymentMethod { get; set; }
        public List<ReportPaymentList> PaymentList { get; set; }
        public decimal TotalBalance { get; set; }
    }

    public class ReportComissionResponseModel : BaseModel
    {
        public string MassauerName { get; set; }
        public int TotalDuration { get; set; }
        public int TotalDurationWalkIn { get; set; }
        public int TotalDurationBooked { get; set; }
        public decimal TotalComission { get; set; }
        public decimal TotalComissionWalkIn { get; set; }
        public decimal TotalComissionBooked { get; set; }
        public decimal TotalProductComission { get; set; }
        public int TotalCount { get; set; }
    }

    public class ReportComissionDetailResponseModel : BaseModel
    {
        public string MassauerName { get; set; }
        public string DocNo { get; set; }
        public DateTime CheckInDate { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CompanyEarn { get; set; }
        public decimal Comission { get; set; }
        public decimal GrandTotal { get; set; }
    }

    public class ReportMassaurStatementResponseModel : BaseModel
    {
        public string SalesDate { get; set; }
        public string MassauerName { get; set; }
        public int TotalDuration { get; set; }        
        public decimal Comission { get; set; }        
        public decimal TotalComission { get; set; }
        public int TotalCount { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalSalesCash { get; set; }
        public decimal TotalSalesNets { get; set; }
        public decimal TotalBonus { get; set; }
        public decimal TotalBalance { get; set; }
    }

    public class ReportMonthlyStatementResponseModel : BaseModel
    {
        public DateTime StatementDate { get; set; }
        public decimal TotalComissionGross { get; set; }
        public decimal TotalComission { get; set; }
        public decimal TotalBonus { get; set; }
        public decimal TotalLevy { get; set; }       
        public decimal TotalSales { get; set; }      
        public decimal TotalSalesCash { get; set; }
        public decimal TotalSalesNets { get; set; }
        public decimal TotalBalance { get; set; }
        public int TotalDuration { get; set; }

        public IEnumerable<ReportMassaurStatementResponseModel> MassauerList { get; set; }
    }

    public class ReportExpensesResponseModel : BaseModel
    {
        public DateTime StatementDate { get; set; }
        public string Expenses { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalSales { get; set; }
        public decimal NetProfit { get; set; }
    }
    public class ReportDailySummaryResponseModel : BaseModel
    {
        public string ShopName { get; set; }
        public List<ReportPaymentList> PaymentList { get; set; }
        public List<ReportPaymentList> TopupPaymentList { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalGrossSales { get; set; }
        public decimal TotalCancel { get; set; }
        public List<ReportMassauerList> ComissionList { get; set; }
        public List<ReportExpensesList> ExpensesList { get; set; }
    }
    public class ReportPaymentList
    {
        public PaymentTypeEnum PaymentMethod { get; set; }
        public decimal Amount { get; set; }
    }
    public class ReportMassauerList
    {
        public string MassauerName { get; set; }
        public int TotalCount { get; set; }
        public decimal TotalComission { get; set; }
        public decimal TotalSales { get; set; }
    }
    public class ReportExpensesList
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }

    #endregion


    #region Request Model
    public class ReportRequestModel : ListRequestModel
    {
        public string DateRange { get; set; }        
    }
    public class ReportComissionRequestModel : ListRequestModel
    {
        public string DateRange { get; set; }
        public long MassauerID { get; set; }
    }
    public class ReportStatementRequestModel : ListRequestModel
    {
        public DateTime StatementDate { get; set; }        
    }
    public class ReportExpensesRequestModel : ListRequestModel
    {
        public string DateRange { get; set; }
        public ReportGroupOptionEnum GroupOption { get; set; }
    }
    #endregion

}
