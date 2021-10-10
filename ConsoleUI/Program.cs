using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //parse method 

            /* 
             Code
            1. Console.WriteLine("Enter your age: ");
            2. int age = Console.ReadLine();

            */

            //above line will give swiggly below the readline method as in C# string cannot be converted into integer implicitly whereas integer can be converted implicitly into string.


            /* Another Code Example
             * In this code example, the only issue is if someone type input as string then the application will fail as the code expecting string as integer and then converted into integer data type.

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);

            age += 10;

            Console.WriteLine($"You will be {age} in 10 years.");

            */



            //Another example of type conversion (TryParse)

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();
            

            bool isVaildAge = int.TryParse(ageText, out int age);
            

            if (isVaildAge == true)
            {
                age += 20;
                Console.WriteLine($"you will be {age} in 20 years.");
            }

            else
            {
                Console.WriteLine("you have not entered age in integer rather than in string. Please try again.");
            }

            Console.ReadLine();
        }
    }
}