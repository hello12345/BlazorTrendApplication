using BlazorTrendApplication.Infrastructure.Interfaces;
using BlazorTrendApplication.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTrendApplication.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TrendController : Controller
    {
        private ITrendRepository _trendRepository;

        public TrendController(ITrendRepository trendRepository)
        {
            _trendRepository = trendRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetTrendsData()
        {
            var response = new PageResponse<IEnumerable<TrendModel>>();
            try
            {
                var data = await Task.FromResult(_trendRepository.GetTrendsData());

                response.StatusCode = "Success";
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = null;
            }
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult> GetTrendsDataByUserId(int userId)
        {
            var response = new PageResponse<IEnumerable<TrendModel>>();
            try
            {
                var data = await Task.FromResult(_trendRepository.GetTrendsDataByUserId(userId));

                response.StatusCode = "Success";
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = null;
            }
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult> GetTrendsDataById(int Id)
        {
            var response = new PageResponse<TrendModel>();
            try
            {
                var data = await Task.FromResult(_trendRepository.GetTrendsDataById(Id));

                response.StatusCode = "Success";
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = null;
            }
            return Ok(response);
        }


        [HttpPost]
        public async Task<ActionResult> SaveTrendData(TrendModel trendModel)
        {
            var response = new PageResponse<bool>();
            try
            {
                var path = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "Image");
                var data = await Task.FromResult(_trendRepository.SaveTrendData(trendModel, path));

                response.StatusCode = "Success";
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = false;
            }
            return Ok(response);
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteTrend(int Id)
        {
            var response = new PageResponse<bool>();
            try
            {
                var data = await Task.FromResult(_trendRepository.DeleteTrend(Id));

                response.StatusCode = "Success";
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = false;
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> AddSharedTrendDataAndSendMail(SharedTrendsModel sharedTrends)
        {
            var response = new PageResponse<bool>();
            try
            {
                var data = await Task.FromResult(_trendRepository.AddSharedTrendDataAndSendMail(sharedTrends));

                response.StatusCode = "Success";
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = false;
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveImageFile()
        {
            var response = new PageResponse<bool>();
            try
            {
                var files = Request.Form.Files;
                foreach (var file in files)
                {
                    var path = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "Image");
                    string filePath = Path.Combine(path, file.FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }

                response.StatusCode = "Success";
                response.Data = true;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = false;
            }
            return Ok(response);
        }
    }
}
