using System;
using System.Globalization;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            var pt = new CultureInfo("pt-BR");
            var br = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString("D", pt));
        }
    }
}
