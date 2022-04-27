using System;
using System.Text.RegularExpressions;

namespace PalindromeChallenge
{
    class Program
    {
        static void Palindrome()
        {
            string input = Console.ReadLine();
            string regexInput = "";
            regexInput = Regex.Replace(input, @"\s+", "");
            string output = string.Empty;
                if (regexInput != null)
                {
                    for (int i = regexInput.Length - 1; i >= 0; i--)
                    {
                        output += regexInput[i];
                    }

                    if (regexInput == output)
                    {
                        Console.WriteLine("Input is a palindrome! \n Input = {0}\n Output = {1}", regexInput, output);
                    }
                    else
                    {
                        Console.WriteLine("Input is NOT a palindrome! \n Input = {0}\n Output = {1}", regexInput, output);
                    }
                }         
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word or number to see if it is a palindrome! ");

            Palindrome();
  
        }
        
        
        
    }
}
