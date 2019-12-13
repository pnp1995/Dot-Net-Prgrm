using Common.UserModel;
using FundooManager.Interface;
using FundooRepository.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace fundoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // AccountRepository accountRepository = new AccountRepository();
        private readonly IAccount accountmanager;
        public AccountController(IAccount manager)
        {
            this.accountmanager = manager;
        }
        [HttpPost]
        [Route("Account")]
        public async Task<IActionResult> Registration(UserModel userModel)
        {
            try
            {
                var result = await accountmanager.RegistrationAsync(userModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
       
    }
}