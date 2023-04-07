using Microsoft.AspNetCore.Components;
using BlazorTrendApplication.Web.Data;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorTrendApplication.Web.Interfaces;
using BlazorTrendApplication.Web.Services;

namespace BlazorTrendApplication.Web.Shared
{
    public class HeaderBase : ComponentBase
    {
        public string userId { get; set; } = "2";
        public string userName { get; set; } = string.Empty;
        [Inject]
        public AuthenticationStateProvider authenticationStateProvider { get; set; }
        [Inject]
        public GlobalService _globalService { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }
        public void logout()
        {
            ((CustomAuthenticationStateProvider)authenticationStateProvider).MarkUserAsLoggedOut();
        }
        protected override async Task OnInitializedAsync()
        {
            _globalService.userName.Subscribe(x =>userName = x);
            _globalService.userId.Subscribe(x => userId = x);
        }
        public void redirectHomePage()
        {
            _navigationManager.NavigateTo("/");
        }
    }
}
