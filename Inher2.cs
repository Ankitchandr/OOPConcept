using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//single Inheritance
namespace ConsoleAppOOPS
{

    class Emp
    {
        int id;
        string name;
        public void EmployeeDetails()
        {
            Console.WriteLine(" Input Employee Details");
            Console.WriteLine("Employee id");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee name");
            this.name = Console.ReadLine();
       }
        public void EmpDetails()
        {
          //  Console.WriteLine("Employee Details");
            Console.WriteLine("Empid:"+ this.id);
            Console.WriteLine("EmpName:" + this.name);
         
        }
    }

    class Inher2:Emp
    {
        int salary;
        int insentive;

        public void InputSalary()
        {
            Console.WriteLine("Enter salary Details");
            Console.WriteLine("Enter salary");
            this.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter insentive");
            this.insentive = Convert.ToInt32(Console.ReadLine());
        }


        public void SalaryDetails()
        {
           // Console.WriteLine("Enter salary Details");
            Console.WriteLine("Emp salary: " + this.salary);
            Console.WriteLine("Emp insentive " + this.insentive);
            Console.Read();
        }

        static void Main(string[] args)
        {
            Inher2 obj = new Inher2();
            obj.EmployeeDetails();
            obj.InputSalary();
            Console.WriteLine(" ");
            Console.WriteLine("Employee Details with salary");
            obj.EmpDetails();
            obj.SalaryDetails();
            
        }
    }
}
