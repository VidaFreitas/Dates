using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss}", data);
            Console.WriteLine(formatada);

        }
    }
}
