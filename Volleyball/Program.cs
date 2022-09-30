using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeYear = Console.ReadLine();
            int numSelebration = int.Parse(Console.ReadLine());
            int numWeekend = int.Parse(Console.ReadLine());

            int weekendInSofia = 48 - numWeekend;
            double gameInSofia = weekendInSofia * 3.0 / 4;
            double selebrationSofia = numSelebration * 2.0 / 3;

            double sumGames = gameInSofia + numWeekend + selebrationSofia;

            switch (typeYear)
            {

                case "leap":
                    sumGames = sumGames + sumGames * 15.0 / 100;
                    Console.WriteLine($"{Math.Floor(sumGames)}:f2");
                    break;
                case "normal":
                   
                    Console.WriteLine(Math.Floor(sumGames));
                    break;




                default:
                    break;
            }




        }
    }
}
