using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string kindHotel = "";

            double rest = 0.00;

            if (budjet <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budjet>100&&budjet<=1000)
            {
                destination = "Balkans";
            }
            else if (budjet>1000)
            {
                destination = "Europe";
            }

            if (season=="summer"&&destination=="Bulgaria")
            {
                kindHotel = "Camp";
            }
            else if (season == "winter" && destination == "Bulgaria")
            {
                kindHotel = "Hotel";
            }
            else if (season == "summer" &&  destination == "Balkans")
            {
                kindHotel = "Camp";
            }
            else if (season == "winter" &&  destination == "Balkans")
            {
                kindHotel = "Hotel";
            }








            else if (destination == "Europe")
            {
                kindHotel = "Hotel";
            }
            if (destination== "Bulgaria"&&season=="summer")
            {
                rest = budjet * 30 / 100;
            }
            else if (destination == "Bulgaria" && season == "winter")
            {
                rest = budjet * 70 / 100;

            }
            else if (destination == "Balkans" && season == "summer")
            {
                rest = budjet * 40 / 100;
            }
            else if (destination == "Balkans" && season == "winter")
            {
                rest = budjet * 80 / 100;

            }
            else if (destination=="Europe")
            {
                rest = budjet * 90 / 100;
            }


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{kindHotel} - {rest:F2}");



        }
    }
}
