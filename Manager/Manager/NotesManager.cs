using Common.NotesModel;
using FundooManager.Interface;
using FundooRepository.FundooInterface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public  class NotesManager : INotes
    {
        private readonly INotesRepo notesRepo;
        public NotesManager(INotesRepo notesRepo)
        {
            this.notesRepo = notesRepo;
        }
        public async Task<string> Add(NotesModel notesModel,string email)
        {
            try
            {
                await this.notesRepo.AddNotes(notesModel,email);
                return "Added Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> Update(NotesModel notesModel, string email)
        {
            try
            {
                await this.notesRepo.UpdateNotes(notesModel, email);
                return "Update Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
           
            }        
        }
        public async Task<string> Delete(int Id,string Email)
        {
            try
            {
                await this.notesRepo.DeleteNotes(Id, Email);
                return "Delete Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public List<NotesModel> List(string Email)
        {
            try
            {
                var result= this.notesRepo.List(Email);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public async Task<string> Archive(int Id)
        {
            try
            {
                await this.notesRepo.Archive(Id);
                return "Archive Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }                 
        }
        public async Task<string> UnArchive(int Id)
        {
            try
            {
                await notesRepo.UnArchive(Id);
                return "UnArchive Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<NotesModel>ArchiveList(string Email)
        {
            var result = notesRepo.ArchiveList(Email);
            return result;
        }
        public async Task<string> Pin(int Id)
        {
            try
            {
                await notesRepo.Pin(Id);
                return "Pin Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> UnPin(int Id)
        {
            try
            {
                await notesRepo.UnPin(Id);
                return "UnPin Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> Trash(int Id)
        {
            try
            {
                await notesRepo.Trash(Id);
                return "Trash Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<NotesModel> TrashList(string Email)
        {
            var result = notesRepo.TrashList(Email);
            return result;
        }
        public async Task<string> Restore(int Id)
        {
            try
            {
                await notesRepo.Restore(Id);
                return "Restore Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> RestoreAll(string Email)
        {
            try
            {
                await notesRepo.RestoreAll(Email);
                return "RestoreAll Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> Reminder(int Id ,string Reminder)
        {
            try
            {
                await notesRepo.Reminder(Id, Reminder);
                return "Reminder ADDED Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> Colour(int Id, string Colour)
        {
            try
            {
                await notesRepo.Reminder(Id, Colour);
                return "Colour ADDED Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string ImageUpload(int Id, IFormFile formFile)
        {
            try
            {
                notesRepo.ImageUpload(Id, formFile);
                return "Image upload Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
