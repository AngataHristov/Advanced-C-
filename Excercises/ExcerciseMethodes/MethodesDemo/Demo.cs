using System;

class Demo
{
    // public static void PrintFirstNNumbers()
    // {
    //     Console.Write("Enter number of the numbers: ");
    //     int n = int.Parse(Console.ReadLine());
    //     for (int i = 0; i <= n; i++)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }
    // 
    // public static void Main()
    // {
    //     PrintFirstNNumbers();
    // }

    // public static void PrintSign(int number)
    // {
    //     if (number>0)
    //     {
    //         Console.WriteLine("+");
    //     }
    //     else if (number<0)
    //     {
    //         Console.WriteLine("-");
    //     }
    //     else
    //     {
    //         Console.WriteLine("0");
    //     }
    // }
    // public static void Main()
    // {
    //     PrintSign(-2);
    // }

    // public static void Sum(int FirstNumber, int SecondNumber)
    // {
    //     Console.WriteLine(FirstNumber + SecondNumber);
    // }
    // public static void Main()
    // {
    //     Sum(5, 6);
    // }


    //public static void ProductOfThreeNumbersAndText(double FirstNumber, double SecondNumber, double ThirdNumber,char Text)
    //{
    //    Console.WriteLine(FirstNumber * SecondNumber * ThirdNumber);
    //    Console.WriteLine(Text);
    //}
    //public static void Main()
    //{
    //    ProductOfThreeNumbersAndText(4, 5, 6,'a');
    //}

    //public static void FindMaxNumber(int FirstNumber, int SecondNumber)
    //{
    //    int max = FirstNumber;
    //    if (SecondNumber > FirstNumber)
    //    {
    //        max = SecondNumber;
    //    }
    //    Console.Write(max);
    //}
    //public static void Main()
    //{
    //    FindMaxNumber(2, 8);
    //    Console.WriteLine();
    //}

    //public static void Print<T>(T number) // 
    //{
    //    Console.WriteLine(number);
    //}
    //public static void Main()
    //{
    //    Print<какъвто и да е тип обект!!!(string)(int)...> (...);
    //}

    // Незадължителни параметри
    // public static void PrintSum(int a, int b, int c = 0)
    // {
    //     Console.WriteLine(a + b + c);
    // }
    // public static void Name(string FirstName, string MiddleName="", string LastName="")
    // {
    //     Console.WriteLine(FirstName + " " + MiddleName + " " + LastName);
    // }
    // public static void Main()
    // {
    //     PrintSum(2, 3);
    //     PrintSum(2, 3, 4);
    //     Name("Pesho");
    //     Name("Pesho", "Peshov", "Peshovski");
    //     Name("Pesho", LastName: "Peshovski");
    // }

    // public static string FullName(string FirstName, string MiddleName = "", string LastName = "")
    // {
    //     string fullName = FirstName + " " + MiddleName + " " + LastName;
    //     return fullName;
    // }
    // public static void Main()
    // {
    //     string fullName = FullName("Pesho", LastName: "Peshovski");
    //     Console.WriteLine(fullName);
    // }

    // public static int Sum(int a, int b)
    // {
    //     int Sum = a + b;
    //     return Sum;
    // }
    // public static void Main()
    // {
    //     Console.Write("Enter a: ");
    //     int first = int.Parse(Console.ReadLine());
    // 
    //     Console.Write("Enter b: ");
    //     int second = int.Parse(Console.ReadLine());
    // 
    //     int sum = Sum(first, second);
    //     Console.WriteLine(sum);
    // }

    public static bool ArePositive(int[] numbers)
    {
        foreach (int number in numbers)
        {
            if (number < 0)
            {
                return false;
            }
        }
        return true;
    }
    public static int Sum(params int[] numbers) // с рarams даваме неограничение на масива   
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    public static void Main()
    {
        int[] numbers = new int[5] { 1, -2, 3, 4, 5 };
        Console.WriteLine("The numbers int the sequence are all positive: " + ArePositive(numbers));
        Console.WriteLine();
        Console.WriteLine(Sum(numbers));
    }

}
