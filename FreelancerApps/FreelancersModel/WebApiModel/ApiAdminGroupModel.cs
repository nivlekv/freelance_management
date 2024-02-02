using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    public class AdminGroupResponseModel: BaseModel
    {
        public long Id { get; set; }
        public string GroupName { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }

        public IEnumerable<AccessRightModel> AccessRightsList { get; set; }
    }

    public class AdminGroupListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public string GroupName { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }

    // Request Model
    public class AdminGroupRequestModel : BaseRequestModel
    {
        public string GroupName { get; set; }
        public string RequestBy { get; set; }
        public IEnumerable<AccessRightModel> AccessRightsList { get; set; }

    }
    public class AdminGroupCreateRequestModel : AdminGroupRequestModel
    {   
    }
    public class AdminGroupDetailRequestModel : AdminGroupRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
    }

    public class AdminGroupUpdateRequestModel : AdminGroupRequestModel
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public bool UpdateStatusOnly { get; set; } = false;        
    }

    public class AdminGroupListRequestModel : ListRequestModel
    {
        public string GroupName { get; set; }
        public bool? Status { get; set; }
    }
}
