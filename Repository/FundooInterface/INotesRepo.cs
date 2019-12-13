using Common.NotesModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.FundooInterface
{
    public interface INotesRepo
    {
        Task AddNotes(NotesModel notesModel,string email);
        Task UpdateNotes(NotesModel notesModel, string email);
        Task DeleteNotes(int Id ,string Email);
        List<NotesModel> List(string Email);
        Task Archive(int Id);
        Task UnArchive(int Id);
        List<NotesModel> ArchiveList(string Email);
        Task Pin(int Id);
        Task UnPin(int Id);
        Task Trash(int Id);
        List<NotesModel> TrashList(string Email);
        Task Restore(int Id);
        Task RestoreAll(string Email);
        Task Reminder(int Id, string Reminder);
        Task Colour(int Id, string Colour, string Email);
        string ImageUpload(int Id, IFormFile formFile);
        List<NotesModel> Search(string Email, string letters);
    }
}
