// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.AdminModel
{
    using System.ComponentModel.DataAnnotations;
    /// <summary>
    /// AdminLoginModel is a class
    /// </summary>
    public class AdminLoginModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The firstname
        /// </summary>
        private string firstname;
        /// <summary>
        /// The lastname
        /// </summary>
        private string lastname;
        /// <summary>
        /// The password/
        /// </summary>
        private string password;
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
       [Key]
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            set { this.firstname = value; }
            get { return this.firstname; }
        }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            set { this.lastname = value; }
            get { return this.lastname; }
        }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}
