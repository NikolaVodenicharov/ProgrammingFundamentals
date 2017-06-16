using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaPhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureAmount = int.Parse(Console.ReadLine());
            int filterTimePerPicture = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadingTimePerPicture = int.Parse(Console.ReadLine());

            long filterTime = (long)pictureAmount * filterTimePerPicture; //long filterTime = pictureAmount * filterTimePerPicture; - tova dava gre6ka. Poneje se ymnojavat int * int i suotvetno vrushta int. dava6e mi 70/100 to4ki.
            long usefulPicture = (long)Math.Ceiling((double)pictureAmount * filterFactor / 100);
            long uploadingTime = usefulPicture * uploadingTimePerPicture;
            long timeInSeconds = filterTime + uploadingTime;

            TimeSpan convertTime = TimeSpan.FromSeconds(timeInSeconds);
            string timeInFormat = convertTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(timeInFormat);

            //long seconds = timeInSeconds % 60;
            //long minutes = 0;
            //if ((timeInSeconds / 60) < 60)
            //{
            //    minutes = timeInSeconds / 60;
            //}
            //else
            //{
            //    minutes = (timeInSeconds / 60) % 60;
            //}

            //long hours = 0;
            //if ((timeInSeconds / 3600) < 24)
            //{
            //    hours = timeInSeconds / 3600;
            //}
            //else
            //{
            //    hours = (timeInSeconds / 3600) % 24;
            //}

            //long days = (timeInSeconds / 3600) / 24;

            //Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
