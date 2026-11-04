using System;

static class StringExtension
{
    public static void First_Name(this string name)
    {
        string[] words = name.Split(' ');
        Console.WriteLine("First Name: " + words[0]);
    }

    public static void Middle_Name(this string name)
    {
        string[] words = name.Split(' ');
        if (words.Length > 2)
        {
            Console.WriteLine("Middle Name: " + words[1]);
        }
    }

    public static void Last_Name(this string name)
    {
        string[] words = name.Split(' ');
        Console.WriteLine("Last Name: " + words[words.Length - 1]);
    }
}

class FirstLastNameWithoutReturn
{
    public static void Run()
    {
        string name1 = "Gayathri Sahana M";

        name1.First_Name();
        name1.Middle_Name();
        name1.Last_Name();
    }
}