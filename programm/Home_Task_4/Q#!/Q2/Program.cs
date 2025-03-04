using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee();
            bool exit = true;
            while (exit)
            {


                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Employee Management System ");
                Console.WriteLine("1. See Details ");
                Console.WriteLine("2. change Employee Salary ");
                Console.WriteLine("3. Exit ");
                Console.WriteLine("Enter your choice ");
                Console.WriteLine("--------------------------------------------");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        E1.Show_Dtails();

                        break;
                    case 2:
                        Console.WriteLine("1. incrase Salary :");
                        Console.WriteLine("2. decrease Salary :");
                        Console.WriteLine("Entr your choice");
                        int choic2 = int.Parse(Console.ReadLine());
                        if (choic2 == 1)
                            E1.Increase_Salary();
                        else if (choic2 == 2)
                            E1.Decras_Salary();
                        else
                            Console.WriteLine("Invalid Choice !");

                            break;
                    case 3:
                        exit = false;
                        break;
                }

            }
        }
    }
}
