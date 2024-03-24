using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string value = "This  is   a   test    string.";
        Console.WriteLine(CollapseSpaces(value));
    }

    static string CollapseSpaces(string value)
    {
        return Regex.Replace(value, @"\s+", " ").Trim();
    }
}
