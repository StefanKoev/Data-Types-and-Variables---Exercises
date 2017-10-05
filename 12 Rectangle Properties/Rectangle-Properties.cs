using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double with = double.Parse(Console.ReadLine());
            double leight = double.Parse(Console.ReadLine());

            double perimeter = 2 * (with + leight);
            double area = with * leight;
            double diagonal = Math.Sqrt(with * with + leight * leight);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
