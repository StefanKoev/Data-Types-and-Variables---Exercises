using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_the_Photografer
{
    class Program
    {
        static void Main()
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long totalFilterTime = numberOfPictures * filterTime;
            long goodPicturies = (long)(Math.Ceiling(numberOfPictures * filterFactor / 100d));
            long totalUploadTime = goodPicturies * uploadTime;

            long totalTime = totalFilterTime + totalUploadTime;

            TimeSpan projectTime = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                projectTime.Days,
                projectTime.Hours,
                projectTime.Minutes,
                projectTime.Seconds);
        }
    }
}
