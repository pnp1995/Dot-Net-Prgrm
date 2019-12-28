// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.CollaboratorModel;
using Common.LabelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Common.NotesModel
{
    public class NotesViewModel
    {
        /// <summary>
        /// The email/
        /// </summary>
        private string email;
        /// <summary>
        /// The identifier/
        /// </summary>
        private int id;
        /// <summary>
        /// The title
        /// </summary>
        private string title;
        /// <summary>
        /// The descriiption
        /// </summary>
        private string descriiption;
        /// <summary>
        /// The image
        /// </summary>
        private string image;
        /// <summary>
        /// The reminder/
        /// </summary>
        private string reminder;
        /// <summary>
        /// The colour/
        /// </summary>
        private string colour;
        /// <summary>
        /// The archive/
        /// </summary>
        private bool archive;
        /// <summary>
        /// The trash
        /// </summary>
        private bool trash;
        /// <summary>
        /// The pin
        /// </summary>
        private bool pin;
        /// <summary>
        /// The created date
        /// </summary>
        private DateTime? createdDate;
        /// <summary>
        /// The modified date
        /// </summary>
        private DateTime? modifiedDate;

        private List<LabelModels> labels;
        private List<CollaboratorModels> collaborators;
        private int count;
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

        public int Count
        {
            set { this.count = value; }
            get { return this.count; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            set { this.title = value; }
            get { return this.title; }
        }
        /// <summary>
        /// Gets or sets the descriiption.
        /// </summary>
        /// <value>
        /// The descriiption.
        /// </value>
        public string Descriiption
        {
            set { this.descriiption = value; }
            get { return this.descriiption; }
        }
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public string Image
        {
            set { this.image = value; }
            get { return this.image; }
        }
        /// <summary>
        /// Gets or sets the reminder.
        /// </summary>
        /// <value>
        /// The reminder.
        /// </value>
        public string Reminder
        {
            set { this.reminder = value; }
            get { return this.reminder; }
        }
        /// <summary>
        /// Gets or sets the colour.
        /// </summary>
        /// <value>
        /// The colour.
        /// </value>
        public string Colour
        {
            set { this.colour = value; }
            get { return this.colour; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NotesModel"/> is archive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if archive; otherwise, <c>false</c>.
        /// </value>
        public bool Archive
        {
            set { this.archive = value; }
            get { return this.archive; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NotesModel"/> is trash.
        /// </summary>
        /// <value>
        ///   <c>true</c> if trash; otherwise, <c>false</c>.
        /// </value>
        public bool Trash
        {
            set { this.trash = value; }
            get { return this.trash; }

        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NotesModel"/> is pin.
        /// </summary>
        /// <value>
        ///   <c>true</c> if pin; otherwise, <c>false</c>.
        /// </value>
        public bool Pin
        {
            set { this.pin = value; }
            get { return this.pin; }

        }
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime? CreatedDate
        {
            set { this.createdDate = value; }
            get { return this.createdDate; }
        }
        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime? ModifiedDate
        {
            set { this.modifiedDate = value; }
            get { return this.modifiedDate; }

        }


        public List<LabelModels> Labels
        {
            get
            {
                return labels;
            }
            set
            {
                labels = value;
            }
        }

        /// <summary>
        /// public member Position
        /// </summary>
        public List<CollaboratorModels> Collaborators
        {
            get
            {
                return collaborators;
            }
            set
            {
                collaborators = value;
            }
        }
    }

}

