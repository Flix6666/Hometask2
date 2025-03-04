using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q__
{
    class Program
    {
        static void Main(string[] args)
        {
            Library book1 = new Library();
            book1.Title = "Atomic Habits";
            book1.Author = "James Clar ";
            book1.ISBN = "132109"; 
            book1.Price = 1699 ;

            bool exit = true;
            while (exit)
            {


                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("LIbrary Managemnet System");
                Console.WriteLine("1. See Details ");
                Console.WriteLine("2. APPLY for Discount ");
                Console.WriteLine("3. Exit ");
                Console.WriteLine("Enter your choice ");
                Console.WriteLine("--------------------------------------------");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        book1.Display_dtails();

                        break;
                    case 2:
                        book1.Discount();

                        break;
                }

            }


        }
    }
}
