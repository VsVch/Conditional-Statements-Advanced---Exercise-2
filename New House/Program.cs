using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {

            string kinfOfFlowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budjetForFlowers = int.Parse(Console.ReadLine());

            double priceRoses = 5.00;
            double priceDahlia = 3.80;
            double priceTulips = 2.80;
            double proceNarcissus = 3.00;
            double priceGladiolus = 2.50;

            double needManey = 0.00;
            double priceFwolers = 0.00;


            if (kinfOfFlowers == "Roses")
            {
                if (numOfFlowers > 80 )
                {
                    priceFwolers = (priceRoses /100)*10;
                    priceFwolers = priceRoses - priceFwolers;
                }
                else
                {
                    priceFwolers = priceRoses;
                }

            }
            else if (kinfOfFlowers == "Dahlias")
            {
                if (numOfFlowers > 90)
                {
                    priceFwolers = (priceDahlia /100)*15;
                    priceFwolers = priceDahlia - priceFwolers;
                }
                else
                {
                    priceFwolers = priceDahlia;
                }
            }
            else if (kinfOfFlowers == "Tulips")
            {
                if (numOfFlowers > 80)
                {
                    priceFwolers = (priceTulips /100)*15;
                    priceFwolers = priceTulips - priceFwolers;
                }
                else
                {
                    priceFwolers = priceTulips;
                }
            }
            else if (kinfOfFlowers == "Narcissus")
            {
                if (numOfFlowers < 120)
                {
                    priceFwolers = (proceNarcissus/100)*15;
                    priceFwolers = proceNarcissus + priceFwolers;
                }
                else
                {
                    priceFwolers = proceNarcissus;
                }
            }
            else if (kinfOfFlowers == "Gladiolus")
            {
                if (numOfFlowers < 80)
                {
                    priceFwolers = (priceGladiolus /100)*20;
                    priceFwolers = priceGladiolus + priceFwolers;
                }
                else
                {
                    priceFwolers = priceGladiolus;
                }
            }

            needManey = numOfFlowers * priceFwolers;

            double sec = Math.Abs(budjetForFlowers-needManey);

            if (budjetForFlowers >= needManey)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {kinfOfFlowers} and {sec:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sec:F2} leva more.");
            }
           


        }
    }
}
