using Blazorise;
using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTrendApplication.Web.Pages
{
    public class TrendListBase : ComponentBase
    {
        [Inject]
        public ITrendService _trendService { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string userId { get; set; }

        public int deletedId { get; set; }
        public IEnumerable<TrendModel> trends { get; set; }

        protected Modal modalTrend;

        protected bool cancelClose;
        protected override async Task OnInitializedAsync()
        {
            userId = userId ?? "2";
            trends = (await _trendService.GetTrendsDataByUserId(int.Parse(userId))).Data;
        }

        protected void edittrend(int Id)
        {
            _navigationManager.NavigateTo($"/edittrend/{Id}");
        }

        protected Task deletetrend(int Id)
        {
            deletedId = Id;
            return modalTrend.Show();
            //_navigationManager.NavigateTo($"/trendlist/{2}");
        }
        protected void createtrend()
        {
            _navigationManager.NavigateTo("/createtrend");
        }
        protected Task CloseModal()
        {
            return modalTrend.Hide();
        }

        protected async Task deleteTrend()
        {
            await _trendService.DeleteTrend(deletedId);
           // _navigationManager.NavigateTo($"/trendlist/{2}", true);
            modalTrend.Hide();
            userId = userId ?? "2";
            trends = (await _trendService.GetTrendsDataByUserId(int.Parse(userId))).Data;
            StateHasChanged();
        }
    }
}
