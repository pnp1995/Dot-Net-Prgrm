// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.LabelModel;
using FundooManager.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabel label;
        public LabelController(ILabel label)
        {
            this.label = label;
        }
        /// <summary>
        /// Addlabels the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        [Authorize]
        public async Task<IActionResult> Addlabel(LabelModel labelModel)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;
                var result = await label.Add(labelModel,Email);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Deletes the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        [Authorize]
        public async Task<IActionResult> Delete(LabelModel labelModel)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;
                var result = await label.Update(labelModel,Email);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("delete")]
        [Authorize]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;
                var result = await label.Delete(Id,Email);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Lists the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        [Authorize]
        public List <LabelModel>List()
        {
            string Email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;

            var result =  label.List(Email);       
            return result;
            
        }
       
    }
}