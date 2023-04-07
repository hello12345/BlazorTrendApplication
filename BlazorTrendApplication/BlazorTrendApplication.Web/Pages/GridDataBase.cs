using Blazorise;
using Blazorise.DataGrid;
using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Data;
using BlazorTrendApplication.Web.Interfaces;
using BlazorTrendApplication.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorTrendApplication.Web.Pages
{
    public class GridDataBase : ComponentBase
    {
        [Inject]
        public IUserMasterService _userService { get; set; }
        [Inject]
        public GlobalService _globalService { get; set; }
        [Inject]
        public Mapper _mapper { get; set; }
        public IEnumerable<UserDetailViewModel> users { get; set; }
        public UserDetailViewModel selectedUser { get; set; }
        protected int totalTrendCount;
        [Parameter]
        public string Collapse { get; set; } = "collapse";
        protected override async Task OnInitializedAsync()
        {
            users = (await _userService.GetUserDetailData()).Data;
            await base.OnInitializedAsync();
        }
        protected async Task OnRowSave(SavedRowItem<UserDetailViewModel, Dictionary<string, object>> e)
        {
            var user = e.Item;
            var result = (await _userService.SaveUserDetailData(user)).Data;
            if (result)
            {
                users = (await _userService.GetUserDetailData()).Data;
                StateHasChanged();
            }
        }
        protected async Task OnRowRemoved(UserDetailViewModel user)
        {
            await _userService.DeleteUserDetailData(user.Id);
            users = (await _userService.GetUserDetailData()).Data;
            StateHasChanged();
        }
        public void CheckName(ValidatorEventArgs validationArgs)
        {
            ValidationRule.IsNotEmpty(validationArgs);

            if (validationArgs.Status == ValidationStatus.Error)
            {
                validationArgs.ErrorText = "Name can't be empty.";
            }
        }

        public void CheckEmail(ValidatorEventArgs e)
        {
            var email = Convert.ToString(e.Value);

            e.Status = string.IsNullOrEmpty(email) ? ValidationStatus.Error :
                email.Contains("@") ? ValidationStatus.Success : ValidationStatus.Error;
        }
        protected async Task OnReadData(DataGridReadDataEventArgs<UserDetailViewModel> e)
        {
            if (!e.CancellationToken.IsCancellationRequested)
            {
                if (e.ReadDataMode is DataGridReadDataMode.Virtualize)
                    users = (await _userService.GetUserDetailData()).Data.Skip(e.VirtualizeOffset).Take(e.VirtualizeCount).ToList();
                else if (e.ReadDataMode is DataGridReadDataMode.Paging)
                    users = (await _userService.GetUserDetailData()).Data.Skip((e.Page - 1) * e.PageSize).Take(e.PageSize).ToList();
                else
                    throw new Exception("Unhandled ReadDataMode");

                if (!e.CancellationToken.IsCancellationRequested)
                {
                    totalTrendCount = (await _userService.GetUserDetailData()).Data.Count();
                }
            }
        }
    }
}
