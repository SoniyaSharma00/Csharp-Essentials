using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO!");
            Console.WriteLine("Hello How are you?"); //This is the syntax for output in C#.
            Console.Write("This is"); // Console.WriteLine prints the output on the existing line and appends a new line after it.
            Console.Write(" C# tutorial");//while Console.Write prints the output but does not append a new line after it.
            Console.Write(" for students"); //hence Console.Write prints the next output in the same line.

            //now here are some examples on the data types in C#
            Console.WriteLine('b'); //this is a  character data type which is encoded with single cote because it is a literal.
            Console.WriteLine("Hello"); //this is a string data type which is encoded with double cote because it is a string.
            Console.WriteLine(5); //this is an integer data type which is encoded with no cotes because it is a number.
            Console.WriteLine(10.56790754m); //this is a decimal data type(floating type) which is used when when there is 28-29 digits.(m for decimal)
            Console.WriteLine(5.5f); //this is a float data type which is used when there is 6-9 digits.( for float)
            Console.WriteLine(5.5); //this is a double data type(floating type) which is used when there is 15-17 digits.(nothind or d for double)

        }
    }
}