using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a string to check if it's a palindrome of odd length if you want to exit enter empty string :");
            string input = Console.ReadLine();
            
            if (string.IsNullOrEmpty(input))
                break;
            bool isAccepted = IsOddLengthPalindrome(input);

            if (isAccepted)
                Console.WriteLine("The string is a palindrome of odd length. Accepted!");
            else
                Console.WriteLine("The string is NOT a palindrome of odd length. Rejected!");
        }    
        }

    public static bool IsOddLengthPalindrome(string s)
    {
        
        if (s.Length % 2 == 0)
            return false; 
 
        Stack<char> stack = new Stack<char>();
        int mid = s.Length / 2; 
        
        for (int i = 0; i < mid; i++)
        {
            stack.Push(s[i]);
        }

        
        for (int i = mid + 1; i < s.Length; i++)
        {
            char top = stack.Pop();
            if (top != s[i]) 
                return false;
        }

        return stack.Count == 0;
    }
}