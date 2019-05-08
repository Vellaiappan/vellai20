using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayExcercise
{
    class Question4
    {
        static void Main(String[] args)
        {
                Console.WriteLine("Please Enter the distance travelled in KM");
                double distance = double.Parse(Console.ReadLine());
                double roundDistance = Math.Ceiling((distance * 10)) / 10;
                distance = roundDistance;
                Console.WriteLine($"The Rounded distance is {roundDistance:0.00}.");
                double fare = 2.40;
                if(roundDistance>0.5)
                {
                  roundDistance = roundDistance - 0.5;
                    if(roundDistance>8.5)
                    {
                    fare = fare + (8.5 * 10 * 0.04);
                    roundDistance = roundDistance - 8.5;
                    fare=fare+ (roundDistance * 10 * 0.05);
                    }
                    else
                    {
                      fare=fare+ (roundDistance * 10 * 0.04);

                    }
                  //if(roundDistance>0 && roundDistance<=8.5)
                  //{
                  //   fare = fare + (((roundDistance * 1000) / 100) * 0.04);
                  //   roundDistance = roundDistance - 8.5;
                     
                  //}
                  //else
                  //{
                  //      fare = fare + (85 * 0.04);
                  //      roundDistance = roundDistance - 8.5;
                  //      fare = fare + (((roundDistance * 1000) / 100) * 0.05);
                    
                  // }
                }
                Console.WriteLine($"The fare for distance {distance}KM is {fare}");
                
        }
    }
}
