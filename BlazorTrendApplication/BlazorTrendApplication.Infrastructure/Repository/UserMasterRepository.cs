using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlazorTrendApplication.Infrastructure.Context;
using BlazorTrendApplication.Infrastructure.Interfaces;
using BlazorTrendApplication.Infrastructure.Models;

namespace BlazorTrendApplication.Infrastructure.Repository
{
    public class UserMasterRepository : IUserMasterRepository
    {
        protected readonly trend_shraddhaContext _context;

        public UserMasterRepository(trend_shraddhaContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsersData()
        {
            List<User> users = new List<User>();
            try
            {
                users = _context.Users.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return users;
        }
        public User GetUserById(int Id)
        {
            User user = new User();
            try
            {
                user = _context.Users.Where(x => x.Id == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }
        public User GetUserByName(string userName)
        {
            User user = new User();
            try
            {
                user = _context.Users.Where(x => x.UserName.Trim() == userName.Trim()).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }
        public User SaveUserData(UserModel userModel)
        {
            User usr = new User();
            try
            {
                Random rnd = new Random();
                int otp = rnd.Next(1000, 9999);
                User user = userModel.Id > 0 ? _context.Users.Find(userModel.Id) : new User();
                user.FirstName = userModel.FirstName;
                user.LastName = userModel.LastName;
                user.UserName = userModel.UserName;
                user.Password = userModel.Password;
                user.Email = userModel.Email;
                user.Phone = userModel.Phone;
                user.Active = userModel.Active;
                user.OneTimePassword = otp;
                //user.OneTimePassword = userModel.OneTimePassword;
                if (userModel.Id > 0)
                {
                    user.Id = userModel.Id;
                    user.UpdatedBy = 1;
                    user.UpdatedDate = DateTime.Now;
                }
                else
                {
                    user.CreatedBy = 1;
                    user.CreatedDate = DateTime.Now;
                    _context.Add(user);
                }

                _context.SaveChanges();
                usr = GetUserByName(userModel.UserName);
                //string message = "OTP for Verification: " + otp;
                //result = Helper.SendMail("shraddha250996@gamil.com", "shraddha.parmar@spec-india.com", "OTP varification", message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usr;
        }
        public int ReSendOTP(int Id)
        {
            int otp = 0;
            try
            {
                Random rnd = new Random();
                otp = rnd.Next(1000, 9999);
                User user = _context.Users.Find(Id);
                user.OneTimePassword = otp;
                user.UpdatedBy = 1;
                user.UpdatedDate = DateTime.Now;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return otp;
        }
        public User Login(string UserName, string Password)
        {
            User user = new User();
            try
            {
                if (_context.Users.Any(x => x.UserName.Trim() == UserName.Trim() && x.Password.Trim() == Password.Trim() && x.Active == true))
                    user = GetUserByName(UserName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }
        public bool VerifiyyOTP(int Id, int OTP)
        {
            bool result = false;
            try
            {
                User user = _context.Users.Find(Id);
                result = user.OneTimePassword == OTP ? true : false;
                if (result == true)
                {
                    user.Active = true;
                    user.UpdatedBy = 1;
                    user.UpdatedDate = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public IEnumerable<UserDetailViewModel> GetUserDetailData()
        {
            List<UserDetailViewModel> usersview = new List<UserDetailViewModel>();
            try
            {
               var users = _context.UserDetails.ToList();
                foreach (var item in users)
                {
                    UserDetailViewModel user = new UserDetailViewModel();
                    user.Id = item.Id;
                    user.Name = item.Name;
                    user.Description = item.Description;
                    user.Email = item.Email;
                    usersview.Add(user);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return usersview;
        }

        public bool SaveUserDetailData(UserDetailViewModel userDetail)
        {
            bool result = false;
            try
            {
                var user = userDetail.Id > 0 ? _context.UserDetails.Find(userDetail.Id) : new UserDetail();
                user.Name = userDetail.Name;
                user.Description = userDetail.Description;
                user.Email = userDetail.Email;
                //user.OneTimePassword = userModel.OneTimePassword;
                if (userDetail.Id > 0)
                    user.Id = userDetail.Id;
                else
                    _context.Add(user);

                _context.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool DeleteUserDetailData(int Id)
        {
            bool result = false;
            try
            {
                var user = _context.UserDetails.Find(Id);
                if (user != null)
                {
                    _context.Remove(user);
                    _context.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
