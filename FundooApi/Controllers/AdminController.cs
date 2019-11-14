// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.AdminModel;
using FundooManager.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdmin admin;
        public AdminController(IAdmin admin)
        {
            this.admin = admin;
        }
        /// <summary>
        /// Adds the admin.
        /// </summary>
        /// <param name="adminLoginModel">The admin login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddAdmin(AdminLoginModel adminLoginModel)
        {
            try
            {
                var result = await admin.AddAdmin(adminLoginModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        //[HttpPost]
        //[Route("adminlogin")]
        //public async Task<IActionResult> AdminLogin(AdminLoginModel adminLoginModel)
        //{
        //    try
        //    {
        //        var result = await admin.AdminLogin(adminLoginModel);
        //        return this.Ok(new { result });
        //    }
        //    catch (Exception ex)
        //    {
        //        return this.BadRequest(ex.Message);
        //    }
        //}
    }
}