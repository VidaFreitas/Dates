using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = new DateTime(2021, 01, 07, 17, 50, 12);
            // var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
        }
    }
}
