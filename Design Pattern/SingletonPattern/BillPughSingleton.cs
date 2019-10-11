// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BillPughSinglton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.SingletonPattern
{
    class BillPughSingleton
    {
        private static int counter = 0;

       // private static readonly Bill<BillPughSingleton> instance = new Bill<BillPughSingleton>(() => new BillPughSingleton());
        public static BillPughSingleton GetInstance { get; } = new BillPughSingleton();
        //public static BillPughSingleton GetInstance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}
        /// <summary>
        /// Prevents a default instance of the <see cref=" BillPughSingleton"/> class from being created.
        /// </summary>
        private BillPughSingleton()
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
