using System;

public class EmployeeWage
{
    public static void Main(string[] args)
    {
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOURS = 8;
        const int PART_TIME_HOURS = 4;
        const int MAX_WORKING_HOURS = 100;
        const int MAX_WORKING_DAYS = 20;

        int totalWorkingDays = 0;
        int totalWorkingHours = 0;
        int monthlyWage = 0;

        while (totalWorkingHours < MAX_WORKING_HOURS && totalWorkingDays < MAX_WORKING_DAYS)
        {
            Random random = new Random();
            int attendanceCheck = random.Next(0, 3); 

            switch (attendanceCheck)
            {
                case 1: 
                    totalWorkingHours += FULL_DAY_HOURS;
                    break;
                case 2: 
                    totalWorkingHours += PART_TIME_HOURS;
                    break;
            }

            if (attendanceCheck != 0)
            {
                totalWorkingDays++;
            }
        }

        monthlyWage = totalWorkingHours * WAGE_PER_HOUR;

        Console.WriteLine($"Total Working Days: {totalWorkingDays}");
        Console.WriteLine($"Total Working Hours: {totalWorkingHours}");
        Console.WriteLine($"Monthly Wage: {monthlyWage}");

        Console.ReadLine();
    }
}