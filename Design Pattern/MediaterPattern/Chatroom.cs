// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Chatroom.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
namespace Design_Pattern.MediaterPattern
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    /// <seealso cref="Design_Pattern.MediaterPattern.AbstractChatRoom" />
    public class Chatroom : AbstractChatRoom
   {
      private Dictionary<string, Participant> participants = new Dictionary<string,Participant>();
 
     public override void Register(Participant participant)
     {
       if (!participants.ContainsValue(participant))
       {
          participants[participant.Name] = participant;
       }
        participant.Chatroom = this;
     }
        /// <summary>
        /// Sends the specified from.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="message">The message.</param>
        public override void Send(
       string from, string to, string message)
       {
         Participant participant = participants[to];
 
         if (participant != null)
         {
           participant.Receive(from, message);
         }
       }
   }
}