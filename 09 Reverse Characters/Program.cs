using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
          
            char new1 = char.Parse(Console.ReadLine());
            char new2 = char.Parse(Console.ReadLine());
            char new3 = char.Parse(Console.ReadLine());

            string text = string.Concat(new1, new2, new3);
            string reverseText = new string(text.Reverse().ToArray());

            Console.WriteLine(reverseText);
        }
    }
}
