
public class CalciString
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter operation: ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "add":
                Console.WriteLine(n1 + n2);
                break;

            case "sub":
                Console.WriteLine(n1 - n2);
                break;

            case "mul":
                Console.WriteLine(n1 * n2);
                break;

            case "div":
                Console.WriteLine(n1 / n2);
                break;

            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}
