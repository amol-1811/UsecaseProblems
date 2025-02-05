using System;

class Program
{
    public static void Main(string[] args)
    {
        
        Random random = new Random();
        int attendanceCheck = random.Next(0, 2);

        if (attendanceCheck == 0)
        {
            Console.WriteLine("Employee is Absent.");
        }
        else
        {
            Console.WriteLine("Employee is Present.");
        }

        Console.ReadLine();
    }
}