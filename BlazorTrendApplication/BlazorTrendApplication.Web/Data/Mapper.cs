using BlazorTrendApplication.Infrastructure.Models;

namespace BlazorTrendApplication.Web.Data
{
    public class Mapper
    {
        public TrendModel convertTrend(TrendModel trendView)
        {
            TrendModel trend = new TrendModel();
            trend.Id = Convert.ToInt32(trendView.Id);
            trend.TrendType = trendView.TrendType == null ? "" : trendView.TrendType;
            trend.Title = trendView.Title == null ? "" : trendView.Title;
            trend.Introduction = trendView.Introduction == null ? "" : trendView.Introduction;
            trend.Summary = trendView.Summary == null ? "" : trendView.Summary;
            trend.FileName = trendView.FileName == null ? "" : trendView.FileName;
            trend.ImgFile = trendView.ImgFile == null ? "" : trendView.ImgFile;
            trend.TargetedViewer = trendView.TargetedViewer == null ? "" : trendView.TargetedViewer;
            trend.Price = trendView.Price == null ? 0 : trendView.Price;
            trend.UserId = trendView.UserId == null ? 0 : trendView.UserId; 
            trend.Active = trendView.Active;
            trend.ImgChanged = trendView.ImgChanged;
            trend.ImgSrc = trendView.ImgSrc == null ? "" : trendView.ImgSrc;
            trend.Status = trendView.Status == null ? "" : trendView.Status;
            return trend;
        }

        //public TrendViewModel convertTrendViewModel(TrendModel trendView)
        //{
        //    TrendViewModel trend = new TrendViewModel();
        //    trend.Id = Convert.ToInt32(trendView.Id);
        //    trend.TrendType = trendView.TrendType;
        //    trend.Title = trendView.Title;
        //    trend.Introduction = trendView.Introduction;
        //    trend.Summary = trendView.Summary;
        //    trend.FileName = trendView.FileName;
        //    trend.ImgFile = trendView.ImgFile;
        //    trend.TargetedViewer = trendView.TargetedViewer;
        //    trend.Price = trendView.Price == null ? "" : Convert.ToString(trendView.Price);
        //    trend.UserId = trendView.UserId;
        //    trend.Active = trendView.Active == null ? false : (bool)trendView.Active;
        //    trend.ImgChanged = trendView.ImgChanged;
        //    trend.ImgSrc = trendView.ImgSrc;
        //    trend.Status = trendView.Status;
        //    return trend;
        //}
    }
}
