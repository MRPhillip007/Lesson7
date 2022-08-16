using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

class Homework
{
    static void Main()
    {
        Console.WriteLine(SortInputStringByAlphabet("hello"));
        Console.WriteLine(Compare("Hello", "World"));
        char[] result = Duplicate("HheEEeeldfsdfsdfsdllo");
        foreach (char c in result)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        Analyze("jafd%*6549273645GHdskh|gsdgh");
    }

    static string SortInputStringByAlphabet(string str) // hello - > ehllo
    {
        char[] strCharsArray = str.ToCharArray();

        for (int i = 1; i < strCharsArray.Length; i++)
        {
            for (int j = 0; j < strCharsArray.Length - 1; j++)
            {
                int result = strCharsArray[j].CompareTo(strCharsArray[j + 1]);

                if (result > 0)
                {
                    char temp = strCharsArray[j];
                    strCharsArray[j] = strCharsArray[j + 1];
                    strCharsArray[j + 1] = temp;
                }
                
            }
        }
        return String.Join("", strCharsArray);
    }

    static char[] Duplicate(string str)
    {
        char[] chars = str.ToLower().ToCharArray();
        char[] result = new char[str.Length];

        for (int i = chars.Length -1; i >= 0; i--)
        {
            for (int j = i-1; j >=0 ; j--)
            {
                if (chars[i] == chars[j])
                {
                    result[i] = chars[j];
                }
            }
        }
        return result;

    }
    static bool Compare(string str1, string str2)
    {
        bool result = false;
        if (str1.Length == str2.Length)
        {
            foreach(char first in str1)
            {
                foreach(char second in str2)
                {
                    result = first == second ? true : false;
                }
            }
            return result;
        }
        return false;
    }

    static void Analyze(string str)
    {
        int specialChar = 0, digits = 0, alphabeticChars = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsLetter(str[i]))
            {
                alphabeticChars++;
            }
            if (Char.IsDigit(str[i]))
            {
                digits++;
            }
            if (!Char.IsLetterOrDigit(str[i]))
            {
                specialChar++;
            }
        }

        Console.WriteLine($"string: {str} has: \n\t {alphabeticChars} alphabetic Chars \n\t {digits} digits \n\t {specialChar} special characters");
    }
}