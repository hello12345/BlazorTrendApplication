using Blazored.SessionStorage;
using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Data;
using BlazorTrendApplication.Web.Interfaces;
using BlazorTrendApplication.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorTrendApplication.Web.Pages
{
    public class LoginBase : ComponentBase
    {
        public LoginViewModel loginUser { get; set; } = new LoginViewModel();
        [Inject]
        public IUserMasterService _UserService { get; set; }
        [Inject]
        public GlobalService _globalService { get; set; }
        [Inject]
        public ISessionStorageService _sessionStorageService { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }
        [Inject]
        public AuthenticationStateProvider authenticationStateProvider { get; set; }
        protected async Task login()
        {
            var user = (await _UserService.Login(loginUser.UserName, loginUser.Password)).Data;
            if (user != null)
            {
                ((CustomAuthenticationStateProvider)authenticationStateProvider).MarkUserAsAuthenticated(loginUser);
                await _sessionStorageService.SetItemAsync("UserId", user.Id);
                await _sessionStorageService.SetItemAsync("UserName", user.UserName);
                _globalService.userName.OnNext(user.UserName);
                _globalService.userId.OnNext(user.Id.ToString());
                _navigationManager.NavigateTo("/");
            }
        }
    }
}
