using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{

    class B
    {
        int Empid;
        int Age;
        string Ename;
        string Email;


        public void GetData()
        {
            Console.WriteLine(" Enter employee details");
            Console.WriteLine(" Enter employee Id");
            this.Empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter employee Age");
            this.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter employee Name");
            this.Ename = Console.ReadLine();

            Console.WriteLine(" Enter employee Email");
            this.Email = Console.ReadLine();

            Console.WriteLine(" ");
        }

        public void Display()
        {
            Console.WriteLine("Employee details");
            Console.WriteLine("EmpId : " + this.Empid);
            Console.WriteLine("EAge : " + this.Age);
            Console.WriteLine("EName : " + this.Ename);
            Console.WriteLine("Email : " + this.Email);
        }


    }




    class Encap2
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            b1.GetData();
            b1.Display();
            Console.Read();
        }

    }
}
