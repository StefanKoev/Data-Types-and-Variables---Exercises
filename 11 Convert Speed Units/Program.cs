using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Limits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancInMeters= float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float distanceInKilometers = distancInMeters / 1000f;
            float distanceInMiles = distancInMeters / 1609f;
            float totalHours = (hours + (minutes / 60f) + ((seconds / 60f) / 60f));
            float totalMinutes = (minutes + (hours * 60f) + (seconds / 60f));
            float totalSeconds = (((hours * 60f) * 60f) + (minutes * 60f) + seconds);
            
            float SpeedInMetersPerSeconds = (distancInMeters / totalSeconds);
            float SpeedInKilometersPerHour = (distanceInKilometers / totalHours);
            float SpeedInMilesPerHour = (distanceInMiles / totalHours);

            Console.WriteLine(SpeedInMetersPerSeconds);
            Console.WriteLine(SpeedInKilometersPerHour);
            Console.WriteLine(SpeedInMilesPerHour);

        }
    }
}
