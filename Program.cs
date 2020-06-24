using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two slashes mark the begining of a singlr-line comment.
            //We are assigning a string value to a variable.
            string myName = "Shailza Sharma";
             /* We begin multi-line comments with forward-slash and asterisk...
             Used concatenantion operator to add variable value to text "Hello".
            ...and we end multi-line comments with an asterisk followed by a forward-slash */
            Console.WriteLine("Hello, " + myName);
           
        }
    }
}
