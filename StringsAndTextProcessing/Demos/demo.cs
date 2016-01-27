using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

class demo
{
    //static void Main()
    //{
    // string text = "pesho";
    // Console.WriteLine(text.Length); // read only
    // Console.WriteLine(text[3]); // returns the chach in the index

    // string text = "You are so stupid!";
    // for (int i = 0; i < text.Length; i++)
    // {
    //     Console.WriteLine("text[{0:D2}] - {1}", i + 1, text[i]);
    // }

    // string text; - contains null, not empty. correct way: string text=string.empty;

    // string text = 42.ToString(); - convert everything to string
    // Console.WriteLine(text);  

    // List<int> numbers = new List<int>();
    // numbers.Add(1);
    // numbers.Add(2);
    // numbers.Add(3);
    // numbers.Add(4);
    // string numbersAsString = string.Join(",", numbers);
    // Console.WriteLine(numbersAsString);

    //int result = string.Compare("abc", "ABC", false); // result=-1  str1 is before str2

    // Console.WriteLine("Pesho"=="pesho" same like "Pesho".Equals("pesho")); // key sensitive

    //string result = string.Concat("pesho", " gosho"); same like result="pesho"+"gosho";
    //Console.WriteLine(result);

    // string text = "pesho";
    // int index = text.IndexOf("pes", ot koi index napred da tursi'po podrazbirane zapo4va ot na4aloto');
    // Console.WriteLine(index);
    // Console.WriteLine(index + "pes".Length - 1);

    // string text = "gosho pesho pesho ivan kiro pesho sasho";
    // int index = 0;
    // while (true)
    // {
    //     int found = text.IndexOf("pesho", index);
    //     if (found < 0)
    //     {
    //         break;
    //     }
    //     Console.WriteLine(found);
    //     index = found + 1;
    // }

    // string text = "pesho gosho";
    // string result = text.Substring(6);
    // Console.WriteLine(result + "  " + text.Substring(6, 3));

    // string text = "1 2 3,4!5      6@7 8";
    // string[] numbersAsText = text.Split(new char[] { ' ', ',', '!', '@' }, StringSplitOptions.RemoveEmptyEntries);
    // int[] numbers = new int[numbersAsText.Length];
    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     numbers[i] = int.Parse(numbersAsText[i]);
    // }

    // input: 1 2 3 4 5 6 7 
    // int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',', '!', '@' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); 

    // string text = "pesho";
    // string otherText = text.Replace("e", "i");
    // string newString = text.Replace("pe", "go")
    //     .Replace("sho", "ivan")
    //     .Replace("ivan","maria");
    // Console.WriteLine(otherText);
    // Console.WriteLine(newString);

    // string text = "pesho";   // .remove(index,length)
    // text = text.Remove(0, 2);
    // Console.WriteLine(text);

    // string text = "pesho";
    // string otherText = text.ToUpper(); //text.ToLower()
    // Console.WriteLine(otherText);

    // string text = "    pesho    ";
    // text = text.Trim();        // text.TrimEnd(); text.TrimStart();
    // Console.WriteLine(text);

    //  StringBuilder
    // StringBuilder result = new StringBuilder(); // moje da mu zadadem nachalen razmer
    // result.Append("a");
    // result.Append("a");
    // result.Append("a");
    // result.Append("a");
    // result.Insert(3, "c");
    // string text = result.ToString();
    // Console.WriteLine(text);
    // for (int i = 0; i < 10; i++)
    // {
    //     result.AppendLine("haskdk");
    // 
    // }
    // string otherText = result.ToString().Trim(); // NAKRAQ OSTAVQ EDNA PRAZNA LINQ, ZATOVA PARIM . Trim();
    // Console.WriteLine(otherText);
    // Console.WriteLine(result.Capacity);

    //     string text = "pesho";
    //     Console.WriteLine(Reverse(text));
    // }
    // public static string Reverse(string text)
    // {
    //     //    string result = string.Empty;
    //     StringBuilder result = new StringBuilder(text.Length);
    //     for (int i = text.Length - 1; i >= 0; i--)
    //     {
    //         //        result += text[i];
    //         result.Append(text[i]);
    //     }
    //     // return result;
    //     return result.ToString();
    // }

    // static string ExtractCapital(string text)
    // {
    //     StringBuilder result = new StringBuilder(text.Length);
    //     for (int i = 0; i < text.Length; i++)
    //     {
    //         if (char.IsUpper(text[i])) //text[i] > 'A' && text[i] < 'Z'
    //         {
    //             result.Append(text[i]);
    //         }
    //     }
    //     return result.ToString();
    // }
    // static void Main()
    // {
    //     Thread.CurrentThread.CurrentCulture = new CultureInfo("be-BG");
    //     Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    //     string template = "{0,-10:F2}";
    //     string text = string.Format(template, 42);
    //     Console.WriteLine(text);
    // 
    //     DateTime now = DateTime.Now;
    //     Console.WriteLine("{0:yyyy - d/MM}",now);
    //     DateTime parse = DateTime.ParseExact("17.02.2015","dd.MM.yy",CultureInfo.InvariantCulture);
    // }
}
