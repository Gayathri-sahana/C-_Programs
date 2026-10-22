
public class Interview
{
    public static void Run()
    {
        Console.Write("Enter yourAptitude mark: ");
        int apti = Convert.ToInt32(Console.ReadLine());

        if (apti > 70)
        {
            Console.Write("Enter yourTechnical mark: ");
            int tech = Convert.ToInt32(Console.ReadLine());

            if (tech > 80)
            {
                Console.Write("Enter your HR-round mark: ");
                int hr = Convert.ToInt32(Console.ReadLine());

                if (hr > 80)
                {
                    int total = apti + tech + hr;

                    Console.WriteLine("Total = " + total);
                    Console.WriteLine("Lets do a Salary prediction based on your total marks");

                    if (total >= 280 && total <= 300)
                    {
                        Console.WriteLine("Salary = 25K");
                    }
                    else if (total >= 250 && total < 280)
                    {
                        Console.WriteLine("Salary = 20K");
                    }
                    else if (total >= 230 && total < 250)
                    {
                        Console.WriteLine("Salary = 15K");
                    }
                    else
                    {
                        Console.WriteLine("Not eligible for salary prediction as your total marks are less than 230");
                    }
                }
                else
                {
                    Console.WriteLine("Not selected in HR round your mark is below 80");
                }
            }
            else
            {
                Console.WriteLine("Not selected in Technical round your mark is below 80");
            }
        }
        else
        {
            Console.WriteLine("Not selected in Aptitude round your mark is below 70");
        }
    }
}