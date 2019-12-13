using Common.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public interface IAccount
    {
        Task<string> CreateAsync(UserModel userModel);
       Task<string> Login(LoginModel loginModel);
      
        Task<string> ResetPassword(ResetPasswordModel resetPasswordModel);
        Task<string> ForgetPassword(ForgetPasswordModel forgetPasswordModel);
        Task<string> GoogleLogin(LoginModel loginModel );
        Task<string> FacebookLogin(LoginModel loginModel);
        Task<UserModel> ProfilePicUpload(string Emailid, IFormFile formFile);
        Task<UserModel> FindByEmail(string email);
    }
}
