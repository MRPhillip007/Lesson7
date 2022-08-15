using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

class Homework
{
    static void Main()
    {
        Console.WriteLine(SortInputStringByAlphabet("hello")); 
    }

    static string SortInputStringByAlphabet(string str) // hello - > ehllo
    {
        char[] chars = str.ToCharArray();

        foreach (char c in chars)
            Console.Write(c + " ");
        Array.Sort(chars);

        return new string(chars);
    }

    enum CharactersAlphabetPosition
    {
        samePosition = 0,
        Before = -13,
        After = 25,
    }
}