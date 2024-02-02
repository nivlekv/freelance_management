using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    public class ClaimsModel :BaseModel
    {
        public string Username { get; set; }
        public string Info { get; set; }
        public string RoleType { get; set; }
    }
}
