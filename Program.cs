using System.ComponentModel;

namespace ALBRIGHT_ASSIGNMENT_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MSSA CCAD16 - CHRIS ALBRIGHT
            //ASSIGNMENT 5.2
            //WEEK 5 - 03DEC2024

            // Assignment 5.2.1 ---------------------------------------------------------------------------------------------

            // Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a
            // maximal substring consisting of non-space characters only.

            Console.WriteLine("Assignment 5.2.1 ----------------------------------------------------------------------------");
            Console.WriteLine("Last Word Length Checker:");
            char hold1 = 'y';
            do
            {
                Console.WriteLine("\nEnter your text string 's':");
                string inputString = Console.ReadLine();
                string lastWord = GetLastWord(inputString); 
                Console.WriteLine($"\nLast word is '{lastWord}' with length of ({lastWord.Length})");
                Console.WriteLine($"\nWant to go again? type y/n");
                hold1 = Convert.ToChar(Console.ReadLine());
            }
            while (hold1 == 'y');

            // Assignment 5.2.2 ---------------------------------------------------------------------------------------------

            // Write a program in C# Sharp to print the first n natural number using recursion.

            Console.WriteLine("\nAssignment 5.2.2 ----------------------------------------------------------------------------");
            Console.WriteLine("First (n) Natural Numbers w/ recursion:");
            char hold2 = 'y';
            do
            {
                Console.WriteLine("\nEnter (n) for natural number set 'N' print:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                PrintNaturalNumbers(n);
                Console.WriteLine($"\nWant to go again? type y/n");
                hold2 = Convert.ToChar(Console.ReadLine());
            }
            while (hold2 == 'y');

            // Assignment 5.2.3 ---------------------------------------------------------------------------------------------

            // Write a program in C# Sharp to print numbers from n to 1 using recursion.

            Console.WriteLine("\nAssignment 5.2.3 ----------------------------------------------------------------------------");
            Console.WriteLine("Print (n) to 1 w/ recursion:");
            char hold3 = 'y';
            do
            {
                Console.WriteLine("\nEnter (n) for reverse natural number set 'N' print:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                ReversePrintNaturalNumbers(n);
                Console.WriteLine($"\nWant to go again? type y/n");
                hold3 = Convert.ToChar(Console.ReadLine());
            }
            while (hold3 == 'y');

            // Assignment 5.2.4 ---------------------------------------------------------------------------------------------

            // Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.

            Console.WriteLine("\nAssignment 5.2.4 ----------------------------------------------------------------------------");
            Console.WriteLine("Palindrome check w/ recursion:");
            char hold4 = 'y';
            do
            {
                Console.WriteLine("\nEnter your string for recursive palandromic check:");
                string inputString = Console.ReadLine();
                if(IsPalindrome(inputString) == true)
                {
                    Console.WriteLine($"\n'{inputString}' is a palindrome!");
                }
                else
                {
                    Console.WriteLine($"\n'{inputString}' is NOT a palindrome...");
                }
                Console.WriteLine($"\nWant to go again? type y/n");
                hold4 = Convert.ToChar(Console.ReadLine());
            }
            while (hold4 == 'y');
            Console.WriteLine("\n\nGoodbye!");
        }

        //---------------------------------------------------METHODS---------------------------------------------------------

        //5.2.1 Method:
        public static string GetLastWord(string inputString)
        { 
            char[] punctArray = {'.', ',', '!', '?', ';', ':'};
            inputString = inputString.Trim(); //Trims trailing spaces at the end of the string
            inputString = inputString.TrimEnd(punctArray); // Trims punctuation
            int lastSpaceIndex = inputString.LastIndexOf(' '); // Finds last space in the string
            if (lastSpaceIndex == -1) // If does not exist
            {
                return inputString; // No space, all one word
            }
            return inputString.Substring(lastSpaceIndex + 1);
        }
        //5.2.2 Method:
        public static void PrintNaturalNumbers(int n)
        {
            if (n < 1)
            {
                return;
            }
            PrintNaturalNumbers(n - 1); //creates stack of pNN...bottom:pNN(n),pNN(n-1),...,pNN(2),pNN(1) and pNN(0) "pops" a return
            Console.WriteLine(n);
        }
        //5.2.3 Method:
        public static void ReversePrintNaturalNumbers(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Console.WriteLine(n);
            ReversePrintNaturalNumbers(n - 1); // moves through sequentially, no big stack.
        }
        //5.2.4 Method:
        public static bool IsPalindrome(string inputString)
        { 
            if (inputString.Length <= 1) // single character string catch
            {
                return true;
            }
            if (inputString[0] != inputString[inputString.Length - 1]) // check first and last character
            {
                return false;
            }
            return IsPalindrome(inputString.Substring(1,inputString.Length - 2)); // cut first and last character in string and call again
        }
    }
}
