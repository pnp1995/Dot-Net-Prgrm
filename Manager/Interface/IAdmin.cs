using Common.AdminModel;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
   public interface IAdmin
    {
        Task<string> AddAdmin(AdminLoginModel adminLoginModel);
        Task<List<AdminModel>> DisplayUserStatistics();
        Task<List<UserModel>> DisplayUserDetails();
        //Task<string> AdminLogin(AdminLoginModel adminLoginModel);
    }
}
