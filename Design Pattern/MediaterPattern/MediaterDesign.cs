// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MediaterDesign.cs" company="Bridgelabz">
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
    /// MainApp startup class for Real-World 
    /// Mediator Design Pattern.
    /// </summary>
    class MediaterDesign
    {
        /// <summary>
        /// Patterns this instance.
        /// </summary>
        public static void Pattern()
        {
            // Create chatroom

            Chatroom chatroom = new Chatroom();

            // Create participants and register them

            Participant Ram = new ColleagueA("Ram");
            Participant Mohan = new ColleagueA("Mohan");
            Participant Rina = new ColleagueA("Rina");
            Participant John = new ColleagueA("John");
            Participant Pnp = new ColleagueB("Pnp");

            chatroom.Register(Ram);
            chatroom.Register(Mohan);
            chatroom.Register(Rina);
            chatroom.Register(John);
            chatroom.Register(Pnp);

            // Chatting participants
            Pnp.Send("John", "Hi John!");
            Mohan.Send("Rina", "How are you.");
            Rina.Send("Mohan", "My sweet Lord");
            Ram.Send("John", "Can't buy me love");
            John.Send("Pnp", "My sweet love");

            // Wait for user
            Console.ReadKey();
        }
    }
}
