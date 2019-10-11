// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ColleagueA.cs" company="Bridgelabz">
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
    /// B 'ConcreteColleague' class
    /// </summary>
    /// <seealso cref="Design_Pattern.MediaterPattern.Participant" />
    class ColleagueB : Participant
    {
        // Constructor
        public ColleagueB(string name) : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a ColleagueB: ");
            base.Receive(from, message);
        }
    }
}