using Intuit.Ipp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialData
{
    class AccountOpeartion
    {
        public void DisplayStock()
        {
            NewAccount newAccount = JsonOperation.JsonReadFile();
            List<AccountModel> accountModels = newAccount.AccountList;
            double sum = 0;
            foreach (var account in accountModels)
            {
                Console.WriteLine("");
                Console.WriteLine("Account Name:" + account.AccountName + "\n sahre number" + account.ShareNumber + "\n stock price " + account.StockPrice);
                sum += account.StockPrice;
            }
            Console.WriteLine("Total value of accounts store in database Rs." + sum);
        }
        public void DisplayAccount()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to buy");
                accountname = Console.ReadLine();
                if (InventaryPrgm.InventaryUtility.ContainsCharacter(accountname))
                {
                    Console.WriteLine("no character allowed");
                    continue;
                }
                if (InventaryPrgm.InventaryUtility.ConatainsDigit(accountname))
                {
                    Console.WriteLine("no digit allowed");
                    continue;
                }
                if (InventaryPrgm.InventaryUtility.CheckString(accountname))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }

                NewAccount newAccount = JsonOperation.JsonReadFile();
                List<AccountModel> accounts = newAccount.AccountList;
                foreach (AccountModel name in accounts)
                {
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Account Name:" + name.AccountName + "\n sahre number" + name.ShareNumber + "\n stock price " + name.StockPrice);
                    }
                }
                break;

            }
        }
        public void Buy()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to buy");
                accountname = Console.ReadLine();
                if (InventaryPrgm.InventaryUtility.ContainsCharacter(accountname))
                {
                    Console.WriteLine("no character allowed");
                    continue;
                }
                if (InventaryPrgm.InventaryUtility.ConatainsDigit(accountname))
                {
                    Console.WriteLine("no digit allowed");
                    continue;
                }
                if (InventaryPrgm.InventaryUtility.CheckString(accountname))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }

                NewAccount newAccount = JsonOperation.JsonReadFile();
                List<AccountModel> accounts = newAccount.AccountList;
                foreach (AccountModel name in accounts)
                {
                    if (name.AccountName.Equals(accountname)) ;
                    {
                        Console.WriteLine("Enter share number you want to buy");
                        double price = Convert.ToDouble(Console.ReadLine());
                        int Number = Convert.ToInt32(Console.ReadLine());
                        name.ShareNumber = name.ShareNumber + Number;
                        name.StockPrice = name.StockPrice + price;
                    }
                    WriteToFile.DataWriteToFile(newAccount);
                }
                Console.WriteLine(accountname + "had Successfully buy their share stock price");
                break;
            }

        }
        public void Sell()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to Sell");
                accountname = Console.ReadLine();
                if (InventaryPrgm.InventaryUtility.ContainsCharacter(accountname))
                {
                    Console.WriteLine("no character allowed");
                    continue;
                }
                if (InventaryPrgm.InventaryUtility.ConatainsDigit(accountname))
                {
                    Console.WriteLine("no digit allowed");
                    continue;
                }
                if (InventaryPrgm.InventaryUtility.CheckString(accountname))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }

                NewAccount newAccount = JsonOperation.JsonReadFile();
                List<AccountModel> accounts = newAccount.AccountList;
                foreach (AccountModel name in accounts)
                {

                    if (name.AccountName.Equals(accountname)) ;
                    {
                        Console.WriteLine("Enter share number you want to buy");
                        double price = Convert.ToDouble(Console.ReadLine());
                        int Number = Convert.ToInt32(Console.ReadLine());
                        name.ShareNumber = name.ShareNumber + Number;
                        name.StockPrice = name.StockPrice + price;
                    }
                    WriteToFile.DataWriteToFile(newAccount);
                }
                Console.WriteLine(accountname + "had Successfully sell their share stock price");
                break;
            }
        }
    }
}

