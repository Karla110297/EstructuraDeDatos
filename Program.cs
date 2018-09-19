using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_KarlaUrrea_TiempoEjecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            // suma de los números del 1 al 1,000,000
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            int suma = 0;
            for(int i = 1; i <= 1000000; i++)
            {
                suma += i;
            }
            Console.WriteLine("Suma= " + suma);
            
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stop.Subtract(start).TotalMilliseconds);
            Console.ReadKey();

        }
    }
}
