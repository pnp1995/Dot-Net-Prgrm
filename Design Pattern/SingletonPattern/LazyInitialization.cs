// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LaztInitialization.cs" company="Bridgelabz">
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
    /// LazyInitialize a class.
    /// </summary>
    class LazyInitialization
    {
        private static int counter = 0;
        private static readonly Lazy<LazyInitialization> instance = new Lazy<LazyInitialization>(() => new LazyInitialization());
        public static LazyInitialization GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
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
