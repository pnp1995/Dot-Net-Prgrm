// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.CollaboratorModel;
using FundooManager.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorController : ControllerBase
    {
        /// <summary>
        /// The collaborator
        /// </summary>
        private readonly ICollaborator collaborator ;
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorController"/> class.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        public CollaboratorController(ICollaborator collaborator)
        {
            this.collaborator = collaborator;
        }
        /// <summary>
        /// Adds the specified collaborator model.
        /// </summary>
        /// <param name="collaboratorModel">The collaborator model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(CollaboratorModel collaboratorModel)
        {
            try
            {
                var result = await collaborator.AddCollaborator(collaboratorModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Updates the specified collaborator model.
        /// </summary>
        /// <param name="collaboratorModel">The collaborator model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(CollaboratorModel collaboratorModel)
        {
            try
            {
                var result = await collaborator.UpdateCollaborator(collaboratorModel);
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
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var result = await collaborator.DeleteCollaborator(Id);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Lists the specified noteid.
        /// </summary>
        /// <param name="Noteid">The noteid.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public  List<CollaboratorModel> List(int Noteid)
        {
           var result =  collaborator.List(Noteid);
            return result;
        }
    }
}