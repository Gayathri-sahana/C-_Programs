interface IAddSub
{
    void Add(int a, int b);
    void Sub(int a, int b);
}

interface IMulDiv
{
    void Mul(int a, int b);
    void Div(int a, int b);
}

class CaLculator : IAddSub, IMulDiv
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

    public void Mul(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }

    public void Div(int a, int b)
    {
        Console.WriteLine("Division: " + ((double)a / b));
    }
}

class Interface_Calculator
{
    public static void Run()
    {
        CaLculator c = new CaLculator();

        c.Add(10, 5);
        c.Sub(10, 5);
        c.Mul(10, 5);
        c.Div(10, 5);
    }
}