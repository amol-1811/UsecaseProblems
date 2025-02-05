using System;

public class EmployeeWage
{
    public static void Main(string[] args)
    {
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOURS = 8;
        const int PART_TIME_HOURS = 4;

        Random random = new Random();
        int attendanceCheck = random.Next(0, 3); 

        int dailyWage = 0;
        switch (attendanceCheck)
        {
            case 1: 
                dailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
                break;
            case 2: // Part Time
                dailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
                break;
            default: // Absent
                dailyWage = 0;
                break;
        }

        
        switch (attendanceCheck)
        {
            case 0:
                Console.WriteLine("Employee is Absent. Daily Wage: 0");
                break;
            case 1:
                Console.WriteLine($"Employee is Present Full Time. Daily Wage: {dailyWage}");
                break;
            case 2:
                Console.WriteLine($"Employee is Present Part Time. Daily Wage: {dailyWage}");
                break;
            default:
                Console.WriteLine("Invalid attendance check value.");
                break;
        }

        Console.ReadLine();
    }
}