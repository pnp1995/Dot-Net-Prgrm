using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryFactory
    {
        public static InventaryTypes ReadJsonFile()
        {
            string path = InventaryUtility.pathData();
            if (File.Exists(path))
            {
                string JsonData = File.ReadAllText(path);
                InventaryTypes JsonObjectArray = JsonConvert.DeserializeObject<InventaryTypes>(JsonData);
                return JsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
            }
            return new InventaryTypes();
        }
        public static void WriteToFile(InventaryTypes inventaryTypes)
        {
            string path = InventaryUtility.pathData();
            string JsonAdd = JsonConvert.SerializeObject(inventaryTypes);
            File.WriteAllText(path, JsonAdd);
        }
    }
}

