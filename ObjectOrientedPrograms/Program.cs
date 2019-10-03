// --------------------------------------------------------------------------------------------------------------------
// <copyright file= Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using ObjectOrientedPrograms.InventaryPrgm;
using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                do
                {
                    Console.WriteLine("*** Object Oriented Programs***");
                    Console.WriteLine();
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine("1.InventaryDataMangement\n2.RegularExpression\n3.StockReport\n4.InventaryPrgm\n5.Commercial Data");
                    Console.WriteLine("6.Deck Of Card\n7.DeckOfCardQueue\n8.AddressBook");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                    case 1:
                        InventaryDataMangement.InventaryData inventaryData = new InventaryDataMangement.InventaryData();
                        inventaryData.DisplayData();
                        break;
                        case 2:
                            RegularExpression.RegularExp regularExp = new RegularExpression.RegularExp();
                            regularExp.RegexExp();
                            break;
                        case 3:
                            StockReport.StockMain stock = new StockReport.StockMain();
                            stock.Report();
                            break;
                        case 4:
                            InventaryPrgm.InventaryOption option = new InventaryPrgm.InventaryOption();
                            option.InventaryManagementMethod();
                            break;
                        case 5:
                            CommercialData.UserInput accountOpeartion = new CommercialData.UserInput();
                            accountOpeartion.Input();
                            break;
                        case 6:
                            DeckOfCards.DackofCard card = new DeckOfCards.DackofCard();
                            card.InitializeDeckofCard();
                            break;
                        case 7:
                            DeckofCardQueue.DeckofCardqueue cardqueue = new DeckofCardQueue.DeckofCardqueue();
                            cardqueue.InitializeDeckofCard();
                            break;
                        case 8:
                            AddressBook.AddressBookDetails bookDetails = new AddressBook.AddressBookDetails();
                            string path = @"C:\Users\admin\Desktop\BasicProgram\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook\jsonBook.json";
                            bookDetails.Add(path);
                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to continue then press y");
                   choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
