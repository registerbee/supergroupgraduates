//The answer for question 15 = [123347, 789012].
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var outcomes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var seen = new HashSet<int>();
        var duplicates = new List<int>();

        foreach (var outcome in outcomes)
        {
            if (seen.Contains(outcome))
                duplicates.Add(outcome);
            else
                seen.Add(outcome);
        }

        Console.WriteLine($"[{string.Join(", ", duplicates)}]");
    }
}
