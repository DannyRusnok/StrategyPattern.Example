using System;
using System.Globalization;
using System.Net.Mime;

namespace StrategyPattern.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nC for Czech, I for Ireland");

            var key = Console.ReadKey();
            
            switch (key.Key)
            {
                case ConsoleKey.C:
                    CultureInfo.CurrentCulture = new CultureInfo("cs-CZ");
                    break;
                case ConsoleKey.I:
                    CultureInfo.CurrentCulture = new CultureInfo("ga-IE");
                    break;
                default:
                    Main(new []{""});
                    break;
            }

            var phoneNumber = new PhoneNumber(123456789);
            
            Console.WriteLine($"\n{phoneNumber}");
        }
    }
}
