using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class ProductListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }        
        public decimal Price { get; set; }
        public decimal Comission { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

    }
    public class ProductDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Comission { get; set; }
        public string Remark { get; set; }
        public bool Status { get; set; }
    }
    #endregion

    #region Request Model
    public class ProductRequestModel : BaseRequestModel
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Comission { get; set; }
        public string Remark { get; set; }
        public string RequestBy { get; set; }
    }
    public class ProductListRequestModel : ListRequestModel
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public bool? Status { get; set; }   
    }
    public class ProductListAdminRequestModel : ListRequestModel
    {
        public bool? Status { get; set; }
    }
    public class ProductCreateRequestModel : ProductRequestModel
    {
    }
    public class ProductDetailRequestModel : ProductRequestModel
    {
        public long Id { get; set; }
        
    }
    public class ProductUpdateRequestModel : ProductRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;
    }
    #endregion
}
