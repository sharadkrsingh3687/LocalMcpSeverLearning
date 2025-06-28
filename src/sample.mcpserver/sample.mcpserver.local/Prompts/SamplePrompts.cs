using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerPromptType]
public static class SamplePrompts
{
    [McpServerPrompt(nameof = "factorial_prompt"), Description("Calculate the factorial of a number.")]
    public static string FactorialPrompt(int number)
    {
        return $"Calculate the factorial of {number}.";
    }

    [McpServerPrompt(nameof = "find_primenumber_prompt"), Description("Find the Prime number between two numbers.")]
    public static string FindPrimeNumberPrompt(long start, long end)
    {
        return $"Find all prime numbers between {start} and {end}.";
    }
}