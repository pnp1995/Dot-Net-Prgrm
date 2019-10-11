// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Participent.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
namespace Design_Pattern.MediaterPattern
{
    /// <summary>
    /// Participent is a class
    /// </summary>
    public class Participant
    {
        private Chatroom chatroom;
        private string name;

        // Constructor
        public Participant(string name)
        {
            this.name = name;
        }

        // Gets participant name        
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return name; }
        }

        // Gets chatroom
        public Chatroom Chatroom
        {
            set { chatroom = value; }
            get { return chatroom; }
        }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive( string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
