namespace FreelancersApi.Controllers
{

    [Route("v1/[controller]")]
    public class UserController : BaseController
    {
        private readonly AppSetting _appSetting;
        private readonly IUserService _userService;

        public UserController(IOptions<AppSetting> arg1, IUserService arg2)
        {
            _appSetting      = arg1.Value;
            _userService   = arg2;
        }
       
        // GET api/<controller>/5   Get User Detail
        [HttpGet]
        public async Task<JsonResult> Get(UserDetailRequestModel model)
        {
            Log.Information("[UserDetailRequestModel] " + model.ToJson());

            model.TimeSpan = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var responseValidation = CheckValidation(model, APIActionEnum.UserDetail.ToString());

            if (responseValidation.Status == ResponseStatusEnum.OK)
            {
                var response = await _userService.GetUserDetails(model.Id);
                Log.Information("[UserDetailResponseModel] " + response.ToJson());
                return Json(response);
            }
            else
            {
                Log.Error("[UserDetailResponseModel] " + responseValidation.ToJson());
                return Json(responseValidation);
            }
        }


        // PUT api/<controller>/5    Update User Detail 
        [HttpPut]
        public async Task<JsonResult> Put([FromBody] UserUpdateRequestModel model)
        {
            Log.Information("[UserUpdateRequestModel] " + model.ToJson());

            var responseValidation = CheckValidation(model, APIActionEnum.UserUpdate.ToString());

            if (responseValidation.Status == ResponseStatusEnum.OK)
            {
                BaseResponseModel response = await _userService.Update(model);

                Log.Information("[UserUpdateResponseModel] " + response.ToJson());
                return Json(response);
            }
            else
            {
                Log.Error("[UserUpdateResponseModel] " + responseValidation.ToJson());
                return Json(responseValidation);
            }

        }

        [HttpPost("List")]
        public JsonResult List(UserListRequestModel model)
        {
            Log.Information("[UserListRequestModel] " + model.ToJson());

            var responseValidation = CheckValidation(model, APIActionEnum.UserList.ToString());

            if (responseValidation.Status == ResponseStatusEnum.OK)
            {
                var response = _userService.GetList(model);
                Log.Information("[UserListResponseModel] " + response.ToJson());
                return Json(response);
            }
            else
            {
                Log.Error("[UserListResponseModel] " + responseValidation.ToJson());
                return Json(responseValidation);
            }
        }


        [HttpPost]
        public async Task<JsonResult> Post([FromBody] UserCreateRequestModel model)
        {
            Log.Information("[UserCreateRequestModel] " + model.ToJson());
            model.TimeSpan = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var responseValidation = CheckValidation(model, APIActionEnum.UserCreate.ToString());

            if (responseValidation.Status == ResponseStatusEnum.OK)
            {
                BaseResponseModel response = await _userService.Add(model);

                Log.Information("[UserCreateResponseModel] " + response.ToJson());
                return Json(response);

            }
            else
            {
                Log.Error("[UserCreateResponseModel] " + responseValidation.ToJson());
                return Json(responseValidation);
            }
        }


        // DELETE api/<controller>/5
        [HttpDelete]
        public async Task<JsonResult> Delete(UserUpdateRequestModel model)
        {
            Log.Information("[UserDeleteRequestModel] " + model.ToJson());

            var responseValidation = CheckValidation(model, APIActionEnum.UserDelete.ToString());

            if (responseValidation.Status == ResponseStatusEnum.OK)
            {
                BaseResponseModel response = await _userService.Delete(model);

                Log.Information("[UserDeleteResponseModel] " + response.ToJson());
                return Json(response);
            }
            else
            {
                Log.Error("[UserDeleteResponseModel] " + responseValidation.ToJson());
                return Json(responseValidation);
            }
        }
    }
}
