using ModelContextProtocol.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;

[McpServerToolType]
public static class SampleTools
{
    [McpServerTool, Description("Calculate the factorial of a number.")]
    public static long Factorial(int number)
    {
        if (number < 0) throw new ArgumentException("Number must be non-negative.");
        if (number == 0 || number == 1) return 1;
        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
    
    [McpServerTool, Description("Find the Prime number between two numbers.")]
    public static long[] FindPrimeNumber(long start, long end)
    {
        if (start < 2) start = 2; // Prime numbers start from 2
        var primes = new List<long>();

        for (long number = start; number <= end; number++)
        {
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        return primes.ToArray();
    }

    private static bool IsPrime(long number)
    {
        if (number < 2) return false;
        if (number == 2) return true; // 2 is the only even prime number
        if (number % 2 == 0) return false; // Exclude even numbers greater than 2

        for (long i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}