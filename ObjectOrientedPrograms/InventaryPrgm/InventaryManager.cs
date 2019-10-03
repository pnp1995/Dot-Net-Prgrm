using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryManager
    {
        public static void InventaryList(string inventaryType)
        {
            try
            {
                InventaryTypes inventaryTypes = InventaryFactory.ReadJsonFile();
                if(inventaryTypes.Equals("Rice"))
                {
                    List<RiceModel> riceList = inventaryTypes.RiceList;
                    foreach (RiceModel rice in riceList)
                    {
                        Console.WriteLine("RICE TYPE");
                        Console.WriteLine("Name:" + rice.Name + "\nWeight:" + rice.Weight + "\nPriceperKg:" + rice.Priceperkg);
                        Console.WriteLine("");        
                    }
                    return;
                }
                if (inventaryTypes.Equals("Pulse"))
                {
                    List<PulsesModel> pulseList = inventaryTypes.PulseList;
                    foreach (PulsesModel pulse in pulseList)
                    {
                        Console.WriteLine("PULSE TYPE");
                        Console.WriteLine("Name:" + pulse.Name + "\nWeight:" + pulse.Weight + "\nPriceperKg:" + pulse.Priceperkg);
                        Console.WriteLine("");
                    }
                    return;
                }
                if (inventaryTypes.Equals("Wheat"))
                {
                    List<WheatModel> wheatList = inventaryTypes.WheatList;
                    foreach (WheatModel wheat in wheatList)
                    {
                        Console.WriteLine("WHEAT TYPE");
                        Console.WriteLine("Name:" + wheat.Name + "\nWeight:" + wheat.Weight + "\nPriceperKg:" + wheat.Priceperkg);
                        Console.WriteLine("");
                    }
                    return;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
