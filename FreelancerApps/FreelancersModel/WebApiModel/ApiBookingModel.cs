using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class BookingListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string NRIC { get; set; }
        public string PhoneNo { get; set; }
        public string PackageName { get; set; }
        public long PackageID { get; set; }
        public string Description { get; set; } // For Quick Add Use
        public string ItemId { get; set; } // For Quick Add Use
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string MassauerId { get; set; }
        public string Massauer { get; set; }
        public decimal Comission { get; set; }
        public decimal Price { get; set; }
        public decimal GrandTotal { get; set; }
        public string DocNo { get; set; }
        public string CreateBy{ get; set; }
        public DateTime CreateDate { get; set; }
        public BookingStatusEnum Status { get; set; }
        public BookingTypeEnum BookingType { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }      
        public PaymentTypeEnum PaymentType { get; set; }

        public List<BookingPayment> PaymentList { get; set; }
    }
    public class BookingDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string NRIC { get; set; }
        public string PhoneNo { get; set; }
        public MemberRoleEnum MemberRole { get; set; }
        public long PackageId { get; set; }
        public string PackageName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public long MassauerId { get; set; }
        public string Massauer { get; set; }
        public BookingStatusEnum Status { get; set; }
        public BookingTypeEnum BookingType { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPercent { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentBy { get; set; }
        public decimal CashCollect { get; set; }
        public decimal Balance { get; set; }
        public string DocNo { get; set; }
        public decimal Credit { get; set; }
        
        public decimal BeforePoint { get; set; }
        public decimal AfterPoint { get; set; }
        public decimal PointRedeem { get; set; }

        public IEnumerable<BookingProduct> ProductList { get; set; }
        public IEnumerable<BookingPayment> PaymentList { get; set; }
    }
    public class BookingProduct
    {
        public int PageIndex { get; set; }
        public long BookingProductId { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Comission { get; set; }
    }
    public class BookingPayment
    {
        public int PageIndex { get; set; }
        public long BookingPaymentId { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public decimal Amount { get; set; }

        public List<PaymentMethodListResponseModel> PaymentLists { get; set; }
    }
    public class BookingSummary
    {
        public string DocNo { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal TotalComission { get; set; }
    }
    #endregion

    #region Request Model
    public class BookingRequestModel : BaseRequestModel
    {
        public long PackageId { get; set; }
        public long MemberId { get; set; }
        public long MassauerId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string NRIC { get; set; }
        public string PhoneNo { get; set; }
        public MemberTypeEnum MemberType { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPercent { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public BookingTypeEnum BookingType { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }
        public decimal CashCollect { get; set; }
        public decimal Balance { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentBy { get; set; }
        public string RequestBy { get; set; }
        public List<BookingProduct> ProductList { get; set; }
        public List<BookingPayment> PaymentList { get; set; }
    }
    public class BookingListRequestModel : ListRequestModel
    {
        public string Name { get; set; }
        public string NRIC { get; set; }
        public string PhoneNo { get; set; }
        public string DateRangeCheckIn { get; set; }
        public bool IsHome { get; set; }
        public BookingTypeEnum? BookingType { get; set; }
        public BookingStatusEnum? Status { get; set; } 
    }
    public class BookingCreateRequestModel : BookingRequestModel
    {
        public DateTime CheckInDate { get; set; }
    }
    public class BookingDetailRequestModel : BookingRequestModel
    {
        public long Id { get; set; }
    }
    public class BookingUpdateRequestModel : BookingRequestModel
    {
        public long Id { get; set; }
        public List<long> BookingId { get; set; }
        public BookingStatusEnum Status { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
        public bool UpdateCheckInOnly { get; set; } = false;
        public bool IsPayment { get; set; }
        public bool IsCheckout { get; set; }
    }
    public class BookingRemoveProductRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public string RequestBy { get; set; }
    }
    #endregion
}
