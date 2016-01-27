
using System;

enum Colors
{
    red,
    yellow,
    blue
}
class Demo
{
    static void Main()
    {
        Student someStudent = new Student();
        someStudent.firstName = "Pesho";
        someStudent.lastName = "Ivanov";
        someStudent.age = 25;
        Student anotherStudent = new Student();
        anotherStudent.firstName = "Petq";
        anotherStudent.lastName = "Hristova";
        anotherStudent.age = 20;

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(Console.BackgroundColor);
        Colors myColor = Colors.blue;

        int[] number = new int[5];
        string text = string.Join(",", number);
        Console.WriteLine(text);
    }
}
class Student
{
    public string firstName;
    public string lastName;
    public int age;
}
