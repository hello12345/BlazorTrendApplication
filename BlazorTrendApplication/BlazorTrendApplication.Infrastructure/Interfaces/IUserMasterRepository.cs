using BlazorTrendApplication.Infrastructure.Context;
using BlazorTrendApplication.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTrendApplication.Infrastructure.Interfaces
{
    public interface IUserMasterRepository
    {
        IEnumerable<User> GetUsersData();
        User GetUserById(int Id);
        User GetUserByName(string userName);
        User SaveUserData(UserModel userModel);
        int ReSendOTP(int Id);
        User Login(string UserName, string Password);
        bool VerifiyyOTP(int Id, int OTP);
        IEnumerable<UserDetailViewModel> GetUserDetailData();
        bool SaveUserDetailData(UserDetailViewModel userDetail);
        bool DeleteUserDetailData(int Id);

    }
}
