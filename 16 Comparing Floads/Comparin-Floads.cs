using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = float.Parse(Console.ReadLine());
            float secondtNumber = float.Parse(Console.ReadLine());

            double difference = 0.000001;

            if (Math.Abs(firstNumber - secondtNumber) < difference)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
