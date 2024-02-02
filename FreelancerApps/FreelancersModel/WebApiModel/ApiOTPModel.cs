using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    public class SendOTPRequestModel : BaseRequestModel
    {
        public string Username { get; set; }
        public OTPTransType Type { get; set; }
        public OTPSendType SendType { get; set; }       
    }
}
