// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ThreadSafeSingleton.cs" company="Bridgelabz">
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
    /// /  i have create a ThreadSafeSingleton Class
    /// </summary>
    /// sealed restrict the inheritance.

    public sealed  class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        private static ThreadSafeSingleton instance = null;
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
       //// public property is used to return only one instance of the class.
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                if(instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                         instance = new ThreadSafeSingleton();
                    }
                 }
                return instance;
            }
        }
        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        /// / Private constructor ensure that object is not
        private ThreadSafeSingleton()
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
