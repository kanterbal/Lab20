using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double d);
        static void Main(string[] args)
        {
            Console.Write("Vvedite R: ");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate length = Length;
            if (length != null)
                Console.WriteLine($"{length(r)}");

            Func<double, double> square = Square;
            Console.WriteLine(square(r));

            MyDelegate volume = radius => 4 / 3.0 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"{volume(r)}");

            Console.ReadKey();
        }

        static double Length(double r)
        {
            return 2 * Math.PI * r;
        }

        static double Square(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        //static double Volume(double r)
        //{
        //    return 4 / 3.0 * Math.PI * Math.Pow(r, 3);
        //}
    }
}
