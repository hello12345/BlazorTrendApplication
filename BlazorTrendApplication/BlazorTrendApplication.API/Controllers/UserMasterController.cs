using BlazorTrendApplication.Infrastructure.Context;
using BlazorTrendApplication.Infrastructure.Interfaces;
using BlazorTrendApplication.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTrendApplication.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserMasterController : Controller
    {
        private IUserMasterRepository _userMasterRepository;

        public UserMasterController(IUserMasterRepository userMasterRepository)
        {
            _userMasterRepository = userMasterRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = _userMasterRepository.GetUsersData();
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> SaveUserData(UserModel userModel)
        {
            var response = new PageResponse<User>();
            try
            {
                var data = await Task.FromResult(_userMasterRepository.SaveUserData(userModel));

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
        public async Task<ActionResult> ReSendOTP(int Id)
        {
            var response = new PageResponse<int>();
            try
            {
                var data = await Task.FromResult(_userMasterRepository.ReSendOTP(Id));

                response.StatusCode = "Success";
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.StatusCode = "Error";
                response.ErrorMessage = ex.Message;
                response.Data = 0;
            }
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult> VerifiyyOTP(int Id, int OTP)
        {
            var response = new PageResponse<bool>();
            try
            {
                var data = await Task.FromResult(_userMasterRepository.VerifiyyOTP(Id, OTP));

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

        [HttpGet]
        public async Task<ActionResult> Login(string UserName, string Password)
        {
            var response = new PageResponse<User>();
            try
            {
                var data = await Task.FromResult(_userMasterRepository.Login(UserName, Password));

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
        public async Task<ActionResult> SaveUserDetailData(UserDetailViewModel userDetail)
        {
            var response = new PageResponse<bool>();
            try
            {
                var data = await Task.FromResult(_userMasterRepository.SaveUserDetailData(userDetail));

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

        [HttpGet]
        public async Task<ActionResult> GetUserDetailData()
        {
            var response = new PageResponse<IEnumerable<UserDetailViewModel>>();
            try
            {
                var data = await Task.FromResult(_userMasterRepository.GetUserDetailData());

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
        [HttpDelete]
        public async Task<ActionResult> DeleteUserDetailData(int Id)
        {
            var response = new PageResponse<bool>();
            try
            {
                var data = await Task.FromResult(_userMasterRepository.DeleteUserDetailData(Id));

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
    }
}
