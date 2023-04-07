using BlazorTrendApplication.Infrastructure.Context;
using BlazorTrendApplication.Infrastructure.Interfaces;
using BlazorTrendApplication.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BlazorTrendApplication.Infrastructure.Repository
{
    public class TrendRepository : ITrendRepository
    {
        protected readonly trend_shraddhaContext _context;

        public TrendRepository(trend_shraddhaContext context)
        {
            _context = context;
        }

        public IEnumerable<TrendModel> GetTrendsData()
        {
            List<TrendModel> trends = new List<TrendModel>();
            try
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var folderPath = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "Image");

                var trendlst = _context.Trends.Where(x => x.Active == true && x.DeletedBy != 1).ToList();
                foreach (var trend in trendlst)
                {
                    TrendModel trendModel = new TrendModel();
                    trendModel.Id = trend.Id;
                    trendModel.TrendType = trend.TrendType;
                    trendModel.Title = trend.Title;
                    trendModel.Introduction = trend.Introduction;
                    trendModel.Summary = trend.Summary;
                    trendModel.TargetedViewer = trend.TargetedViewer;
                    trendModel.UserId = trend.UserId;
                    trendModel.Active = (bool)trend.Active;
                    trendModel.Status = trend.Active == true ? "Active" : "InActive";
                    trendModel.Price = trend.Price;
                    trendModel.FileName = trend.FileUpload;
                    if (!string.IsNullOrEmpty(trend.FileUpload))
                    {
                        var filepath = Path.Combine(folderPath, trend.FileUpload);
                        var exte = Path.GetExtension(trend.FileUpload).Substring(1);
                        var docBytes = System.IO.File.ReadAllBytes(filepath);
                        string fileEncodedStr = "data:image/" + exte + ";base64," + Convert.ToBase64String(docBytes);
                        trendModel.ImgFile = fileEncodedStr;
                    }
                    trends.Add(trendModel);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trends;
        }

        public IEnumerable<TrendModel> GetTrendsDataByUserId(int userId)
        {
            List<TrendModel> trends = new List<TrendModel>();
            try
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var folderPath = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "Image");

                var trendlst = _context.Trends.Where(x => x.UserId == userId && x.DeletedBy != 1).ToList();
                foreach (var trend in trendlst)
                {
                    TrendModel trendModel = new TrendModel();
                    trendModel.Id = trend.Id;
                    trendModel.TrendType = trend.TrendType;
                    trendModel.Title = trend.Title;
                    trendModel.Introduction = trend.Introduction;
                    trendModel.Summary = trend.Summary;
                    trendModel.TargetedViewer = trend.TargetedViewer;
                    trendModel.UserId = trend.UserId;
                    trendModel.Active = (bool)trend.Active;
                    trendModel.Status = trend.Active == true ? "Active" : "InActive";
                    trendModel.Price = trend.Price;
                    trendModel.FileName = trend.FileUpload;
                    if (!string.IsNullOrEmpty(trend.FileUpload))
                    {
                        var filepath = Path.Combine(folderPath, trend.FileUpload);
                        var exte = Path.GetExtension(trend.FileUpload).Substring(1);
                        var docBytes = System.IO.File.ReadAllBytes(filepath);
                        string fileEncodedStr = "data:image/" + exte + ";base64," + Convert.ToBase64String(docBytes);
                        trendModel.ImgFile = fileEncodedStr;
                    }
                    trends.Add(trendModel);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trends;
        }

        public TrendModel GetTrendsDataById(int Id)
        {
            TrendModel trendModel = new TrendModel();
            try
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var folderPath = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "Image");

                var trend = _context.Trends.Where(x => x.Id == Id && x.DeletedBy != 1).FirstOrDefault();
                trendModel.Id = trend.Id;
                trendModel.TrendType = trend.TrendType;
                trendModel.Title = trend.Title;
                trendModel.Introduction = trend.Introduction;
                trendModel.Summary = trend.Summary;
                trendModel.TargetedViewer = trend.TargetedViewer;
                trendModel.UserId = trend.UserId;
                trendModel.Active = (bool)trend.Active;
                trendModel.Status = trend.Active == true ? "Active" : "InActive";
                trendModel.Price = trend.Price;
                trendModel.FileName = trend.FileUpload;
                if (!string.IsNullOrEmpty(trend.FileUpload))
                {
                    var filepath = Path.Combine(folderPath, trend.FileUpload);
                    var exte = Path.GetExtension(trend.FileUpload).Substring(1);
                    var docBytes = System.IO.File.ReadAllBytes(filepath);
                    string fileEncodedStr = "data:image/" + exte + ";base64," + Convert.ToBase64String(docBytes);
                    trendModel.ImgFile = fileEncodedStr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trendModel;
        }
        public bool SaveTrendData(TrendModel trendModel, string path)
        {
            bool result = false;
            try
            {
                Trend trend = trendModel.Id > 0 ? _context.Trends.Find(trendModel.Id) : new Trend();
                trend.TrendType = trendModel.TrendType;
                trend.Title = trendModel.Title;
                trend.Introduction = trendModel.Introduction;
                trend.Summary = trendModel.Summary;
                trend.FileUpload = trendModel.FileName;
                trend.TargetedViewer = trendModel.TargetedViewer;
                trend.UserId = trendModel.UserId;
                trend.Price = trendModel.Price;
                trend.Active = trendModel.Active;
                if (trendModel.Id > 0)
                {
                    trend.Id = trendModel.Id;
                    trend.UpdatedBy = 1;
                    trend.UpdatedDate = DateTime.Now;
                }
                else
                {
                    trend.CreatedBy = 1;
                    trend.CreatedDate = DateTime.Now;
                    _context.Add(trend);
                }
                _context.SaveChanges();
                if (trendModel.ImgChanged)
                {
                    saveFile(path, trendModel.FileName, trendModel.ImgSrc);
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool DeleteTrend(int Id)
        {
            bool result = false;
            try
            {
                Trend trend = _context.Trends.Find(Id);
                trend.DeletedBy = 1;
                trend.DeletedDate = DateTime.Now;
                _context.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public bool AddSharedTrendDataAndSendMail(SharedTrendsModel sharedTrends)
        {
            bool result = false;
            try
            {
                SharedTrend shared = new SharedTrend();
                shared.Email = sharedTrends.Email;
                shared.Message = sharedTrends.Message;
                shared.TrendId = sharedTrends.TrendId;
                shared.CreatedBy = 1;
                shared.CreatedDate = DateTime.Now;
                _context.Add(shared);
                _context.SaveChanges();
                //string message = sharedTrends.Message + " Trend link: " + sharedTrends.TrendLink;
                //result = Helper.SendMail("shraddha250996@gamil.com", sharedTrends.Email, "Share Trend", message);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void saveFile(string path, string filename, string imgfile)
        {
            var base64 = Convert.FromBase64String(imgfile);
            string filePath = Path.Combine(path, filename);
            using (var fileStream = System.IO.File.Create(filePath))
            {
                fileStream.Write(base64);
            }
        }
    }
}
