using Common.AdminModel;
using Common.CollaboratorModel;
using Common.LabelModel;
using Common.Models;
using Common.NotesModel;
using Microsoft.EntityFrameworkCore;

namespace FundooRepository.Context
{
    public class UserContext: DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        { }
        /// <summary>
        /// Gets or sets the user detail.
        /// </summary>
        /// <value>
        /// The user detail.
        /// </value>
        public DbSet<UserModel> UserDetail { get; set; }
        /// <summary>
        /// Gets or sets the notes detail.
        /// </summary>
        /// <value>
        /// The notes detail.
        /// </value>
        public DbSet<NotesModel> NotesDetail { get; set; }
        /// <summary>
        /// Gets or sets the label detail.
        /// </summary>
        /// <value>
        /// The label detail.
        /// </value>
        public DbSet<LabelModel> LabelDetail { get; set; }
        /// <summary>
        /// Gets or sets the collaborator detail.
        /// </summary>
        /// <value>
        /// The collaborator detail.
        /// </value>
        public DbSet<CollaboratorModel> CollaboratorDetail { get; set; }
        /// <summary>
        /// Gets or sets the admin detail.
        /// </summary>
        /// <value>
        /// The admin detail.
        /// </value>
        public DbSet<AdminModel> AdminDetail { get; set; }
        /// <summary>
        /// Gets or sets the adminlogin detail.
        /// </summary>
        /// <value>
        /// The adminlogin detail.
        /// </value>
        public DbSet<AdminLoginModel> AdminloginDetail { get; set; }
    }
}  