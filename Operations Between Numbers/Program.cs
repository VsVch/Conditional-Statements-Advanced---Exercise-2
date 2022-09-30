using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double rezult = 0;



            switch (operation)
            {
                case "+":
                    rezult = n1 + n2;
                    if (rezult % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {rezult} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {rezult} - odd");
                    }

                    break;
                case "-":
                    rezult = n1 - n2;
                    if (rezult % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {rezult} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {rezult} - odd");
                    }

                    break;
                case "*":
                    rezult = n1 * n2;
                    if (rezult % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {rezult} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {rezult} - odd");
                    }

                    break;

                    

                case "/":
                    if (n2==0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        rezult = n1 * 1.0 / n2;
                        Console.WriteLine($"{n1} / {n2} = {rezult:f2}");
                    }
                    

                    break;
                case "%":

                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        rezult = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {rezult}");
                    }

                    break;



                default:
                    break;
            }


        }
    }
}
