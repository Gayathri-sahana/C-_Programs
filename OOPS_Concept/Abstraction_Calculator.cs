abstract class CAlculator
{
    public abstract void Add(int a, int b);

    public abstract void Sub(int a, int b);

    public void Mul(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }

    public void Div(int a, int b)
    {
        Console.WriteLine("Division: " + (a / b));
    }
}

class MyCalculator : CAlculator
{
    public override void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public override void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }
}

class Abstraction_Calculator
{
    public static void Run()
    {
        MyCalculator c = new MyCalculator();
       
        c.Add(10, 5);
        c.Sub(10, 5);
        c.Mul(10, 5);
        c.Div(10, 5);
    }
}

// Output:
// Addition: 15
// Subtraction: 5
// Multiplication: 50
// Division: 2
