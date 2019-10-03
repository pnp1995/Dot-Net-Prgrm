using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialData
{
    class CreateAccount
    {
        public void Create()
        {
            string accountname = null;
            int sharenumber = 0;
            double shareprice = 0;
            Console.WriteLine("Enter Name to create an account");
            accountname = Console.ReadLine();
            while(true)
            {
                if(InventaryPrgm.InventaryUtility.ContainsCharacter(accountname))
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
                break;
            }
            sharenumber = 0;
            double stockprice = 0;
            AccountModel.CreateAccountObject(accountname, sharenumber, stockprice);
            Console.WriteLine("New Account has been created with name " + accountname);
        }
    }
}
