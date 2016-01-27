using System;

class Validation
{
    public static bool ValidateHours(int Hours)
    {
        bool result = (Hours > 0) && (Hours <= 12);
        return result;
    }
    public static bool ValidateMinutes(int Minutes)
    {
        bool result = (Minutes >= 0) && (Minutes <= 59);
        return result;
    }
    static void Main()
    {
        Console.WriteLine("What time is it?");
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);
        if (isValidTime)
        {
            Console.WriteLine("The time is {0}:{1}", hours, minutes);
        }
        else
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine();
        }
    }
}
