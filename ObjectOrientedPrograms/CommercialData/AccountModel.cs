using System;
using System.Collections.Generic;
using System.Text;
using Unipluss.Sign.Client.Models;

namespace ObjectOrientedPrograms.CommercialData
{
    public class AccountModel
    {
        private string accountname;
        private int sharenumber;
        private double stockprice;

        public AccountModel(string accountname, int sharenumber, double stockprice)
        {
            this.accountname = accountname;
            this.sharenumber = sharenumber;
            this.stockprice = stockprice;
        }

        public string AccountName { get; set;}
        public int ShareNumber { get; set; }
        public double StockPrice { get; set; }
        public static void CreateAccountObject(string accountname,int sharenumber,double stockprice)
        {
            AccountModel account = new AccountModel(accountname, sharenumber, stockprice);
            NewAccount newAccount = JsonOperation.JsonReadFile();
            newAccount.AccountList.Add(account);
            WriteToFile.DataWriteToFile(newAccount);
            Console.WriteLine("Account had been successfully created");
        }
    }
}
