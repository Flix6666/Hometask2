using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
   internal class Employee
    {
        public  string EmployeeID;
        public string EmployeeName;
        public string Department ;
        public double Salary;


        public Employee()
        {
            EmployeeID = "132109";
            EmployeeName = "Abdul Qadeer ";
            Department = "Computer Scince ";
            Salary = 150000;
        }
        public void Show_Dtails()
        {
            Console.WriteLine("Details are :");
            Console.WriteLine($"Employee ID is {EmployeeID}");
            Console.WriteLine($"Employee name is {EmployeeName}");
            Console.WriteLine($"Employee Department is {Department}");
            Console.WriteLine($"Employee Salary is {Salary}");
        }
        public void Increase_Salary()
        {
            Console.WriteLine("Enter the amount for increament ");
            int amount = int.Parse(Console.ReadLine());
            Salary = Salary + amount;
            Console.WriteLine($"New salary of {EmployeeName} is {Salary}");

        }
        public void Decras_Salary()
        {
            Console.WriteLine("Enter the amount for Decremnt  ");
            int amount = int.Parse(Console.ReadLine());
            Salary = Salary - amount;
            Console.WriteLine($"New salary of {EmployeeName} is {Salary}");
        }
    }
}
