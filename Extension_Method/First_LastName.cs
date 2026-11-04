using System;

static class String_Extensions
{
    public static string FirstName(this string name)
    {
        string[] words = name.Split(' ');
        return words[0];
    }

    public static string MiddleName(this string name)
    {
        string[] words = name.Split(' ');
        if (words.Length > 2)
        {
            return words[1];
        }
        return string.Empty;
    }

    public static string LastName(this string name)
    {
        string[] words = name.Split(' ');
        return words[words.Length - 1];
    }
}

class First_LastName
{
    public static void Run()
    {
        string name = "Gayathri Sahana M";

        Console.WriteLine("First Name: " + name.FirstName());
        Console.WriteLine("Middle Name: " + name.MiddleName());
        Console.WriteLine("Last Name: " + name.LastName());
    }
}