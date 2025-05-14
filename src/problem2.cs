using System;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a string to check if it matches the pattern 0^n 1^n 0^n 1^n if you want to exit click an empty string:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;

            bool isAccepted = TuringMachineRecognize(input);

            if (isAccepted)
                Console.WriteLine("The string matches the pattern 0^n 1^n 0^n 1^n. Accepted!");
            else
                Console.WriteLine("The string doesn;t match the pattern 0^n 1^n 0^n 1^n. Rejected!");
        }
    }
    public static bool TuringMachineRecognize(string s)
    {
        
        if (s.Length % 4 != 0)
            return false; 

        if (s.Length == 0)
            return true;
        
        int n = s.Length / 4;

        
        // First segmenف check: 0^n 
        for (int i = 0; i < n; i++)
        {
            if (s[i] != '0')
                return false; 
        }

        // Second segment check: 1^n 
        for (int i = n; i < 2 * n; i++)
        {
            if (s[i] != '1')
                return false; 
        }

        // Third segment check: 0^n 
        for (int i = 2 * n; i < 3 * n; i++)
        {
            if (s[i] != '0')
                return false;
        }

        // Fourth segment check: 1^n
        for (int i = 3 * n; i < 4 * n; i++)
        {
            if (s[i] != '1')
                return false; 
        }

        
        return true;
    }
}