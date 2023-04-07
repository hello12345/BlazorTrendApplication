using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Data;
using BlazorTrendApplication.Web.Interfaces;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BlazorTrendApplication.Web.Services
{
    public class TrendService : ITrendService
    {
        private readonly HttpClient _http;
        private readonly Mapper _mapper;
        public TrendService(HttpClient http, Mapper mapper)
        {
            _http = http;
            _mapper = mapper;
        }
            public async Task<PageResponse<IEnumerable<TrendModel>>> GetTrendsData()
            {
                return await _http.GetJsonAsync<PageResponse<IEnumerable<TrendModel>>>("api/Trend/GetTrendsData");
            }
        public async Task<PageResponse<IEnumerable<TrendModel>>> GetTrendsDataByUserId(int userId)
        {
            return await _http.GetJsonAsync<PageResponse<IEnumerable<TrendModel>>>($"api/Trend/GetTrendsDataByUserId?userId={userId}");
        }

        public async Task<PageResponse<TrendModel>> GetTrendsDataById(int Id)
        {
            return await _http.GetJsonAsync<PageResponse<TrendModel>>($"api/Trend/GetTrendsDataById?Id={Id}");
        }
        public async Task<PageResponse<bool>> SaveTrendData(TrendModel trendview)
        {
            TrendModel trend = _mapper.convertTrend(trendview);
            return await _http.PostJsonAsync<PageResponse<bool>>("api/Trend/SaveTrendData", trend);
        }

        public async Task DeleteTrend(int Id)
        {
            await _http.DeleteAsync($"api/Trend/DeleteTrend?Id={Id}");
        }

        public async Task<PageResponse<bool>> AddSharedTrendDataAndSendMail(SharedTrendsModel sharedTrends)
        {
            return await _http.PostJsonAsync<PageResponse<bool>>("api/Trend/AddSharedTrendDataAndSendMail", sharedTrends);
        }
    }
}
