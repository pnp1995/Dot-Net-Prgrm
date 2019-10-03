// --------------------------------------------------------------------------------------------------------------------
// <copyright file= StockReport.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.StockReport
{
    class StockMain
    {
        public void Report()
        {
            try
            {
                double totalstockcost = 0;
                string path = (@"C:\Users\admin\Desktop\BasicProgram\ObjectOrientedPrograms\ObjectOrientedPrograms\StockReport\json2.json");
                StreamReader read = new StreamReader(path);
                //// Read all the character from current position to the end of the stream.
                var json = read.ReadToEnd();
                //// Convert json format to string format.
                StockModel[] items = JsonConvert.DeserializeObject<StockModel[]>(json);
                Console.WriteLine("");
                Console.WriteLine("Stock details for vechicles");
                Console.WriteLine("");
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine("Stock Name:- " + items[i].Stockname);
                    Console.WriteLine("Share Person:-" + items[i].Shareperson);
                    Console.WriteLine("Each Stock Cost:- Rs." + items[i].Stockprice);
                    Console.WriteLine("Total cost for" + items[i].Stockname + ":-Rs." + (items[i].Shareperson * items[i].Stockprice));
                    Console.WriteLine(" ");
                    totalstockcost = totalstockcost + (items[i].Stockprice * items[i].Shareperson);
                }
                Console.WriteLine("Total Cost for all Stock = Rs." + totalstockcost);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal class InventaryOption
        {
            internal void InventaryManagementMethod()
            {
                throw new NotImplementedException();
            }

            public static implicit operator InventaryOption(InventaryPrgm.InventaryOption v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
