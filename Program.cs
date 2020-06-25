using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
          //Guide for the user.....
           Console.WriteLine("PLease enter add/subtract/multiply/exit:");
           
           string userInput;
           while(( userInput = Console.ReadLine()) != "exit" ) //Loops untill the user enters "exit" command.
           {
              int firstNum;
              int secondNum;
              int result;  

              //switch statement are similar to if/else
              switch(userInput)  //Here we enter the value we want to test.
              { // Cases are us testing above against specific values we want to test.
                  case "add":
                  Console.WriteLine("Enter first number for addition:");
                  firstNum = Int32.Parse(Console.ReadLine());

                  Console.WriteLine("Enter second number for addition:");
                  secondNum = Int32.Parse(Console.ReadLine());

                  result = firstNum + secondNum;
                  Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);
                  break;
                  // End of case

                  case "subtract":
                  Console.WriteLine("Enter first number for subtraction:");
                  firstNum = Int32.Parse(Console.ReadLine());

                  Console.WriteLine("Enter second number for subtraction:");
                  secondNum = Int32.Parse(Console.ReadLine());

                  result = firstNum - secondNum;
                  Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, result);
                   break;
                   // Case end

                  case "multiply":
                  Console.WriteLine("Enter first number for multiply:");
                  firstNum = Int32.Parse(Console.ReadLine());

                  Console.WriteLine("Enter second number for multiply:");
                  secondNum = Int32.Parse(Console.ReadLine());

                  result = firstNum * secondNum;
                  Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, result);
                   break;
                   //end 
                  default:
                  Console.WriteLine("Unrecogzied operator/command entered.");
                   break;
                  }   //End of switch statements.
                  Console.WriteLine("Please enter a new command: add/subtract/multiply/exit:");
           }
           }
           }
           }
