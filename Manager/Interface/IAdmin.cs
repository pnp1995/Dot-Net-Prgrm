using Common.AdminModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
   public interface IAdmin
    {
        Task<string> AddAdmin(AdminLoginModel adminLoginModel);
        //Task<string> AdminLogin(AdminLoginModel adminLoginModel);
    }
}
