using Common.AdminModel;
using Common.CollaboratorModel;
using Common.LabelModel;
using Common.Models;
using Common.NotesModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FundooRepository.Context
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        { }
        public DbSet<UserModel> UserDetail { get; set; }
        public DbSet<NotesModel> NotesDetail { get; set; }       
        public DbSet<LabelModel> LabelDetail { get; set; }
        public DbSet<CollaboratorModel> CollaboratorDetail { get; set; }
        public DbSet<AdminModel> AdminDetail { get; set; }
        public DbSet<AdminLoginModel> AdminloginDetail { get; set; }
    }
}  