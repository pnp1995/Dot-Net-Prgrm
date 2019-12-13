// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models;
using FundooManager.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  
    public class AccountController : ControllerBase
    {
        private readonly IAccount account;
        public readonly object Assert;
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public AccountController(IAccount account)
        {
            this.account = account;
        }
        /// <summary>
        /// Registrations the specified user model.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Registration(UserModel userModel)
      {
            try
            {
                var result = await account.CreateAsync(userModel);
                return this.Ok(new { result });
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {

                var result = await account.Login(loginModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Finds this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet,Authorize]
        [Route("jwt")]
        public async Task<object> Find()
        {

            string Email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;
            var result = await account.FindByEmail(Email);
            return new
            {
                result.Emailid,
                result.FirstName,
                result.LastName,
                result.CardType
            };
        }
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var result = await account.ResetPassword(resetPasswordModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordModel forgetPasswordModel)
        {
            try
            {
                var result =await this.account.ForgetPassword(forgetPasswordModel);
                if(result!=null)
                {
                    return this.Ok(new { result });
                }
                else
                {
                    return this.BadRequest();
                }
            }
             catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("google")]
        public async Task<IActionResult> GoogleLogin(LoginModel loginModel)
        {
            try
            {
                var result = await this.account.GoogleLogin(loginModel);
                if (result != null)
                {
                    return this.Ok(new { result });
                }
                else
                {
                    return this.BadRequest();
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Facebooks the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("fb")]
        public async Task<IActionResult> FacebookLogin(LoginModel loginModel)
        {
            try
            {
                var result = await this.account.FacebookLogin(loginModel);
                if (result != null)
                {
                    return this.Ok(new { result });
                }
                else
                {
                    return this.BadRequest();
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Profiles the pic upload.
        /// </summary>
        /// <param name="Emailid">The emailid.</param>
        /// <param name="file">The form file.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("profilepic")]
        [Authorize]
        public IActionResult ProfilePicUpload(IFormFile file)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;
                var result = account.ProfilePicUpload(Email, file);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}