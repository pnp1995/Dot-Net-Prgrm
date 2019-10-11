// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EagerInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.SingletonPattern
{
    /// <summary>
    /// /
    /// </summary>
    public sealed class EagerInitialization
    {
        private static int counter = 0;
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static EagerInitialization GetInstance { get; } = new EagerInitialization();
        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization()
        {
            counter++;
            Console.WriteLine("Counter value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
        Console.WriteLine(message);
        }
    }
}
