using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter a string:");
           string userInput = Console.ReadLine(); //assignment operator. Collecting data from user.
           if (userInput.Length > 0)
           {
               Console.WriteLine("The user entered a value.");
           }
           else
           {
                 Console.WriteLine("The user did not entered a value.");
           }
           }
        }
    }