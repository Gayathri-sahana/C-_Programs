class Birds
{
    public string name;

    public Birds(string name)
    {
        this.name = name;
    }

    public virtual void Make_Sound()
    {
        Console.WriteLine("Bird makes a sound");
    }
}

class Parrot : Birds
{
    public Parrot() : base("Parrot")
    {
    }

    public override void Make_Sound()
    {
        Console.WriteLine(name + " says: Squawk");
    }
}

class Sparrow : Birds
{
    public Sparrow() : base("Sparrow")
    {
    }

    public override void Make_Sound()
    {
        Console.WriteLine(name + " says: Chirp Chirp");
    }
}

class BirdsSound
{
    public static void Run()
    {
        Parrot p = new Parrot();
        Sparrow s = new Sparrow();

        p.Make_Sound();
        s.Make_Sound();
    }
}