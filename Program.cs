using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
         // Logical Operators.
         // OR will check the one value is true
         Console.WriteLine(true || true); // is OR
         Console.WriteLine(false || true); 
         Console.WriteLine(false || false); 

        // && will evaluate if both values are true.
         Console.WriteLine(true && true); 
         Console.WriteLine(false && true); 
         Console.WriteLine(false && false);

         // How does this work with different datatypes.
            //Console.WriteLine(true && 1); // It doesn't work.

            //Comparative operators...
            // "Equal to" check.
            Console.WriteLine(false == false); //True
            Console.WriteLine(true == false); //False
            Console.WriteLine(2.25 == 2.25); //True
            Console.WriteLine(2.25 == 3.14); //False
            //Console.WriteLine(3.14 == "3.14"); // cannot compare if there is two different data types
 
            // Greater Than operator.
            Console.WriteLine(6>7); // False
            Console.WriteLine(10>5); // True

            // Less than operator..
            Console.WriteLine(6<7); // True
            Console.WriteLine(10<5); // false

             // Greater Than equal to operator.
            Console.WriteLine(6>=7); // False
            Console.WriteLine(10>=5); // True

            // Less than equl to  operator..
            Console.WriteLine(6<=7); // True
            Console.WriteLine(10<=5); // false

            // Not equal operator.
             Console.WriteLine(false!=false); // false
             Console.WriteLine(true!=false); // true
              Console.WriteLine(5!=5); // false
              Console.WriteLine(5!=10); // true








        }
    }
}
