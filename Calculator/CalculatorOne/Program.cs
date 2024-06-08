using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;

            Console.WriteLine("Hello, Welcome to the calculator program!!");
            Console.WriteLine("Please Enter Your First Number: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pleade Enter You Secomd: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of opration you like to do?");
            Console.WriteLine("Please enter a for addition, s for substraction, m for multiplication or any other key for division.");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if(answer == "b")
            {
                result = num1 - num2;
            }
            else if (answer == "c")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            Console.WriteLine("The result is : " + result);
            Console.WriteLine("Thank you for using the calculator program!");

            Console.ReadKey();  
        }
    }
}
