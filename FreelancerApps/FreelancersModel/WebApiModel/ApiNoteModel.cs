using HotelLiveModel.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HotelLiveModel.WebApiModel
{
    #region Response Model
    // Response Model
    public class NoteListResponseModel : BaseModel
    {
        public string Id { get; set; }
        public DateTime NoteDate { get; set; }
        public string Note { get; set; }        
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

    }
    public class NoteDetailResponseModel : BaseModel
    {
        public long Id { get; set; }
        public DateTime NoteDate { get; set; }
        public string Note { get; set; }
    }
    #endregion

    #region Request Model
    public class NoteRequestModel : BaseRequestModel
    {
        public DateTime NoteDate { get; set; }
        public string Note { get; set; }
        public string RequestBy { get; set; }
    }
    public class NoteListRequestModel : ListRequestModel
    {
        public string DateRange { get; set; }
    }
    public class NoteCreateRequestModel : NoteRequestModel
    {
      
    }
    public class NoteDetailRequestModel : NoteRequestModel
    {
        public long Id { get; set; }
    }
    public class NoteUpdateRequestModel : NoteRequestModel
    {
        public long Id { get; set; }
    }
    #endregion
}
