using CloudinaryDotNet.Actions;
using Common.NotesModel;
using FundooRepository.Context;
using FundooRepository.FundooInterface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using System.IO;

namespace FundooRepository.Repository
{
    public class NotesRepository : INotesRepo
    {
        private readonly UserContext userContext;
        public NotesRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public Task AddNotes(NotesModel notesModel,string email)
        {
            var result = userContext.UserDetail.Where(p => p.Emailid == email).FirstOrDefault();
            if (result != null)
            {
                notesModel.Email = email;

                NotesModel notesModel1 = new NotesModel()
                {
                    Email = notesModel.Email,
                    Id = notesModel.Id,
                    Title = notesModel.Title,
                    Descriiption = notesModel.Descriiption,
                    Image = notesModel.Image,
                    Reminder = notesModel.Reminder,
                    Colour = notesModel.Colour,
                    Archive = notesModel.Archive,
                    Trash = notesModel.Trash,
                    Pin = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                };
                userContext.NotesDetail.Add(notesModel);
                userContext.SaveChanges();
                result.TotalNotes++;
                }
                return Task.Run(() => true);
        }
        public Task UpdateNotes(NotesModel notesModel, string email)
            {
            notesModel.Email = email;
            // NotesModel notesModel1 = new NotesModel();
            NotesModel note = userContext.NotesDetail.Where(p => p.Id == notesModel.Id).FirstOrDefault();
            if (note != null)
            {
                note.Email = notesModel.Email;
                note.Title = notesModel.Title;
                note.Descriiption = notesModel.Descriiption;
                note.Colour = notesModel.Colour;
                note.Archive = notesModel.Archive;
                note.Reminder = notesModel.Reminder;
                note.ModifiedDate = DateTime.Now;
                userContext.NotesDetail.Update(note);
            }
            return Task.Run(() => userContext.SaveChanges());
        }
        public Task DeleteNotes(int Id, string Email)
        {
            var result = userContext.NotesDetail.Where(i => i.Email == Email);
            if (result != null)
            {
                NotesModel note = userContext.NotesDetail.Where(p => p.Id == Id).FirstOrDefault();
                if (note != null)
                {
                    userContext.NotesDetail.Remove(note);
                }
                return Task.Run(() => userContext.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        public List<NotesModel> List(string Email)
        {
            bool note = userContext.NotesDetail.Any(p => p.Email == Email);
            if (note)
            {
                return userContext.NotesDetail.Where(p => p.Email == Email & p.Archive!=true & p.Trash!=true).ToList();
            }
            else
            {
                return null;
            }
        }
        public Task Archive(int Id)
        {
            NotesModel result = userContext.NotesDetail.Where(p => p.Id == Id).SingleOrDefault();
            // var result = await this.Archive(notesmodel);
            if (result != null)
            {
                result.Archive = true;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }
        public Task UnArchive(int Id)
        {
            NotesModel note = userContext.NotesDetail.Where(i => i.Id == Id).SingleOrDefault();
            if (note != null)
            {
                note.Archive = false;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }
        public List<NotesModel> ArchiveList(string Email)
        {
            var result = userContext.NotesDetail.Any(p => p.Email == Email && p.Archive == true);
            if (result)
            {
                return userContext.NotesDetail.Where(p => p.Email == Email && p.Archive == true).ToList();
            }
            else
            {
                return null;
            }
        }
        public Task Pin(int Id)
        {
            var result = userContext.NotesDetail.Where(i => i.Id == Id).FirstOrDefault();
            if (result != null)
            {
                result.Pin = true;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }
        public Task UnPin(int Id)
        {
            var result = userContext.NotesDetail.Where(i => i.Id == Id).SingleOrDefault();
            if (result != null)
            {
                result.Pin = false;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }
        public Task Trash(int Id)
        {
            var result = userContext.NotesDetail.Where(i => i.Id == Id).SingleOrDefault();
            if (result != null)
            {
                result.Trash = true;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }
        public List<NotesModel> TrashList(string Email)
        {
            var result = userContext.NotesDetail.Any(p => p.Email == Email && p.Trash == true);
            if (result)
            {
                return userContext.NotesDetail.Where(p => p.Email == Email && p.Trash == true).ToList();
            }
            else
            {
                return null;
            }
        }
        public Task Restore(int Id)
        {
            var result = userContext.NotesDetail.Where(i => i.Id == Id).SingleOrDefault();
            if (result != null)
            {
                result.Trash = false;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }
        public Task RestoreAll(string Email)
        {
            var result = userContext.NotesDetail.Where(i => i.Email == Email && i.Trash == true).ToList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    item.Trash = false;
                }
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }
        public Task Reminder(int Id, string Reminder)
        {
            var result = userContext.NotesDetail.Where(i => i.Id == Id).SingleOrDefault();
            if (result != null)
            {

                result.Reminder = Reminder;
               //userContext.NotesDetail.Update(result);

                return Task.Run(() => userContext.SaveChanges());

            }
            return null;
        }
        public Task Colour(int Id, string Colour, string Email)
       {
            var result = userContext.NotesDetail.Where(i => i.Id == Id).SingleOrDefault();
            if (result != null)
            {
                result.Colour = Colour;
                return Task.Run(() => userContext.SaveChanges());

            }
            return null;
        }
        public string ImageUpload(int Id, IFormFile formFile)
        {
            var path = formFile.OpenReadStream();
            var fileName = formFile.FileName;
            CloudinaryDotNet.Account cloudinary = new CloudinaryDotNet.Account("dtddmoers", "745684864855497", "b4WAINSfnC1hJPAyikC525T3HUM");
            CloudinaryDotNet.Cloudinary cloud = new CloudinaryDotNet.Cloudinary(cloudinary);
            var Uploadfile = new ImageUploadParams()
            {
                File = new FileDescription(fileName, path)
            };
            var data = cloud.Upload(Uploadfile);
            var result = userContext.NotesDetail.Where(i => i.Id == Id).SingleOrDefault();
            result.Image = data.Uri.ToString();
            userContext.SaveChanges();
            return result.Image;
        }

        public List<NotesModel> Search(string Email, string letters)
        {
            var email = userContext.NotesDetail.Where(p => p.Email == Email).FirstOrDefault();
            if (email != null)
            {
                return userContext.NotesDetail.Where(p => (p.Email == Email) && (p.Title.Contains(letters))).ToList();/* (p.Archive == true) && (p.Trash == false) && */
            }
            return null;
        }
    }
}

