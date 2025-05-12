using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempUnitConverter
{
    class Program
    {
        /*
         0 °C = 32 F = 273.15 °K
        10 °C = 50 F = 283.15 °K
        100 °C = 212 F = 373.15 °K
        0 °K = -273.15 °C = -459.67 F
        100 °K = -173.15 °C = -279.67 F
        -273.15 °K = 0 °C = 32 F
         */
        static void Main(string[] args)
        {
            double c = 10;
            double k = 0;
            double f = 32;
            Converter converter = new Converter();
            double kk = converter.CToK(c);
            Console.WriteLine("10 °C = " + kk + " °K");
            double ff = converter.CToF(c);
            Console.WriteLine("10 °C = " + ff + " °F");
            double cc = converter.KToC(k);
            Console.WriteLine("0 °K = " + cc + " °C");
            double fff = converter.KToF(k);
            Console.WriteLine("0 °K = " + fff + " °F");
            double kkk = converter.FToK(f);
            Console.WriteLine("32 °F = " + kkk + " °K");
            double ccc = converter.FToC(f);
            Console.WriteLine("32 °F = " + ccc + " °C");
            Console.ReadKey();
        }
    }
}
