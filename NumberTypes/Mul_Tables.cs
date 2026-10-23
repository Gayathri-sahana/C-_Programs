public class Mul_Tables
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to generate multiplication table: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("/n----------------Multiplication Table--------------");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " * "+ i + " = " + (n*i));
        }
    }
}
