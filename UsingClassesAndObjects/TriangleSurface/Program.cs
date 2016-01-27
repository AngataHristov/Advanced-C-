// Problem 4. Triangle surface
// 
// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurface
{
    public static double CalcAreaBySideAndAltitude(double side, double altitude)
    {
        double area = (double)side * altitude / 2;
        return area;
    }
    public static double CalcAreaByThreeSides(double sideOne, double sideTwo, double sideThree)
    {
        double p = (double)(sideOne + sideTwo + sideThree) / 2;
        double area = (double)Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree));
        return area;
    }
    public static double CalcAreaByTwoSidesAndAngle(double sideOne, double sideTwo, double angle)
    {
        double area = (double)(sideOne * sideTwo * Math.Sin(angle)) / 2;
        return area;
    }
    public static void Main()
    {
        Console.Write("Enter side a:");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side b:");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter side c:");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Enter altitude:");
        double h = double.Parse(Console.ReadLine());

        Console.Write("Enter angle:");
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("The area is:{0}", CalcAreaBySideAndAltitude(a, h));
        Console.WriteLine("The area is:{0}", CalcAreaByThreeSides(a, b, c));
        Console.WriteLine("The area is:{0}", CalcAreaByTwoSidesAndAngle(a, b, angle));
        Console.WriteLine();
    }
}
