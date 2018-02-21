using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//method overloading
namespace ConsoleAppOOPS
{
    class Method1
    {
        int a, b, s;
        public void Add()
        {
            a = 10;
            b = 20;
            s = a + b;
            Console.WriteLine("sum : " + s);
        }
        public void Add(int i, int j)
        {
            a = i;
            b = j;
            s = a + b;
            Console.WriteLine("sum : " + s);
        }

        static void Main(string[] args)
        {
            Method1 obj = new Method1();
            obj.Add();
            obj.Add(50,60);
            Console.Read();
        }
    }
}
