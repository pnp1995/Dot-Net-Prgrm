// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace Common.Models
{
    public class UserModel
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;
        /// <summary>
        /// The cardtype
        /// </summary>
        private string cardtype;
        /// <summary>
        /// The profilepicupload
        /// </summary>
        private string profilepicupload;
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the emailid.
        /// </summary>
        /// <value>
        /// The emailid.
        /// </value>
        [Key]
        public string Emailid { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [DataType(DataType.Password)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the type of the card.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public string CardType
        {
            set { this.cardtype = value; }
            get { return this.cardtype; }
        }
        /// <summary>
        /// Gets or sets the profile pic upload.
        /// </summary>
        /// <value>
        /// The profile pic upload.
        /// </value>
        public string ProfilePicUpload
        {
            set { this.profilepicupload = value; }
            get { return this.profilepicupload; }
        }

    }
}
