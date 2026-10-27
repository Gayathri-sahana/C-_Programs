using System;

class Country
{
    public string countryName;
    public Country(string name)
    {
        countryName = name;
    }

    public virtual void Capital()
    {
        Console.WriteLine("Capital");
    }

    public virtual void Language()
    {
        Console.WriteLine("Language");
    }
}

class India : Country
{
    public India() : base("India")
    {
    }

    public override void Capital()
    {
        Console.WriteLine("Capital of " + countryName + ": New Delhi");
    }

    public override void Language()
    {
        Console.WriteLine("Language: Hindi and English");
    }
}

class USA : Country
{
    public USA() : base("USA")
    {
    }

    public override void Capital()
    {
        Console.WriteLine("Capital of " + countryName + ": Washington, D.C.");
    }

    public override void Language()
    {
        Console.WriteLine("Language: English is the most widely spoken");
    }
}

class CountryProgram
{
    public static void Run()
    {
        India i = new India();
        USA u = new USA();

        i.Capital();
        i.Language();

        u.Capital();
        u.Language();

    }
}