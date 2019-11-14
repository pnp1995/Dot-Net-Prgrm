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
            //var result = await this.FindByEmailAsync(adminLoginModel.Email);
            //if(result != null)
            //{
            //    bool admin = userContext.AdminloginDetail.Any(e => e.Email == adminLoginModel.Email &&  e.Password == adminLoginModel.Password);
            //    if (admin)
            //    {
            //        return "Login Successfully";
            //    }
            //}
           // return "Ivalid";
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
    }
}
