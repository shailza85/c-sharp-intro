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
Console.WriteLine("Please enter your name...");
        // Assign variable 'userName' to a value entered by the user.
            string userName = Console.ReadLine();
            //Show the user we have collected the name.
            Console.WriteLine("You have entered:"+userName);
            //Instead of using concatenantion operator...
            //We can use string interpolation (placeholders) to embed values in a string.
            Console.WriteLine("Hey {0}, you are looking great today!", userName);
    
        }
    }
}
