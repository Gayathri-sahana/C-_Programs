public class Pattern3
{
    public static void Run()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if(j%2 == 0){
                    Console.Write("0 ");
                }
                else{
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }
}
