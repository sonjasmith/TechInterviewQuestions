using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fizz Buzz
            //Write an application that asks the user for an integer.
            //Console.WriteLine("Please enter an integer:");
            //int integer = int.Parse(Console.WriteLine);



            //If that number is divisible by 3, "Fizz" should print

            //If it's divisible by 5, "Buzz" should print

            //If it's divisible by both, "Fizz Buzz" should print.


            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 3 == 0 && userNumber % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (userNumber % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (userNumber % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
          
        }
    }
}
