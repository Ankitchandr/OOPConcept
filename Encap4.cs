using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Encap4
    {
        static void Main(string[] args)
        {
            Encap3 p = new Encap3();
            p.ProductId = "101";
            p.productName = "facewash";
            Console.WriteLine("PRODUCT ID :" + p.ProductId);
            Console.WriteLine("PRODUCT NAME : " + p.productName);
            
            Console.Read();
        }

    }
}

