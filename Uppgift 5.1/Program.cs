using System;
namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriva in 5 namn?");
            string [] namn = new string[5];  
            
            for (int i = 0; i < 5; i++)
            {
              namn[i] = Console.ReadLine();
            }
            Console.WriteLine($"{namn[0]}, {namn[1]}, {namn[2]}, {namn[3]}, {namn[4]}");
        }
    }
}