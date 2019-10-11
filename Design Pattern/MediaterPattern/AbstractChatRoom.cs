// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AbstractChatRoom.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.MediaterPattern
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class AbstractChatRoom
    {
        /// <summary>
        /// Registers the specified participant.
        /// </summary>
        /// <param name="participant">The participant.</param>
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }
}
