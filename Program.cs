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
            //@link https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1

            //Show the user we have collected the name.
            Console.WriteLine("You have entered:"+userName);
            //Instead of using concatenantion operator...
            //We can use string interpolation (placeholders) to embed values in a string.
            //@link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine("Hey {0}, you are looking great today!", userName);
    
    //Let's play with strings!
    Console.WriteLine("makemeuppercase".ToUpper());
    Console.WriteLine("MAKEMELOWERCASE".ToLower());
    //Substring takes two arguments: 1)Starting character position  2) Number of characters to collect.
    Console.WriteLine("ABCDEFGHIJK".Substring(3,3));
    Console.WriteLine("XYZ".Length); //GET THE NUMBER OF CHARACTERS IN THE STRING.
        }
    }
}
