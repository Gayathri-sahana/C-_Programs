using System;

class MulDiv_Delegate
{
    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static int Divide(int x, int y)
    {
        return x / y;
    }

    public delegate int MyDelegate(int num1, int num2);

    static void Main()
    {
        MyDelegate d = new MyDelegate(Multiply);

        int result = d(10, 5);
        Console.WriteLine("Multiplication: " + result);

        d = Divide;

        result = d(10, 5);
        Console.WriteLine("Division: " + result);
    }
}
