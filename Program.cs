using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user.
           Console.WriteLine("Please type: (add/subtract/exit)");
           string command;
           //Accept commands;
           while((command = Console.ReadLine()) != "exit")
           {
               int result;
               if(command =="add")
               {
                   Console.WriteLine("Enter the first number to add:");
                   int firstNum = CollectIntFromUser();
                   Console.WriteLine("Enter the second number to add:");
                   int secondNum = CollectIntFromUser();
                   result = Addition(firstNum, secondNum);
                   Console.WriteLine("The result is: {0}", result); 
               }

                else if(command =="subtract")
               {
                   Console.WriteLine("Enter the first number to subtract:");
                   int firstNum = CollectIntFromUser();
                   Console.WriteLine("Enter the second number to subtract:");
                   int secondNum = CollectIntFromUser();
                   result = Subtraction (firstNum, secondNum);
                   Console.WriteLine("The result is: {0}", result); 
               }
               else 
               {
                 Console.WriteLine("Invalid command, please try again.");  
               }
                 Console.WriteLine("Please enter a command: (add/subtract/exit)");
           } //End of while loop.
          }  
            static int Addition (int num1, int num2)  
            {
                return num1 + num2;
            } 

            static int Subtraction (int num1, int num2)  
            {
                return num1 - num2;
            }   

            static int CollectIntFromUser()
            {
                int intValue = 0;
                bool error = true;
                while (error == true)
                {
                string userValue = Console.ReadLine();
                try  //I wrap potentially falling code in a try- this will prevent an unhandled exception (fatal error of program).
                {
                    intValue = int.Parse(userValue); //Attempt to convert the String...
                    error = false;
                    //Ends execution of method, and passes the value back.
                }
                catch(Exception exception)
                {       //we use catch to decide what happens if try has an error!
                    Console.WriteLine("Invalid value entered. Please enter a number.");
                    Console.WriteLine(exception.Message);
                    //This exception has its own error message-helpful to know what is failing..
                }
                }// End fo while loop.
                return intValue; //End the execution of method, and passses the value back.
            }            
           }
           }
        
           
