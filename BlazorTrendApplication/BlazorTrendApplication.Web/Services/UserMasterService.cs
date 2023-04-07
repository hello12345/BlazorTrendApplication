using Blazored.SessionStorage;
using BlazorTrendApplication.Infrastructure.Context;
using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTrendApplication.Web.Services
{
    public class UserMasterService : IUserMasterService
    {
        private readonly HttpClient _http;
        private readonly ISessionStorageService _sessionStorage;
        public UserMasterService(HttpClient http, ISessionStorageService sessionStorage)
        {
            _http = http;
            _sessionStorage = sessionStorage;
        }
        public async Task<PageResponse<User>> SaveUserData(UserModel userModel)
        {
            return await _http.PostJsonAsync<PageResponse<User>>("api/Trend/SaveUserData", userModel);
        }
        public async Task<PageResponse<User>> Login(string UserName, string Password)
        {
            return await _http.GetJsonAsync<PageResponse<User>>($"api/UserMaster/Login?UserName={UserName}&Password={Password}");
        }
        public async Task<string> Username()
        {
            return await _sessionStorage.GetItemAsync<string>("UserName");
        }
        public async Task<string> UserId()
        {
            return await _sessionStorage.GetItemAsync<string>("UserId");
        }
        public async Task<PageResponse<IEnumerable<UserDetailViewModel>>> GetUserDetailData()
        {
            return await _http.GetJsonAsync<PageResponse<IEnumerable<UserDetailViewModel>>>("api/UserMaster/GetUserDetailData");
        }
        public async Task<PageResponse<bool>> SaveUserDetailData(UserDetailViewModel userDetail)
        {
            return await _http.PostJsonAsync<PageResponse<bool>>("api/UserMaster/SaveUserDetailData", userDetail);
        }
        public async Task DeleteUserDetailData(int Id)
        {
            await _http.DeleteAsync($"api/UserMaster/DeleteUserDetailData?Id={Id}");
        }
    }
}
