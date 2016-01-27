// Problem 3. Read file contents
// 
// Write a program that enters file name along with its full file path(e.g.C:\WINDOWS\win.ini),
// reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Threading;

class ReadFileContents
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        try
        {
            string text = File.ReadAllText(@"C:\Users\ani\Desktop\Key.ini");
            Console.WriteLine(text);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is a problem with your access rights.");
            Console.WriteLine("Its possible to occur this problem, because you enter a path, without the file (.txt).Try again.");
            Main();
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Entered empty string.Try again.");
            Main();
        }
        catch (IOException)
        {
            Console.WriteLine("The file cannot be opened, because now it`s using from other application.Try again.");
            Main();
        }
        finally
        {
            Console.WriteLine("You sucks!");
        }
        Console.WriteLine();
    }
}
