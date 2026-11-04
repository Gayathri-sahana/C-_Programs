using System;

static class StringExtensions
{
    public static int CountWords(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        string[] words = text.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return words.Length;
    }

    public static int CountVowels(this string text)
    {
        int count = 0;

        foreach (char ch in text)
        {
            if ("aeiouAEIOU".Contains(ch))
            {
                count++;
            }
        }

        return count;
    }
}

class Count
{
    public static void Run()
    {
        string name = "UPS Training Session on CSharp";

        int wordCount = name.CountWords();
        int vowelCount = name.CountVowels();

        Console.WriteLine("Text: " + name);
        Console.WriteLine("Word Count: " + wordCount);
        Console.WriteLine("Vowel Count: " + vowelCount);
    }
}