using System;

public class EmployeeWage
{
    public static void Main(string[] args)
    {
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOURS = 8;
        const int PART_TIME_HOURS = 8;

        Random random = new Random();
        int attendanceCheck = random.Next(0, 3); 
        int dailyWage = 0;
        if (attendanceCheck == 1) 
        {
            dailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
        }
        else if (attendanceCheck == 2) 
        {
            dailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
        }

        if (attendanceCheck == 0)
        {
            Console.WriteLine("Employee is Absent. Daily Wage: 0");
        }
        else if (attendanceCheck == 1)
        {
            Console.WriteLine($"Employee is Present Full Time. Daily Wage: {dailyWage}");
        }
        else
        {
            Console.WriteLine($"Employee is Present Part Time. Daily Wage: {dailyWage}");
        }

        Console.ReadLine();
    }
}