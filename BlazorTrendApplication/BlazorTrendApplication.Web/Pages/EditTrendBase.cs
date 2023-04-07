using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Data;
using BlazorTrendApplication.Web.Interfaces;
using BlazorTrendApplication.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrendApplication.Web.Pages
{
    public class EditTrendBase : ComponentBase
    {
        [Inject]
        public ITrendService _trendService { get; set; }
        [Inject]
        public GlobalService _globalService { get; set; }
        [Inject]
        public Mapper _mapper { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }
        public TrendModel trend { get; set; } = new TrendModel();
        public enum TrendTypes { Technology, Fashion, Jwellry, Education };

        protected async override Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                var result = (await _trendService.GetTrendsDataById(int.Parse(Id))).Data;
                trend = _mapper.convertTrend(result);
            }
        }

        protected async void selectimgfile(InputFileChangeEventArgs e)
        {
            foreach (var file in e.GetMultipleFiles())
            {
                var imgfile = await file.RequestImageFileAsync(file.ContentType, 100, 100);
                var buffer = new byte[imgfile.Size];
                await imgfile.OpenReadStream().ReadAsync(buffer);
                trend.FileName = Guid.NewGuid() + file.Name;
                trend.ImgFile = $"data: image / " + file.ContentType + "; base64," + Convert.ToBase64String(buffer);
                trend.ImgSrc = Convert.ToBase64String(buffer);
                trend.ImgChanged = true;
            }
        }
        protected async Task saveTrend()
        {
            _globalService.userId.Subscribe(x =>  trend.UserId = int.Parse(x));
            var result = (await _trendService.SaveTrendData(trend)).Data;
            if (result)
            {
                _navigationManager.NavigateTo("/trendlist");
            }
        }

    }
}
