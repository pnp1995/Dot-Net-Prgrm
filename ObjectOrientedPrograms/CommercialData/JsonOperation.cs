using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Unipluss.Sign.Client.Models;

namespace ObjectOrientedPrograms.CommercialData
{
    class JsonOperation
    {
        public static NewAccount JsonReadFile()
        {
            string path = @"C:\Users\admin\Desktop\BasicProgram\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialData\jsoncomr.json";
            if(File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);
                NewAccount account = JsonConvert.DeserializeObject<NewAccount>(jsonData);
                return account;
            }
            else
            {
                Console.WriteLine("Specified path does not exist");
                return NewAccount();
            }
        }

        private static NewAccount NewAccount()
        {
            throw new NotImplementedException();
        }
    }
}
