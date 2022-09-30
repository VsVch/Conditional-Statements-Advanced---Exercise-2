using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_Advanced___Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishers = int.Parse(Console.ReadLine());

            int priceDuringProlet = 3000;
            int priceDjuringSummer = 4200;
            int priceDjuringAunt = 4200;
            int priceDujringZima = 2600;

            double priceForKorab = 0;
            switch (season)
            {
                case "Spring":
                    priceForKorab = priceDuringProlet;
                    break;
                case "Summer":
                    priceForKorab = priceDjuringSummer;
                    break;
                case "Autumn":
                    priceForKorab = priceDjuringAunt;
                    break;
                case "Winter":
                    priceForKorab = priceDujringZima;
                    break;
                default:
                    break;
            }

            int discount = 0;
            if (numOfFishers <= 6)
            {
                discount = 10;
            }
            else if (numOfFishers > 7 && numOfFishers <= 11)
            {
                discount = 15;
            }
            else
            {
                discount = 25;
            }

            priceForKorab = priceForKorab - priceForKorab * discount / 100;


            int discout = 0;


            if (numOfFishers % 2 == 0 && season != "Autumn")
            {
                discount = 5;
                priceForKorab = priceForKorab - priceForKorab * discount / 100;
            }



            double rest = Math.Abs(budjet - priceForKorab);
            if (budjet >= priceForKorab)
            {
                Console.WriteLine($"Yes! You have {rest:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rest:f2} leva.");
            }

        }
    }
}