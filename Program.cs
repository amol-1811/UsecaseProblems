using System;

public class EmployeeWage
{
    public static void Main(string[] args)
    {
        const int WAGE_PER_HOUR = 20;
        const int FULL_DAY_HOURS = 8;
        const int PART_TIME_HOURS = 4;
        const int WORKING_DAYS_PER_MONTH = 20;

        int totalWorkingDays = 0;
        int totalWorkingHours = 0;
        int monthlyWage = 0;

        for (int day = 1; day <= WORKING_DAYS_PER_MONTH; day++)
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
                default: 
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