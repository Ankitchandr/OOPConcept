using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{

        public class Bike
        {
            public virtual void speed()
            {
                Console.WriteLine("Average speed 70 km....");
            }

        }
        public class Hero: Bike
        {
            public override void speed()
            {
                Console.WriteLine(" Hero bike avg speed is 65 km...");

            }
        }
        public class RunTimePoly
        {
            public static void Main()
            {
                Bike  obj = new Hero();
               obj.speed();

                Console.ReadLine();
            }
        }
    }

