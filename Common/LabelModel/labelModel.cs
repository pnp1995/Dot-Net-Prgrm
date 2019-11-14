﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=labelModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations.Schema;
namespace Common.LabelModel
{
    public class LabelModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The label
        /// </summary>
        private string label;
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
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label
        {
            set { this.label = value; }
            get { return this.label; }
        }
   }
}
