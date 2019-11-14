// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.NotesModel;
using FundooManager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotesController : ControllerBase
    {
        /// <summary>
        /// The notes
        /// </summary>
        private readonly INotes notes;
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        /// <param name="notes">The notes.</param>
        public NotesController(INotes notes) 
        {
            this.notes = notes;
        }
        /// <summary>
        /// Adds the specified notes model.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(NotesModel notesModel)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Emailid").Value;
                var result = await notes.Add(notesModel, Email);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Updates the specified notes model.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(NotesModel notesModel)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Emailid").Value;
                var result = await notes.Update(notesModel, Email);
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
                string Email = User.Claims.First(c => c.Type == "Emailid").Value;
                var result = await notes.Delete(Id, Email);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public List<NotesModel> List()
        {
            string Email = User.Claims.First(c => c.Type == "Emailid").Value;

            var result = this.notes.List(Email);
                return result;
            
        }
        /// <summary>
        /// Archives the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("archive")]
        public async Task <IActionResult> Archive(int Id)
        {
            try
            {
                var result = await notes.Archive(Id);
                return this.Ok(new { result });
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unarchive")]
        public async Task<IActionResult> UnArchive(int Id)
        {
            try
            {
                var result = await notes.UnArchive(Id);
                return Ok(new { result });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Archives the list.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("archivelist")]
        public List<NotesModel> ArchiveList(string Email)
        {
            {
                var result = this.notes.ArchiveList(Email);
                return result;
            }
        }
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("pin")]
        public async Task<IActionResult> Pin(int Id)
        {
            try
            {
                var result = await notes.Pin(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("unpin")]
        public async Task<IActionResult> UnPin(int Id)
        {
            try
            {
                var result = await notes.UnPin(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("trash")]
        public async Task<IActionResult> Trash(int Id)
        {
            try
            {
                var result = await notes.Trash(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Trashes the list.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("trashlist")]
        public List<NotesModel> TrashList(string Email)
        {
            {
                var result = this.notes.TrashList(Email);
                return result;
            }
        }
        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("restore")]
        public async Task<IActionResult> Restore(int Id)
        {
            try
            {
                var result = await notes.Restore(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Restores all.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("restoreall")]
        public async Task<IActionResult> RestoreAll(string Email)
        {
            try
            {
                var result = await notes.RestoreAll(Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Reminders the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Reminder">The reminder.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("reminder")]
        public async Task<IActionResult> Reminder(int Id,string Reminder)
        {
            try
            {
                var result = await notes.Reminder(Id, Reminder);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Colours the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Colour">The colour.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("colour")]
        public async Task<IActionResult> Colour(int Id, string Colour)
        {
            try
            {
                var result = await notes.Colour(Id, Colour);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Images the upload.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="formFile">The form file.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("imageupload")]
        public IActionResult ImageUpload(int Id, IFormFile formFile)
        {
            try
            {
                var result =  notes.ImageUpload(Id, formFile);
                return Ok(new { result });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}