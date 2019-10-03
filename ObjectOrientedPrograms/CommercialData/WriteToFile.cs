using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Unipluss.Sign.Client.Models;

namespace ObjectOrientedPrograms.CommercialData
{
    class WriteToFile
    {
        public static void DataWriteToFile(NewAccount newAccount)
        {
            string path = @"C:\Users\admin\Desktop\BasicProgram\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialData\jsoncomr.json";
            string jsonAddressBook = JsonConvert.SerializeObject(newAccount);
            System.IO.File.WriteAllText(path, jsonAddressBook);
        }
    }
}
