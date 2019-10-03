using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryTypes
    {
        private List<RiceModel> riceList = new List<RiceModel>();
        private List<PulsesModel> pulseList = new List<PulsesModel>();
        private List<WheatModel> wheatList = new List<WheatModel>();

        public List<RiceModel> RiceList { get; set; }
        public List<PulsesModel> PulseList { get; set; }
        public List<WheatModel> WheatList { get; set; }
       
    }
}
    
