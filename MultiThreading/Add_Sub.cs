using System;
using System.Threading;

class CalcThreadAdd
{
    public static void Add(int a, int b)
    {
        Console.WriteLine("Add Thread Name: " + Thread.CurrentThread.Name);
        Console.WriteLine("Add start " + (a + b));
        Thread.Sleep(3000);
        Console.WriteLine("Add end");
    }
}

class CalcThreadSub
{
    public static void Sub(int a, int b)
    {
        Console.WriteLine("Sub start " + (a - b));
        Thread.Sleep(3000);
        Console.WriteLine("Sub end");
    }
}

class CalcThread
{
    public static void Run()
    {
        Thread.CurrentThread.Name = "Main Thread";

        CalcThreadSub c = new CalcThreadSub();

        Thread t1 = new Thread(() => CalcThreadAdd.Add(12, 56));
        Thread t2 = new Thread(() => CalcThreadSub.Sub(23, 7));

        t1.Name = "Addition Thread";
        t2.Name = "Subtraction Thread";

        t1.Start();
        t2.Start();

        Console.WriteLine("Current Thread: " + Thread.CurrentThread.Name);
    }
}