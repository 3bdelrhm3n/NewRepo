using System.Numerics;

namespace pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Small = 25;
            double Large = 35;
            double Tax = 6.6;
            Console.Write("Enter the number of small carpets : ");
             double smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of large carpets : ");
            double  largeCarpets = Convert.ToInt32(Console.ReadLine());

            smallCarpets = smallCarpets * Small;
            largeCarpets = largeCarpets * Large;

            Console.WriteLine( "price per small room 25$:");
            Console.WriteLine("price per large room 35$:");
            Console.WriteLine("\n--- TOTAL ---");
            Console.WriteLine($"Total charges for small carpets: ${smallCarpets}");
            Console.WriteLine($"Total charges for large carpets: ${largeCarpets}");
            Console.WriteLine($" tax is (6.6%): ${Tax}");
            Console.WriteLine($"Total charges : {smallCarpets+ largeCarpets+ Tax}");
            Console.WriteLine("This estimate is valid for 30 days\r\n");



        }
    }
}
