// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BankingCAshCounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class BankingCashCounter
    {
        utility utility = new utility();
        internal static int InitialAmount= 50000;
        public void CashCounter()
        {
            try
            {
                Char choice;
                int ch;
                do
                {
                    BankingCashCounter bankdata = new BankingCashCounter();
                    Console.WriteLine("What type of transcation do you received");
                    Console.WriteLine("");
                    Console.WriteLine("1.Ddeposit cash");
                    Console.WriteLine("2.Withdrawl");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            utility.DepositCash(bankdata);
                            Console.WriteLine("Update cash available on your bank after Deposits = Rs." + InitialAmount);
                            break;
                        case 2:
                            utility.WithDrawalCash(bankdata);
                            Console.WriteLine("your available Balance after withdrawal = Rs." + InitialAmount);
                            break;
                    }
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

