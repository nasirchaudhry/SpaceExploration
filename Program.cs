using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace SpaceExploration
namespace SpaceExploration
{
    /// <summary> 
    /// This program will calculate the increase in velocity of a spaceship by given values. First part of the program
    /// will calculate the increase in velocity when boosters of the spaceship fired for 5 minutes and the second part
    /// of this program will calculate increase in velocity when the boosters were fired for 2 hours (boosters fired for 
    /// 5 minutes and coast for 10 minutes).
    /// </summary>

    //start class program
    class Program
    {
        //start main function
        static void Main(string[] args)
        {
            //declare variables
            double x = 0;            
            double increaseVel = 0;
            double temp = 0;

            //First part of the problem
            //start for loop to calculate the increase in velocity for 5 minutes
            for ( x = 0; x < 10; x++)
            {
                //start if loop
                if (x == 0)
                {
                    increaseVel = 10000 + (10000 * .05);
                }
                else 
                {
                    increaseVel = increaseVel + (increaseVel * .05);
                }//end if loop               
            }//end for loop
            
            //print out the spaceships speed after 5 minutes
            Console.WriteLine("After firing boosters for five minutes Spaceship will be travelling at the speed of: " + increaseVel + " miles per hour.");

            //Second part of the problem
            //external for loop to find out the speed of the spaceship after 2 hours (fire & coast)
            //start for loop
            for (int i = 0; i < 8; i++)
            {
                //internal for loop
                for (x = 0; x < 10; x++)
                {
                    if (temp == 0)
                    {
                        increaseVel = 10000 + (10000 * .05);
                        temp++;
                    }
                    else
                    {
                        increaseVel = increaseVel + (increaseVel * .05);
                    }
                }//end for loop             
            }//end external for loop

            //print out the spaceship speed after 2 hours
            Console.WriteLine("After 2 hours the Spaceship will be traveling at the speed of: " + increaseVel + " miles per hour.");
            Console.ReadLine();

        }//end main method
    }//end class Program
}//end namespace SpaceExploration