using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    // Response Model
    public class MemberDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ICNo { get; set; }
        public string Nationality { get; set; }
        public string PhoneNo { get; set; }
        public decimal Credit { get; set; }
        public DateTime LastCheckInDate { get; set; }
        public long TotalVisitCount { get; set; }
        public MemberStatusEnum Status { get; set; }
        public MemberTypeEnum MemberType { get; set; }
        public MemberRoleEnum MemberRole { get; set; } = MemberRoleEnum.Member;
    }

    public class MemberListResponseModel : BaseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Nationality { get; set; }
        public string ICNo { get; set; }
        public decimal Credit { get; set; }
        public DateTime LastCheckInDate { get; set; }
        public long TotalVisitCount { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public MemberStatusEnum Status { get; set; }
    }

    public class MemberWalkInListResponseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsOccupy { get; set; }
    }


    // Request Model   
    public class MemberCreateRequestModel : BaseRequestModel
    {
        public string Name { get; set; }
        public string ICNo { get; set; }
        public string Nationality { get; set; }
        public string PhoneNo { get; set; }
        public MemberStatusEnum Status { get; set; }
        public string RequestBy { get; set; }
    }

    public class MemberDetailRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public string Keywords { get; set; }
    }

    public class MemberUpdateRequestModel : BaseRequestModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ICNo { get; set; }
        public string PhoneNo { get; set; }
        public string Nationality { get; set; }
        public MemberStatusEnum Status { get; set; }
        public string RequestBy { get; set; }
        public bool UpdateStatus { get; set; } = false;
        public bool UpdateFull { get; set; } = false;

    }

    public class MemberListRequestModel : ListRequestModel
    {
        public string ICNo { get; set; }
        public string PhoneNo { get; set; }
        public string Name { get; set; }
        public string Keywords { get; set; }
        public MemberStatusEnum? Status { get; set; }
        public MemberRoleEnum MemberRole { get; set; }
    }




    // Credit Movement
    public class MemberCreditMovementRequestModel : BaseRequestModel
    {
        public long MemberId { get; set; }
        public string Description { get; set; }
        public decimal AdjustCredit { get; set; }
        public MemberCreditMovementEnum MovementType { get; set; }
        public string RequestBy { get; set; }

    }

    public class MemberCreditMovementDetailRequestModel : BaseRequestModel
    {
        public long? MemberId { get; set; }
        public string Description { get; set; }        
        public MemberCreditMovementEnum? MovementType { get; set; }        

    }

    public class MemberCreditMovemenDetailResponseModel : BaseRequestModel
    {
        public string Description { get; set; }
        public decimal AdjustCredit { get; set; }
        public decimal BeforeCredit { get; set; }
        public decimal AfterCredit { get; set; }
        public MemberCreditMovementEnum MovementType { get; set; }

    }
}
