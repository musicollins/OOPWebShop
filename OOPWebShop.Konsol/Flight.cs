using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace OOPWebShop.Konsol
{
    //Flight Tower
    class Flight
    {
        public static Dictionary<string, List<int>> FlightInfo { get; set; } = new Dictionary<string, List<int>>();
        static void Main(string[] args)
        {
            //Load Airplanes to FlightInfo Dictionary
            LoadAirplanes();
            while (true)
            {
                Clear();
                foreach (var airplane in Airplanes.getAirplanes())
                {
                    //Update Tracker every 2 seconds
                    airplane.UpdateTracker();
                    //Show info via ToString()
                    WriteLine(airplane.ToString());
                }
                Thread.Sleep(2000);
            }

        }

        public static void LoadAirplanes()
        {
            foreach (var airplane in Airplanes.getAirplanes())
            {
                FlightInfo.Add(airplane.Name, new List<int>());
            }
        }

    }
}
