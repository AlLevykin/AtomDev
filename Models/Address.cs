using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models
{
    //The properties in the address are put
    //according to ФИАС address structure
    //(see https://ru.wikipedia.org/wiki/Федеральная_информационная_адресная_система)
    public class Address
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string Okrug { get; set; }
        public string MunicipalUnit { get; set; }
        public string MunicipalSettlement { get; set; }
        public string Settlement { get; set; }
        public string PlanningPatternElemnt { get; set; }
        public string RoadNetworkElement { get; set; }
        public string LandLotNumber { get; set; }
        public string MyProperty { get; set; }
        public string UnfinishedObjectNumber { get; set; }
        public string RoomNumber { get; set; }
    }
}
