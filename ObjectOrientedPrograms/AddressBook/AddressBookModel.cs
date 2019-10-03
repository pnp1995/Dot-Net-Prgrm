// --------------------------------------------------------------------------------------------------------------------
// <copyright file= AddressBook.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    class AddressBookModel
    {
        private string name;
        private long phonenumber;
        private string city;
        private string state;
        private long zip;
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
    }
}
