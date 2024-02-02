using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class PackageListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public string PackageCode { get; set; }
        public string PackageName { get; set; }
        public PackageTypeEnum PackageType { get; set; }
        public string Remark { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public ColorEnum Color { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

    }
    public class PackageDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public PackageTypeEnum PackageType { get; set; }
        public string PackageCode { get; set; }
        public string PackageName { get; set; }
        public int Duration { get; set; }
        public ColorEnum Color { get; set; }
        public decimal Price { get; set; }
        public string Remark { get; set; }
        public bool Status { get; set; }
    }
    #endregion

    #region Request Model
    public class PackageRequestModel : BaseRequestModel
    {
        public PackageTypeEnum PackageType { get; set; }
        public string PackageCode { get; set; }
        public string PackageName { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public ColorEnum Color { get; set; }
        public string Remark { get; set; }
        public string RequestBy { get; set; }
    }
    public class PackageListRequestModel : ListRequestModel
    {
        public PackageTypeEnum? PackageType { get; set; }
        public string PackageCode { get; set; }
        public string PackageName { get; set; }
        public bool? Status { get; set; }
    }
    public class PackageListAdminRequestModel : ListRequestModel
    {
        public bool? Status { get; set; }
    }
    public class PackageCreateRequestModel : PackageRequestModel
    {
      
    }
    public class PackageDetailRequestModel : PackageRequestModel
    {
        public long Id { get; set; }
    }
    public class PackageUpdateRequestModel : PackageRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    #endregion
}
