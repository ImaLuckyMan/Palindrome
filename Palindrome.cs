using System;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            IsPalindrome("racecar");
            IsPalindrome("cat");
            IsPalindrome("mom");
            IsPalindrome("tacocat");
        }

        public static void IsPalindrome(string input)
        {  
            bool isPal = true;
            
            if ( input == "" || input == null)
            {
                isPal = false;
            }
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPal = false;
                }
                
            }
            Console.WriteLine(isPal); 
        }

    }
}
