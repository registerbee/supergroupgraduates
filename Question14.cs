//The answer for 14 = For both inputs: 1 → "YES" 132651201231 → "YES"./
using System;

class Program
{
    static void Main()
    {
        int power = int.Parse(Console.ReadLine());
        
        double cubeRoot = Math.Pow(power, 1.0 / 3);
        
        if (cubeRoot == Math.Floor(cubeRoot))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
