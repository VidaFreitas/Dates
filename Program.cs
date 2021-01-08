using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var timeSpam = new TimeSpan();
            Console.WriteLine(timeSpam);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanHoraMinutoSegundoMilisegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanHoraMinutoSegundoMilisegundo);
        }
    }
}