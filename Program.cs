using System;
using System.Threading;

namespace Week5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number from 1 to 20.");
            int num = int.Parse (Console.ReadLine());
            for (int i = num; i > 0; i--)

            {
                Console.WriteLine(i);
                Thread.Sleep(1000);


            }

            Console.WriteLine("Exercise 2!");

            for (int i = 0; i <= 100; i++)

            {
                Console.WriteLine(i);
                i++;

            }

            Console.WriteLine("Exercise 3!");
            for (int i = 1; i <= 7; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(k);
                }
                Console.Write(i);
                for (int j = 7 - i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }

            Console.WriteLine("Exercise 4!");
            Console.Write(0+" ");
            Console.Write(1+" ");
            int lastNum = 1;
            int twoNumAgo = 0;
            for (int i = 1; i <= 8; i++)
            {
               

                int currentNum = lastNum + twoNumAgo;
                Console.Write(currentNum+" ");
                twoNumAgo = lastNum;
                lastNum = currentNum;
              


            }
            Console.WriteLine();
            Console.WriteLine("Exercise 5!");
            string xLine = "XOXOXOXO";
            string oLine = "OXOXOXOX";
            for (int i = 1; i <= 8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(oLine);
                }
                else
                {
                    Console.WriteLine(xLine);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
