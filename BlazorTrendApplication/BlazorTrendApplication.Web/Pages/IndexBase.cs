using Blazorise;
using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrendApplication.Web.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public ITrendService _trendService { get; set; }

        public IEnumerable<TrendModel> trends { get; set; }
        protected Modal modalShareTrend;
        public  SharedTrendsModel sharedTrends { get; set; } = new SharedTrendsModel();

        protected override async Task OnInitializedAsync()
        {
            trends = (await _trendService.GetTrendsData()).Data;
        }

        //protected Task openShareTrend(int id)
        //{
        //    sharedTrends.TrendId = id;
        //    sharedTrends.TrendLink = "";
        //    return modalShareTrend.Show();
        //}

        
    }
}
