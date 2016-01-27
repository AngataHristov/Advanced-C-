using System;
using System.Collections.Generic;
using System.Linq;

class MultiArr
{
    static void Main()
    {
        //int[,] numbers = new int[3, 4];
        //
        //Console.WriteLine(numbers.Rank); // "2" (two dimencional array)
        //
        //Console.WriteLine(numbers.Length); // "12" (number of the cells in array)
        //    
        //Console.WriteLine(numbers.GetLength(0)); // "3" (number of the rows in array)
        //
        //Console.WriteLine(numbers.GetLength(1)); // "4" (number of the columns in array)


        //int[] numbers = { 1, 2, 3, 4, 5, 6 }; 
        //int index = Array.BinarySearch(numbers, 4);
        //Console.WriteLine(index); // "3" (the position of "4") // за сортирани масиви// оптимизирано търсене - дели половината, маха едната част и т.н.

        //int[] numbers = { 5, 1, 8, 6, 3, 4 };
        //int index = Array.IndexOf(numbers, 8);
        //Console.WriteLine(index); // "2" - which is the position ot "8", if this number doesn't exist - returns "-1"
        //int index = Array.IndexOf(numbers, 8, 3); // търси от 3-я индекс ,нататък.

        //int[] numbers = { 5, 1, 8, 6, 3, 4, 8, 4 };
        //int index = Array.LastIndexOf(numbers, 8);
        //Console.WriteLine(index); // "6" - returns the last position of the selected number if there are more than one

        //int[] numbers = { 5, 1, 8, 6, 3, 4, 8, 4 };
        //int startIndex = 0;
        //while (true)
        //{
        //    int currentIndex = Array.IndexOf(numbers, 8, startIndex);
        //    if (currentIndex < 0)
        //    {
        //        Console.WriteLine("No intdexes");
        //        break;
        //    }
        //    Console.WriteLine(currentIndex);
        //    startIndex = currentIndex + 1;
        //}

        //int[] numbers = { 1, 2, 3 };
        //int[] anotherNumbers = new int[numbers.Length];
        //Array.Copy(numbers, anotherNumbers, numbers.Length);// копира първия масив във втория (с цялата дължина-...,numbers.lenght)

        //int[] numbers = { 1, 2, 3 };
        //Array.Reverse(numbers);

        //int[] numbers = { 1, 2, 3 };
        //Array.Clear(numbers, 0, numbers.Length);

        //Array someArr = Array.CreateInstance(typeof(int), 100, 100); // array 100x100 int

        //int[] numbers = { 5, 1, 8, 6, 3, 4 };
        //Array.Sort(numbers);

        //int[] numbers = { 5, 1, 8, 6, 3, 4 };
        //string result = string.Join(",", numbers);// Прави текст като комбинита отделните елементи от "numbers"
    }
}
