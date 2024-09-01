using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine().Replace(" ", "").ToLower();

        string reversedString = new string(inputString.Reverse().ToArray());

        if (inputString == reversedString)
        {
            Console.WriteLine("It's a palindrome.");
        }
        else
        {
            Console.WriteLine("It's not a palindrome.");
        }
    }
}
