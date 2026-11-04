using System;

class WithoutMultiThreading
{
    static void Registration()
    {
        Console.WriteLine("Staff 1: Student Registration Started");
        Console.WriteLine("Staff 1: Registration Completed");
    }

    static void FeeCollection()
    {
        Console.WriteLine("Staff 2: Fee Collection Started");
        Console.WriteLine("Staff 2: Fee Collection Completed");
    }

    static void StudentEnquiry()
    {
        Console.WriteLine("Staff 3: Student Enquiry Started");
        Console.WriteLine("Staff 3: Student Enquiry Completed");
    }

    static void Main()
    {
        Registration();
        FeeCollection();
        StudentEnquiry();

        Console.WriteLine("Main method is also running");
    }
}
