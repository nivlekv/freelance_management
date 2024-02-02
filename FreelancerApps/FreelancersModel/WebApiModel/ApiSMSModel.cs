using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    // Response Model
    public class ApiSMSModel:BaseModel
    {
        public string from { get; set; }
        public string to { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string type { get; set; } = "0";
        public string servid { get; set; } = "Bulk360";
        public string text { get; set; }
    }
}
