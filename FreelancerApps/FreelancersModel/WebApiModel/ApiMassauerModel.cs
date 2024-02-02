using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class MassauerListResponseModel : BaseModel
    {
        public string Id { get; set; }

        public string MassauerName { get; set; }

        public string MassauerCode { get; set; }

        public ComissionTypeEnum ComissionType { get; set; }

        public decimal ComissionRate { get; set; }
        
        public decimal ComissionRateBooked { get; set; }

        public decimal ComissionRateOther { get; set; }

        public decimal ComissionRateOtherBooked { get; set; }

        public BonusTypeEnum BonusType { get; set; }

        public long TotalJob { get; set; }
        public string PackageRemark { get; set; }
        public DateTime CheckOutTime { get; set; }

        public string Address { get; set; }
        public string FinNo { get; set; }
        public string ContactNo { get; set; }
        public DateTime DateJoin { get; set; }
        public DateTime CheckupDate { get; set; }

        public string Remark { get; set; }
        public int Priority { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public IEnumerable<BookingSummary> BookingList { get; set; }

    }
    public class MassauerDetailResponseModel : BaseModel
    {
        public long Id { get; set; }

        public string MassauerName { get; set; }

        public string MassauerCode { get; set; }

        public ComissionTypeEnum ComissionType { get; set; }

        public decimal ComissionRate { get; set; }

        public decimal ComissionRateBooked { get; set; }

        public decimal ComissionRateOther { get; set; }

        public decimal ComissionRateOtherBooked { get; set; }

        public BonusTypeEnum BonusType { get; set; }
        
        public List<ComissionRateTable> ComissionRateTableList { get; set; }

        public string Remark { get; set; }
        
        public string Address { get; set; }
        public string FinNo { get; set; }
        public string ContactNo { get; set; }
        public DateTime DateJoin { get; set; }
        public DateTime CheckupDate { get; set; }

        public bool Status { get; set; }
    }
    public class MassauerAttendanceResponseModel
    {
        public DateTime AttendanceDate { get; set; }
        public List<MassauerAttendanceTable> AttendanceList { get; set; }
        public List<MassauerAttendanceTable> UnAttendanceList { get; set; }
    }


    public class ComissionRateTable
    {
        public long Id { get; set; }
        public ComissionTypeRateEnum ComissionType { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public decimal ComissionRate { get; set; }
        public decimal ComissionRateBooked { get; set; }
        public decimal ComissionRateOther { get; set; }
        public decimal ComissionRateOtherBooked { get; set; }

        public int PageIndex { get; set; }
    }

    public class MassauerAttendanceTable
    {
        public long MassauerId { get; set; }
        public string MassauerName { get; set; }
        public int Sorting { get; set; }
    }
    #endregion

    #region Request Model
    public class MassauerRequestModel : BaseRequestModel
    {
        public string MassauerName { get; set; }
        public string MassauerCode { get; set; }
        public ComissionTypeEnum ComissionType { get; set; }
        public decimal ComissionRate { get; set; }
        public decimal ComissionRateBooked { get; set; }
        public decimal ComissionRateOther { get; set; }
        public decimal ComissionRateOtherBooked { get; set; }
        public BonusTypeEnum BonusType { get; set; }
        public List<ComissionRateTable> ComissionRateTableList { get; set; }
        public string Address { get; set; }
        public string FinNo { get; set; }
        public string ContactNo { get; set; }
        public DateTime DateJoin { get; set; }
        public DateTime CheckupDate { get; set; }
        public string Remark { get; set; }
        public string RequestBy { get; set; }
    }
    public class MassauerListRequestModel : ListRequestModel
    {
        public string MassauerName { get; set; }
        public string MassauerCode { get; set; }
        public bool? Status { get; set; } 
    }
    public class MassauerListAdminRequestModel : ListRequestModel
    {
        public bool? Status { get; set; }
    }
    public class MassauerCreateRequestModel : MassauerRequestModel
    {
    }
    public class MassauerDetailRequestModel : MassauerRequestModel
    {
        public long Id { get; set; }        
    }
    public class MassauerUpdateRequestModel : MassauerRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    public class MassauerUpdatePriorityRequestModel : MassauerRequestModel
    {
        public long[] Id { get; set; }        
    }
    public class MassauerAttendanceListRequestModel : ListRequestModel
    {
        public DateTime AttendanceDate { get; set; }
        public string RequestBy { get; set; }
    }
    public class MassauerAttendanceUpdateRequestModel : MassauerRequestModel
    {
        public DateTime AttendanceDate { get; set; }
        public long[] Id { get; set; }
    }
    #endregion
}
