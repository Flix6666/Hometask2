using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__
{
    internal class Library
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;
      
        public void Display_dtails()
        {
          
            Console.WriteLine($"Book Details are : ");
            Console.WriteLine($"Title of book is : {Title}");
            Console.WriteLine($"Author of book is : {Author}");
            Console.WriteLine($"ISBN of book is : {ISBN}");
            Console.WriteLine($"Price of book is : {Price}");
            
        }
        public void Discount()
        {
            Console.WriteLine("Write the Code for Discount ");
            string code = Console.ReadLine();
            string pass = "Pizza";
            if (code == pass)
            {
                Random random = new Random();
                int num1 = random.Next(1, 101);
                int num2 = 100 - num1;
                Console.WriteLine($"Congratulation You Got {num1}% Discount");
                double newPrice = (Price / 100) * num2;
                Price = newPrice ;
                Console.WriteLine($"Your New Price Is {newPrice}");

            }
            else
                Console.WriteLine("You entr the wrong code !");
        }

    }
}
