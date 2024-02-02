namespace FreelancersApi.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller 
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public BaseResponseModel CheckValidation(BaseRequestModel model, string action)
        {
            if(model.Cmd == action)
            {
                if (CheckTimeSpanExpired(model.TimeSpan, 10))
                {
                    return new BaseResponseModel(ResponseStatusEnum.OK, "");
                }
                else
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.INVALID_TIMESPAN.ToString());
                }
            }
            else
            {
                return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.INVALID_ACTION.ToString());
            }

        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public bool CheckTimeSpanExpired(long timeSpan, int validTime)
        {
            DateTime dateTime = new DateTime(1970, 1, 1).AddSeconds(timeSpan).ToLocalTime();

            return DateTime.Now.Subtract(dateTime).TotalMinutes < validTime;
        }
    }
}
