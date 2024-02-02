namespace FreelancersApi.Services
{
    public interface IUserService
    {
        Task<ContentResponseModel<UserDetailResponseModel>> GetUserDetails(long id);                
        ListResponseModel<UserListResponseModel> GetList(UserListRequestModel model);
        Task<BaseResponseModel> Add(UserCreateRequestModel entity);
        Task<BaseResponseModel> Update(UserUpdateRequestModel entity);
        Task<BaseResponseModel> Delete(UserUpdateRequestModel entity);

    }
}
