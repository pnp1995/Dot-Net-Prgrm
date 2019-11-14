// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.AdminModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// AdminModel is a class
    /// </summary>
    public class AdminModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The logintime
        /// </summary>
        private string logintime;
        /// <summary>
        /// The cardtype
        /// </summary>
        private string cardtype;
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [ForeignKey("UserModel")]
          public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        /// <summary>
        /// Gets or sets the login time.
        /// </summary>
        /// <value>
        /// The login time.
        /// </value>
        public string LoginTime
        {
            set { this.logintime = value; }
            get { return this.logintime; }
        }
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
    }
}
