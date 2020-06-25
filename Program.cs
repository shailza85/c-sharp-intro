using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please tell us if you wan to add or subtract:");
           string userOperator = Console.ReadLine();

           if(userOperator == "add")
             {
                 Console.WriteLine("Please enter the first number:");
                 // @ link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                 int firstNum = Int32.Parse(Console.ReadLine ()); //convert the string to integer.
                Console.WriteLine("Please enter the second number:");
                 int secondNum = Int32.Parse(Console.ReadLine ());
                //Calculate the result.
                int result = firstNum + secondNum;
                  Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);
           }
           }
           }

        }
