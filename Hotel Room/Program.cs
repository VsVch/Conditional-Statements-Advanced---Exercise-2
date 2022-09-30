using System;

namespace _4._8Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesec = Console.ReadLine();
            int dni = int.Parse(Console.ReadLine());

            //double nosht =  dni  - 1; !?!

            double nosht = dni;
            double studio = 0.0;
            double apartament = 0.0;
            if (mesec == "May" || mesec == "October")
            {
                studio = nosht * 50.00;
                apartament = nosht * 65;
                if (nosht > 7 && nosht < 14)
                {
                    studio = studio - (studio * 0.05);
                }
                else if (nosht > 14)
                {
                    studio = studio - (studio * 0.30);
                    apartament = apartament - (apartament * 0.10);
                }
            }
            else if (mesec == "June" || mesec == "September")
            {
                studio = nosht * 75.20;
                apartament = nosht * 68.70;
                if (nosht > 14)
                {
                    studio = studio - (studio * 0.20);
                    apartament = apartament - (apartament * 0.10);
                }
            }
            else if (mesec == "July" || mesec == "August")
            {
                studio = nosht * 76;
                apartament = nosht * 77;
                if (nosht > 14)
                {
                    apartament = apartament - (apartament * 0.10);
                }
            }
            Console.WriteLine($"Apartment: {apartament:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }
    }
}