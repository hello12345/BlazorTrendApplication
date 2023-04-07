using BlazorTrendApplication.Infrastructure.Context;
using BlazorTrendApplication.Infrastructure.Models;

namespace BlazorTrendApplication.Web.Interfaces
{
    public interface IUserMasterService
    {
        Task<PageResponse<User>> SaveUserData(UserModel userModel);
        Task<PageResponse<User>> Login(string UserName, string Password);
        Task<string> Username();
        Task<string> UserId();
        Task<PageResponse<IEnumerable<UserDetailViewModel>>> GetUserDetailData();
        Task<PageResponse<bool>> SaveUserDetailData(UserDetailViewModel userDetail);
        Task DeleteUserDetailData(int Id);
    }
}
