using Common.AdminModel;
using Common.Models;
using FundooManager.Interface;
using FundooRepository.FundooInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class AdminManager : IAdmin
    {
        private readonly IAdminRepo adminRepo;
        public AdminManager(IAdminRepo adminRepo)
        {
            this.adminRepo = adminRepo;
        }
        public async Task<string> AddAdmin(AdminLoginModel adminLoginModel)
        {
            try
            {
                await this.adminRepo.AddAdmin(adminLoginModel);
                return "Registration Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string LogInAdmin(string Email, string Password)
        {
            bool result = adminRepo.LogInAdmin(Email, Password);
            if (result)
            {
                return "Log In successfully";
            }
            else
            {
                return "Email /Password incorrect ";
            }
        }

        public async Task<List<AdminModel>> DisplayUserStatistics()
        {
            return await adminRepo.DisplayUserDetails();
        }
         public async Task<List<UserModel>> DisplayUserDetails()
        {
            return await adminRepo.DisplayUsers();
        }





        //public async Task<string> AdminLogin(AdminLoginModel adminLoginModel)
        //{
        //    try
        //    {
        //        var Token = await adminRepo.AdminLogin(adminLoginModel);
        //        return Token;
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}
        //public async Task<AdminLoginModel> FindByEmail(string email)
        //{
        //    var result = await adminRepo.FindByEmail(email);
        //    return result;
        //}
    }
}
