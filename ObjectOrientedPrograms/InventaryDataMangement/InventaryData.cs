// --------------------------------------------------------------------------------------------------------------------
// <copyright file= Inventary Data.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.InventaryDataMangement
{
   public class InventaryData
   {
     public void DisplayData()
     {
       try
       {
        ////json path
        string path = (@"C:\Users\admin\Desktop\BasicProgram\ObjectOrientedPrograms\ObjectOrientedPrograms\InventaryDataMangement\json1.json");
        //// Serializing json object.(A TextReader will convert (or encode) Text data (string or char)).
        StreamReader read = new StreamReader(path);
        //// Read all Charcter from the current position to the end.
        var json = read.ReadToEnd();
       //// Connert json format to string format.
        var items = JsonConvert.DeserializeObject<List<InventaryModel>>(json);
        Console.WriteLine("Name\tWeight\tRate(perkg)\tAmount");
        //// Loop through array items 
        foreach (var item in items)
        {
         Console.WriteLine(item.Name + "\t" +  item.Weight + "\t" +  item.PricePerKg + "\t\t" +  (item.Weight * item.PricePerKg));
        }
       }
         catch (Exception ex)
         {
          Console.WriteLine(ex.Message);
         }
     }
   }
}