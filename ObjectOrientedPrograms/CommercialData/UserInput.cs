using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialData
{
    class UserInput
    {
        public void Input()
        {
            try
            {
                char choice;
                int ch = 0;
                do
                {
                    Console.WriteLine("**What you want**");
                    Console.WriteLine("");
                    Console.WriteLine("1.Create new Account");
                    Console.WriteLine("2.Display total value of Account stock");
                    Console.WriteLine("3.Add share and stock to Account");
                    Console.WriteLine("4.Buy Share of stock from account");
                    Console.WriteLine("5.Sell Shares of stock fronm Account");
                    Console.WriteLine("Display particular Account details reports of shares and stocks");
                    Console.WriteLine("Exit");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your choice to perform");
                    Console.WriteLine("");
                    ch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    switch (ch)
                    {
                        case 1:
                            CreateAccount create = new CreateAccount();
                            create.Create();
                            break;
                        case 2:
                            AccountOpeartion account = new AccountOpeartion();
                            account.DisplayStock();
                            break;
                        case 3:
                            AccountOpeartion accountbuy = new AccountOpeartion();
                            accountbuy.Buy();
                            break;
                        case 4:
                            AccountOpeartion displayaccount = new AccountOpeartion();
                            displayaccount.DisplayAccount();
                            break;
                        case 5:
                            AccountOpeartion accountsell = new AccountOpeartion();
                            accountsell.Sell();
                            break;
                        case 6:
                            return;
                    }
                    Console.WriteLine("Do you want to Continue then press y");
                    choice = Convert.ToChar(Console.ReadLine());

                }
                while (choice == 'y');

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
