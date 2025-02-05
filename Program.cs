using System;

public class EmployeeWage
{
    public static void Main(string[] args)
    {
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOURS = 8;

        Random random = new Random();
        int attendanceCheck = random.Next(0, 2); 

        int dailyWage = 0;
        if (attendanceCheck == 1) 
        {
            dailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
        }

        if (attendanceCheck == 0)
        {
            Console.WriteLine("Employee is Absent. Daily Wage: 0");
        }
        else
        {
            Console.WriteLine($"Employee is Present. Daily Wage: {dailyWage}");
        }

        Console.ReadLine();
    }
}