using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_and_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine();
            var string2 = Console.ReadLine();

            string result = String.Concat(string1, " ", string2);

            Console.WriteLine(result);
        }
    }
}
