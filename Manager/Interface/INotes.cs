using Common.NotesModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public interface INotes
    {
        Task<string> Add(NotesModel notesModel,string email);
        Task<string> Update(NotesModel notesModel, string email);
        Task<string> Delete(int Id,string Email);
        List<NotesModel> List(string Email);
        Task<string> Archive(int Id);
        Task<string> UnArchive(int Id);
        List<NotesModel> ArchiveList(string Email);
        Task<string> Pin(int Id);
        Task<string> UnPin(int Id);
        Task<string> Trash(int Id);
        List<NotesModel> TrashList(string Email);
        Task<string> Restore(int Id);
        Task<string> RestoreAll(string Email);
        Task<string> Reminder(int Id, string Reminder);
        Task<string> Colour(int Id, string Colour);
        string ImageUpload(int Id, IFormFile formFile);
    }
}
