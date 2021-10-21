using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWebShop.Konsol
{
    public class Airplanes
    {
        private static List<Airplane> airplaneList = new List<Airplane>()
        {
            {new Airplane(){ Name ="BE 876"} },
            {new Airplane(){ Name ="FR 898"} },
            {new Airplane(){ Name ="GH 879"} },
            {new Airplane(){ Name ="BH 555"} },

        };

        

        public static List<Airplane> getAirplanes()
        {
            return airplaneList;
        }
    }
}
