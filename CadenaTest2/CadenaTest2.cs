using System;

class CadenaTest2 
{
    static void Main()
    {
        try 
        {
            PalindromeChecker checker = new PalindromeChecker();
            while(true)
            {
                Console.WriteLine("\n Enter a phrase or word to check if it's a palindrome (or type 'exit' to exit):");
                string input = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. You must enter a text string.");
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                bool result = checker.IsPalindrome(input);
                Console.WriteLine($"Is \"{input}\" a palindrome? {result}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
