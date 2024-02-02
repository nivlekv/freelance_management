using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class RoomListResponseModel : BaseModel
    {
        public string Id { get; set; }

        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public string RoomCategory { get; set; }
        public string Facilities { get; set; }
        public string Remark { get; set; }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

    }
    public class RoomDetailResponseModel : BaseModel
    {
        public long Id { get; set; }

        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public long RoomCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Facilities { get; set; }
        public string Remark { get; set; }

        public bool Status { get; set; }
    }
    
    public class RoomCategoryListResponseModel : BaseModel
    {
        public string Id { get; set; }

        public string CategoryName { get; set; }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

    }
    public class RoomCategoryDetailResponseModel : BaseModel
    {
        public long Id { get; set; }

        public string CategoryName { get; set; }

        public bool Status { get; set; }
    }

    public class RoomBookingListResponseModel : BaseModel
    {
        public string Id { get; set; }

        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public string RoomCategory { get; set; }
        public string Name { get; set; }        
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public BookingStatusEnum? Status { get; set; }

    }

    public class RoomDashboardListReponseModel : BaseModel
    {
        public string Id { get; set; }

        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public string RoomCategory { get; set; }
       
        public IEnumerable<BookingModel> BookingList { get; set; }
    }

    public class BookingModel
    {
        public string Name { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public BookingStatusEnum? Status { get; set; }
    }

    #endregion

    #region Request Model
    public class RoomRequestModel : BaseRequestModel
    {
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public long RoomCategoryID { get; set; }
        public string Facilities { get; set; }
        public string Remark { get; set; }

        public string RequestBy { get; set; }
    }
    public class RoomListRequestModel : ListRequestModel
    {
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public long RoomCategoryID { get; set; }
        public bool IsDashboard { get; set; }
        public bool? Status { get; set; } 
    }
    public class RoomListAdminRequestModel : ListRequestModel
    {
        public bool? Status { get; set; }
    }
    public class RoomCreateRequestModel : RoomRequestModel
    {
    }
    public class RoomDetailRequestModel : RoomRequestModel
    {
        public long Id { get; set; }
    }
    public class RoomUpdateRequestModel : RoomRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }

    public class RoomCategoryRequestModel : BaseRequestModel
    {
        public string CategoryName { get; set; }

        public string RequestBy { get; set; }
    }
    public class RoomCategoryListRequestModel : ListRequestModel
    {
        public string CategoryName { get; set; }
        public bool? Status { get; set; } 
    }
    public class RoomCategoryListAdminRequestModel : ListRequestModel
    {
        public bool? Status { get; set; }
    }
    public class RoomCategoryCreateRequestModel : RoomCategoryRequestModel
    {
    }
    public class RoomCategoryDetailRequestModel : RoomCategoryRequestModel
    {
        public long Id { get; set; }
    }
    public class RoomCategoryUpdateRequestModel : RoomCategoryRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    #endregion
}
