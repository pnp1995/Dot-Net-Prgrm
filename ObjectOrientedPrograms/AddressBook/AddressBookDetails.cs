// --------------------------------------------------------------------------------------------------------------------
// <copyright file= AddressBook.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using DocumentFormat.OpenXml.Drawing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
   public class AddressBookDetails:IAddressBookDetails
    { 
        public void Operation(string book)
        {
            string message = null;
            AddressBookModel addressBookModel = new AddressBookModel();
            try
            {
                 StreamReader read = new StreamReader(book);
                var json = read.ReadToEnd();
                AddressBookModel[] data = JsonConvert.DeserializeObject<AddressBookModel[]>(json);
                for(int i = 0; i<data.Length;i++)
                {
                    Console.WriteLine("Number" + i);
                    Console.WriteLine("name is: " + data[i].Name);
                    Console.WriteLine("Phone number is: " + data[i].PhoneNumber);
                    Console.WriteLine("City is : " + data[i].City);
                    Console.WriteLine("State is: " + data[i].State);
                    Console.WriteLine("Zip is: " + data[i].Zip);
                }
                Console.WriteLine("Enter the name you want to update");
                string name = Console.ReadLine();
                for (int i = 0; i < data.Length;i++)
                {
                    if(name == data[i].Name)
                    {
                        Console.WriteLine("Enter to change phone number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("name is: " + data[i].Name);
                        Console.WriteLine("Phone number is: " + data[i].PhoneNumber);
                        Console.WriteLine("City is : " + data[i].City);
                        Console.WriteLine("State is: " + data[i].State);
                        Console.WriteLine("Zip is: " + data[i].Zip);
                    }
                    else
                    {
                        message = ("you cannot update");
                    }
                }
                Console.WriteLine(message);
                Console.WriteLine("do you wanty to continue (y/n)");
                string repeat = Console.ReadLine();
                if (repeat == "y" || repeat == "Y")
                {
                    AddressBookDetails addressBook = new AddressBookDetails();
                    addressBook.Operation(book);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Adds the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        public void Add(string book)
        {
            AddressBookModel addressBookModel = new AddressBookModel();
            try
            {
                StreamReader read = new StreamReader(book);
                var json = read.ReadToEnd();
                AddressBookModel[] data = JsonConvert.DeserializeObject<AddressBookModel[]>(json);
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine("Number" + i);
                    Console.WriteLine("name is: " + data[i].Name);
                    Console.WriteLine("Phone number is: " + data[i].PhoneNumber);
                    Console.WriteLine("City is : " + data[i].City);
                    Console.WriteLine("State is: " + data[i].State);
                    Console.WriteLine("Zip is: " + data[i].Zip);
                }
                Array.Resize(ref data, data.Length + 1);
                Console.WriteLine("enter the name to add");
                string aName = Console.ReadLine();
                for(int i = 0; i< data.Length; i++)
                {
                    if(data[i]== null)
                    {
                        Console.WriteLine("enter details 1.name  2.phonenumber  3.city  4.state  5.zip");
                        string name = Console.ReadLine();
                        long number = Convert.ToInt32(Console.ReadLine());
                        string city = Console.ReadLine();
                        string state = Console.ReadLine();
                        long pin = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Number" + i);
                        Console.WriteLine("name is: " + data[i].Name);
                        Console.WriteLine("Phone number is: " + data[i].PhoneNumber);
                        Console.WriteLine("City is : " + data[i].City);
                        Console.WriteLine("State is: " + data[i].State);
                        Console.WriteLine("Zip is: " + data[i].Zip);
                    }
                    try
                    {
                        string path = JsonConvert.SerializeObject(book);
                        File.WriteAllText(@"C:\Users\admin\Desktop\BasicProgram\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook\jsonBook.json",path);
                        Console.WriteLine("Added");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Opertaion(string book)
        {
            throw new NotImplementedException();
        }
    }
}
