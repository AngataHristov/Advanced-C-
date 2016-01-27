using System;
using System.Collections.Generic;
class Lists
{
    static void Main()
    {
        //List<int> intList = new List<int>();
        //for (int i = 0; i < 5; i++)
        //{
        //    intList.Add(i);
        //}

        int[] arr = new int[] { 1, 2, 3, 4 };
        List<int> intList = new List<int>();
        intList.AddRange(arr);
       // foreach (int item in arr)
       // {
       //     intList.Add(item);
       // }
        foreach (int item in intList)
        {
            Console.WriteLine(item);
        }
    }

}
