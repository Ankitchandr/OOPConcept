using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Multilevel inheritance
namespace ConsoleAppOOPS
{
    class ClsBranch
    {
        int Bcode;
        string BName;
        string BAddress;
        public void GetBranchData()
        {
            Console.WriteLine("Enter Branch Details");
            Console.WriteLine("Enter Branch code");
            this.Bcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Branch Name");
            this.BName = Console.ReadLine();
            Console.WriteLine("Enter Branch Address");
            this.BAddress = Console.ReadLine();
        }
        public void BranchDetails()
        {
            Console.WriteLine("Branch Details");
            Console.WriteLine("Branch code: " + this.Bcode);
            Console.WriteLine("Branch name: " + this.BName);
            Console.WriteLine("Branch Address: " + this.BAddress);
        }
    }
    class Employee : ClsBranch
    {
        int id;
        string name;
        int age;
        string address;
        public void GetEmpDetails()
        {
            Console.WriteLine("Enter employee details");

            Console.WriteLine("Enter employee id");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter employee age");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee address");
            this.address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Employeee Deteails");
            Console.WriteLine("Emp id : " + this.id);
            Console.WriteLine("Emp name:" + this.name);
            Console.WriteLine("Emp Age: " + this.age);
         }
       

    }

    class clsSalary : Employee
    {
        double Basic, DA, HRA, Gross;
        public void GetSal()
        {
            Console.WriteLine("Enter Basic salary");
            this.Basic = Convert.ToDouble(Console.ReadLine());
        }
        public void Calculator()
        {

            this.DA = Basic * 0.03;
            this.HRA = Basic * 0.03;
            this.Gross = Basic + HRA + DA;
        }

        public void DisplaySal()
        {
            Console.WriteLine("salary details");
            Console.WriteLine("Basic salary = "+ this.Basic);
            Console.WriteLine("DA is :" + this.DA);
            Console.WriteLine("HRA is :" + this.HRA);
            Console.WriteLine("Gross salary: " + this.Gross);
        }
    }

    class clsInheritance 
    {
        static void Main(string[] args)
        {
            clsSalary obj = new clsSalary();
           
            obj.GetBranchData();
            obj.GetEmpDetails();
            obj.GetSal();
            obj.Calculator();
            Console.WriteLine(" ");
            obj.BranchDetails();
            obj.Display();
            obj.DisplaySal();
            Console.Read();
        }

    }
 }

