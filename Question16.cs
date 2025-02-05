//The answer for question 16 =  zA^b8G@e2Jh*Kwl!mOpQxR7yVt1CfS3uD9iWz&Yx0PkLv6ShqN^Tb4Ra+Oz%gFj .
using System;
using System.Text;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        bool isUpper = true;

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                if (isUpper)
                {
                    result.Append(char.ToUpper(c));
                }
                else
                {
                    result.Append(char.ToLower(c));
                }
                isUpper = !isUpper;
            }
            else
            {
                result.Append(c);
            }
        }

        Console.WriteLine(result.ToString());
    }
}
