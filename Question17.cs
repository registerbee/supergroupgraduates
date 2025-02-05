//The answer for question 17 = YES.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var shelf = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // Count the frequency of each book count
        var frequencies = shelf.GroupBy(x => x).Select(g => g.Count()).ToList();

        // Find the GCD of all frequencies
        int gcd = frequencies[0];
        foreach (int freq in frequencies)
        {
            gcd = GCD(gcd, freq);
        }

        // If GCD is greater than 1, it's possible to organize the books
        if (gcd > 1)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }

    // Helper function to calculate the GCD of two numbers
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
