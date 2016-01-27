using System;

class Period
{
    public static void GetMounth(int month)
    {
        string[] Months =
            {
             "Jan",
             "Febr",
             "March",
             "Apr",
             "May",
             "June",
             "July",
             "August",
             "September",
             "October",
             "November",
             "December"
            };
        Console.Write(Months[month - 1]);
    }
    public static void PrintPeriod(int FirstMonth, int SecondMonth)
    {
        int period = SecondMonth - FirstMonth;
        if (period < 0)
        {
            period += 12;
        }
        Console.Write("From ");
        GetMounth(FirstMonth);
        Console.Write(" to ");
        GetMounth(SecondMonth);
        Console.Write(" there are {0} months.",period);
    }
    public static void Main()
    {
        PrintPeriod(3, 7);
        Console.WriteLine();
    }
}

