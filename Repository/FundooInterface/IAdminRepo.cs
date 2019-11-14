using Common.AdminModel;
using Common.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.FundooInterface
{
    public interface IAdminRepo
    {
        Task AddAdmin(AdminLoginModel adminLoginModel);
        Task AdminLogin(UserModel user,DateTime date);
        Task<IdentityUser> FindByEmailAsync(string email);
    }
}
