using Common.Models;
using FundooManager.Interface;
using FundooRepository.Context;
using FundooRepository.FundooInterface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
   public class AccountManager : IAccount
   {
        //private readonly IConfiguration configuration;
        private readonly IAccountRepo accountRepo;
        public AccountManager(IAccountRepo accountRepo)
        {
            this.accountRepo = accountRepo;
        }
        public async Task<string> CreateAsync(UserModel userModel)
        {
            try
            {
                await this.accountRepo.CreateAsync(userModel);
                return "Registration Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> Login(LoginModel loginModel)
        {
            try
            {
                var Token = await accountRepo.LoginAsync(loginModel);
                return Token;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<UserModel> FindByEmail(string email)
        {
            var result = await accountRepo.FindByEmail(email);
            return result;
        }
        public async Task<string> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var result = await this.accountRepo.ResetPasswordAsync(resetPasswordModel);
                if (result != null)
                {
                    return "ResetPassword Successfully";
                }
                else
                {
                    return "Invalid Emailid";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> ForgetPassword(ForgetPasswordModel forgetPasswordModel)
        {
           await this.accountRepo.ForgetPasswordAsync(forgetPasswordModel);
            return "ForgetPassword Successfully Done";
        }
        public async Task<string> GoogleLogin(LoginModel loginModel)
        {
            try
            {
                var result = await this.accountRepo.GoogleLoginAsync(loginModel);
                if (result != null)
                {
                    return "Login Successfully";
                }
                else
                {
                    return "Invalid User";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> FacebookLogin(LoginModel loginModel)
        {
            try
            {
                var result = await this.accountRepo.FacebookLoginAsync(loginModel);
                if (result != null)
                {
                    return " fb Login Successfully";
                }
                else
                {
                    return "Invalid User";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string ProfilePicUpload(string Emailid, IFormFile formFile)
        {
            try
            {
                accountRepo.ProfilePicUpload(Emailid, formFile);
                return "Image upload Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
