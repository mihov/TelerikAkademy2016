using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine((ReverseTheString(Console.ReadLine())));
    }
    public static string ReverseTheString(string s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }

        return sb.ToString();
    }

}
