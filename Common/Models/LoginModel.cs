// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LoginModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.Models
{
    public class LoginModel
    {
        /// <summary>
        /// The emailid
        /// </summary>
        private string emailid;
        /// <summary>
        /// The password
        /// </summary>
        private string password;
        /// <summary>
        /// Gets or sets the emailid.
        /// </summary>
        /// <value>
        /// The emailid.
        /// </value>
        public string Emailid
        {
            set { this.emailid = value; }
            get { return this.emailid; }
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
