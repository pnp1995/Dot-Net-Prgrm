// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ColleagueB.cs" company="Bridgelabz">
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
    /// A 'ConcreteColleague' class
    /// </summary>
    /// <seealso cref="Design_Pattern.MediaterPattern.Participant" />
    class ColleagueA : Participant
    {
        // Constructor
        public ColleagueA(string name) : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a ColleagueA: ");
            base.Receive(from, message);
        }
    }
}
