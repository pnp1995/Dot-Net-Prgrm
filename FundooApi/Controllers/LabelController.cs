// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.LabelModel;
using FundooManager.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> Addlabel(LabelModel labelModel)
        {
            try
            {
                var result = await label.Add(labelModel);
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
        public async Task<IActionResult> Delete(LabelModel labelModel)
        {
            try
            {
                var result = await label.Update(labelModel);
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
        [HttpPut]
        [Route("delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var result = await label.Delete(Id);
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
        [Route("get")]
        public List <LabelModel>List(string Email)
        {                      
            var result =  label.List(Email);       
            return result;
            
        }
       
    }
}