using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char inputChar = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if ("aeiou".Contains(inputChar))
        {
            Console.WriteLine($"{inputChar} is a vowel.");
        }
        else if (Char.IsLetter(inputChar))
        {
            Console.WriteLine($"{inputChar} is a consonant.");
        }
        else
        {
            Console.WriteLine($"{inputChar} is not a valid letter.");
        }
    }
}
