using System;

class Period
{
    public static string GetMonth(int month)
    {
        string MonthName;
        switch (month)
        {
            case 1:
                MonthName = "January";
                break;
            case 2:
                MonthName = "February";
                break;
            case 3:
                MonthName = "March";
                break;
            case 4:
                MonthName = "April";
                break;
            case 5:
                MonthName = "May";
                break;
            case 6:
                MonthName = "June";
                break;
            case 7:
                MonthName = "July";
                break;
            case 8:
                MonthName = "August";
                break;
            case 9:
                MonthName = "September";
                break;
            case 10:
                MonthName = "October";
                break;
            case 11:
                MonthName = "November";
                break;
            case 12:
                MonthName = "December";
                break;
            default:
                Console.WriteLine("Invalid input!");
                return null;
        }
        return MonthName;
    }
    public static void SayPeriod(int StartMonth, int EndMonth)
    {
        int period = EndMonth - StartMonth;
        if (period < 0)
        {
            period += 12;
        }
        Console.WriteLine("There are {0} months perid prom {1} to {2}.", period, GetMonth(StartMonth), GetMonth(EndMonth));
    }
    public static void Main()
    {
        Console.Write("Enter the first month (1~12):");
        int FirstMonth = int.Parse(Console.ReadLine());

        Console.Write("Enter the second month (1~12):");
        int SecondMonth = int.Parse(Console.ReadLine());

        SayPeriod(FirstMonth, SecondMonth);
    }
}

