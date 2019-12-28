using Common.AdminModel;
using Common.Models;
using FundooRepository.Context;
using FundooRepository.FundooInterface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class AdminRepository : IAdminRepo
    {
        private readonly UserContext userContext;
        public AdminRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public Task AddAdmin(AdminLoginModel adminLoginModel)
        {
            AdminLoginModel adminLogin = new AdminLoginModel()
            {
                Email = adminLoginModel.Email,
                FirstName = adminLoginModel.FirstName,
                LastName = adminLoginModel.LastName,
                Password = adminLoginModel.Password
            };
            userContext.AdminloginDetail.Add(adminLoginModel);
            return Task.Run(() => userContext.SaveChanges());
        }
        public  Task AdminLogin(UserModel userModel, DateTime date)
        {
            AdminModel admin = new AdminModel()
            {
                Email = userModel.Emailid,
                LoginTime = date.ToString(),
                CardType = userModel.CardType

            };
            userContext.AdminDetail.Add(admin);
            return Task.Run(() => userContext.SaveChanges());
           
        }
        public bool LogInAdmin(string Email, string Password)
        {
            var result = userContext.AdminloginDetail.Where(p => p.Email == Email && p.Password == Password).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
                return false;
        }
        public Task<IdentityUser> FindByEmailAsync(string email)
        {
            AdminLoginModel model = this.userContext.AdminloginDetail.Where(p => p.Email == email).FirstOrDefault();
            IdentityUser Iuser = new IdentityUser()
            {
                Email = model.Email
            };
            return Task.Run(() => Iuser);
        }
        /// <summary>
        /// DisplayUserDetails method for displaying the user statistics
        /// </summary>
        /// <returns></returns>
        public Task<List<AdminModel>> DisplayUserDetails()
        {
            return Task.Run(() => userContext.AdminDetail.ToList());
        }

        /// <summary>
        /// DisplayUsers method for displaying the user details
        /// </summary>
        /// <returns></returns>
        public Task<List<UserModel>> DisplayUsers()
        {
            return Task.Run(() => userContext.UserDetail.ToList());
        }
    }
}
