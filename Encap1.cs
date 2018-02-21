using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{

    class A  
    {
        int Empid;
        string Ename;
        

        public void GetData()
        {
            Console.WriteLine(" Enter employee details");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            this.Ename = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Employee details");
            Console.WriteLine("EmpId : " + this.Empid);
            Console.WriteLine("EName : " + this.Ename);
        }


    }




    class Encap1
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.GetData();
            a1.Display();
            Console.Read();
        }

    }
}
