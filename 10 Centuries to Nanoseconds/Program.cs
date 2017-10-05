using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centurries = uint.Parse(Console.ReadLine());

            uint years = centurries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong millesecons = seconds * 1000;
            decimal microseconds = millesecons * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centurries, years, days, hours, minutes, seconds, millesecons, microseconds, nanoseconds);

        }
    }
}
