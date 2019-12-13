using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.FundooInterface
{
    public interface IAccountRepo
    {
        Task CreateAsync(UserModel userModel);
        Task<string> LoginAsync(LoginModel login);
        Task<UserModel> ResetPasswordAsync(ResetPasswordModel resetpasswordmodel);
        Task ForgetPasswordAsync(ForgetPasswordModel forgetPasswordModel);
        Task<IdentityUser> FindByEmailidAsync(string emailid);
        object GeneratePasswordReset(ResetPasswordModel resetPasswordModel);
        Task<UserModel> GoogleLoginAsync(LoginModel loginModel);
        Task<UserModel> FacebookLoginAsync(LoginModel loginModel);
        Task<UserModel> ProfilePicUpload(string Emailid, IFormFile formFile);
        Task<UserModel> FindByEmail(string email);
    }
}
