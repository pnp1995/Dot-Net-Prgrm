
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Common.Models;
using FundooRepository.Context;
using FundooRepository.FundooInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace FundooRepository.Repository
{
    public class AccountRepository : IAccountRepo
    {
        // private readonly IConfiguration configuration;
        private readonly UserContext userContext;
        private readonly ApplicationSettings settings;
        private readonly IAdminRepo admin;

        // private string loginModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>

        public AccountRepository(UserContext userContext,IOptions<ApplicationSettings> _setting, IAdminRepo _admin)
        {
            this.userContext = userContext;
            settings = _setting.Value;
            admin = _admin;
            //this.configuration = configuration;                 
        }
        public Task CreateAsync(UserModel userModel)
        {
            UserModel userModel1 = new UserModel()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Emailid = userModel.Emailid,
                Password = userModel.Password,
                CardType = userModel.CardType,
                ProfilePicUpload =userModel.ProfilePicUpload
            };
            userContext.UserDetail.Add(userModel);
            return Task.Run(() => userContext.SaveChanges());
        }
        public async Task<string> LoginAsync(LoginModel login)
        {
            var result = userContext.UserDetail.Find(login.Emailid);
            if (result != null)
            {
                var tokenhandler = new JwtSecurityTokenHandler();
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                       new Claim("Emailid",result.Emailid)
                    }),
                    Expires = DateTime.UtcNow.AddDays(2),
                    SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var securitytoken = tokenhandler.CreateToken(tokenDescriptor);
                var Token = tokenhandler.WriteToken(securitytoken);
                // for logintime of user
                await admin.AdminLogin(result, DateTime.Now);
                return await Task.Run(() => Token);
            }
            else
            {
                return null;
            }
        }
        public Task<UserModel> FindByEmail(string email)
        {
            var user = userContext.UserDetail.Find(email);
            return Task.Run(() => user);

        }
        public async Task<UserModel> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var user = userContext.UserDetail.Where(p => p.Password == resetPasswordModel.Password && p.Emailid == resetPasswordModel.Emailid).Single();
                if (user != null)
                {
                    var result = this.GeneratePasswordReset(resetPasswordModel);
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<IdentityUser> FindByEmailidAsync(string emailid)
        {
            UserModel model = this.userContext.UserDetail.Where(p => p.Emailid == emailid).FirstOrDefault();
            IdentityUser Iuser = new IdentityUser()
            {
                Email = model.Emailid
            };
            return Task.Run(() => Iuser);
        }

        public object GeneratePasswordReset(ResetPasswordModel resetPasswordModel)
        {
            var result = userContext.UserDetail.Where(p => p.Emailid == resetPasswordModel.Emailid).FirstOrDefault();
            result.Password = resetPasswordModel.NewPassword;
            userContext.Update(result);
            return Task.Run(() => userContext.SaveChanges());
            throw new NotImplementedException();
        }
        public async Task ForgetPasswordAsync(ForgetPasswordModel forgetPasswordModel)
        {
            try
            {
                var user = await this.FindByEmailidAsync(forgetPasswordModel.Emailid);
                if (user != null)
                {
                    var fromEmailid = new MailAddress("pritampriyanand@gmail.com");
                    var fromPassword = "pnp@1995";
                    var ToAdress = new MailAddress(forgetPasswordModel.Emailid);
                    string Subject = "Reset Password";
                    string Body = "To reset your password click on link+";
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Credentials = new NetworkCredential(fromEmailid.Address, fromPassword),
                        EnableSsl = true,
                    };
                    using (var message = new MailMessage(fromEmailid, ToAdress)
                    {
                        Subject = Subject,
                        Body = Body
                    })
                        try
                        {
                            smtp.Send(message);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<UserModel> GoogleLoginAsync(LoginModel loginModel)      
        {
            try
            {
                var user = userContext.UserDetail.Where(p =>p.Emailid == loginModel.Emailid).FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<UserModel> FacebookLoginAsync(LoginModel loginModel)
        {
            try
            {
                var user = userContext.UserDetail.Where(p => p.Emailid == loginModel.Emailid).FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string ProfilePicUpload(string Emailid, IFormFile formFile)
        {
            var path = formFile.OpenReadStream();
            var fileName = formFile.FileName;
            CloudinaryDotNet.Account cloudinary = new CloudinaryDotNet.Account("dtddmoers", "745684864855497", "b4WAINSfnC1hJPAyikC525T3HUM");
            CloudinaryDotNet.Cloudinary cloud = new CloudinaryDotNet.Cloudinary(cloudinary);
            var Uploadfile = new ImageUploadParams()
            {
                File = new FileDescription(fileName, path)
            };
            var data = cloud.Upload(Uploadfile);
            var result = userContext.UserDetail.Where(i => i.Emailid == Emailid).SingleOrDefault();
            result.ProfilePicUpload = data.Uri.ToString();
            userContext.SaveChanges();
            return result.ProfilePicUpload;
        }
    }     
}

        
    

