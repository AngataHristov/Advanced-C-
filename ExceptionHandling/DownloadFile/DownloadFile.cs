// Problem 4. Download file
// 
// Write a program that downloads a file from Internet(e.g.Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

class DownloadFile
{
    static void Main()
    {

        WebClient webClient = new WebClient();
        string sourceResource = "http://telerikacademy.com/Content/Images/news-img01.png";
        string fileLocation = "C:\\Users\ani\\Desktop\\ninja.png";
        using (webClient)
            try
            {
                Console.WriteLine("Start downloading {0}", sourceResource);
                webClient.DownloadFile(sourceResource, fileLocation);
                Console.WriteLine("Download succesfull.");
                Console.WriteLine("You can see downloaded file in: C:\\Users\ani\\Desktop\\");
            }
            catch (WebException ex)
            {
                Console.WriteLine("Something going wrong. Details: " + ex.Message);
            }
    }
}
