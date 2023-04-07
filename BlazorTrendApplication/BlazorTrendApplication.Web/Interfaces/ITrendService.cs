using BlazorTrendApplication.Infrastructure.Models;
using BlazorTrendApplication.Web.Data;

namespace BlazorTrendApplication.Web.Interfaces
{
    public interface ITrendService
    {
        Task<PageResponse<IEnumerable<TrendModel>>> GetTrendsData();
        Task<PageResponse<IEnumerable<TrendModel>>> GetTrendsDataByUserId(int userId);
        Task<PageResponse<bool>> SaveTrendData(TrendModel trendview);
        Task<PageResponse<TrendModel>> GetTrendsDataById(int Id);
        Task DeleteTrend(int Id);
        Task<PageResponse<bool>> AddSharedTrendDataAndSendMail(SharedTrendsModel sharedTrends);

    }
}
