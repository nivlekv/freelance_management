using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class ConfigResponseModel : BaseModel
    {
        public string Id { get; set; }

        public string BulkSMSLink { get; set; }
        public string BulkSMSUsername { get; set; }
        public string BulkSMSPassword { get; set; }
        public string BulkSMSPrefixText { get; set; }
        public string BulkSMSBaseUrl { get; set; }

        public string SMTPServer { get; set; }
        public int SMTPPort { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }

        public string ICBaseUrl { get; set; }
        public string ImageBaseUrl { get; set; }
        public decimal USDTRate { get; set; }

        public decimal ComissionPercent { get; set; }
        public decimal CompanyComissionPercent { get; set; }
        public decimal PoolPrizePercent { get; set; }
        public decimal PrizeBonusPercent { get; set; }
    }  

    #endregion

    #region Request Model
    public class ConfigSettingRequestModel : ListRequestModel
    {
        public ConfigTypeEnum configType { get; set; }
    }

    public class ConfigGeneralUpdateRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public decimal USDTRate { get; set; }
        public decimal ComissionPercent { get; set; }
        public decimal CompanyComissionPercent { get; set; }
        public decimal PoolPrizePercent { get; set; }
        public decimal PrizeBonusPercent { get; set; }
        public string RequestBy { get; set; }

    }
    #endregion
}
