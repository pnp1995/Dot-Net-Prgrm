// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.CollaboratorModel
{
    /// <summary>
    /// CollaboratorModel is class
    /// </summary>
    public class CollaboratorModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The senderemail
        /// </summary>
        private string senderemail;
        /// <summary>
        /// The noteid
        /// </summary>
        private int noteid;
        /// <summary>
        /// The receiveremail
        /// </summary>
        private string receiveremail;
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        /// <summary>
        /// Gets or sets the sender email.
        /// </summary>
        /// <value>
        /// The sender email.
        /// </value>
        [ForeignKey("UserModel")]
        [EmailAddress]
        public string SenderEmail
        {
            set { this.senderemail = value; }
            get { return this.senderemail; }
        }
        /// <summary>
        /// Gets or sets the noteid.
        /// </summary>
        /// <value>
        /// The noteid.
        /// </value>
        [ForeignKey("NotesModel")]
        public int Noteid
        {
            set { this.noteid = value; }
            get { return this.noteid; }
        }
        /// <summary>
        /// Gets or sets the receiver email.
        /// </summary>
        /// <value>
        /// The receiver email.
        /// </value>
        [ForeignKey("UserModel")]
        [EmailAddress]
        public string ReceiverEmail
        {
            set { this.receiveremail = value; }
            get { return this.receiveremail; }
        }
    }
}
