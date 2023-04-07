using BlazorTrendApplication.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTrendApplication.Infrastructure.Interfaces
{
    public interface ITrendRepository
    {
        IEnumerable<TrendModel> GetTrendsData();
        IEnumerable<TrendModel> GetTrendsDataByUserId(int userId);
        TrendModel GetTrendsDataById(int Id);
        bool SaveTrendData(TrendModel trendModel,string path);
        bool DeleteTrend(int Id);
        bool AddSharedTrendDataAndSendMail(SharedTrendsModel sharedTrends);
    }
}
