using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Birds
    {
        public void eat()
        {
            Console.WriteLine("Eating ....");
        }
   }
    class Inher1 : Birds
    {

        public void wing()
          {
            Console.WriteLine("Every birds has flying");
          }
        static void Main(string[] args)
        {
            Inher1 obj = new Inher1();
            obj.eat();
            obj.wing();
            Console.Read();
            
        }

    }
       
  }

