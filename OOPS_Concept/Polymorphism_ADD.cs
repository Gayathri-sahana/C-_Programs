using System;

class Addition
{
    public void Add(string a, string b)
    {
        Console.WriteLine("String Addition: " + a + b);
    }

    public void Add(int a, int b)
    {
        Console.WriteLine("Integer Addition: " + (a + b));
    }

    public void Add(double a, double b)
    {
        Console.WriteLine("Double Addition: " + (a + b));
    }
}

class Polymorphism_ADD
{
    public static void Run()
    {
        Addition a = new Addition();

        a.Add("Hello ", "World");
        a.Add(10, 20);
        a.Add(10.5, 20.5);
    }
}