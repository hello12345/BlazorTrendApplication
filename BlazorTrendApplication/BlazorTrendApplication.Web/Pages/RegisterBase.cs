using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Data;
using BlazorTrendApplication.Web.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTrendApplication.Web.Pages
{
    public class RegisterBase : ComponentBase
    {
        public UserModel user { get; set; } = new UserModel();
        [Inject]
        public IUserMasterService _UserService { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }
        protected async Task saveUser()
        {
            var result = (await _UserService.SaveUserData(user)).Data;
            if (result != null)
            {
                _navigationManager.NavigateTo("/login");
            }
        }
    }
}
