namespace DirectoryTraversal
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversalMain
    {
        public static void Main()
        {
            string pathCurrent = Directory.GetCurrentDirectory();
            string[] filePaths = Directory.GetFiles(pathCurrent);
            List<FileInfo> files = filePaths
                .Select(path => new FileInfo(path))
                .ToList();

            var sorted = files
                .OrderBy(file => file.Length)
                .GroupBy(file => file.Extension)
                .OrderByDescending(group => group.Count())
                .ThenBy(group => group.Key);

            string resultPath = "../../result.txt";

            using (var writer = new StreamWriter(resultPath, false))
            {
                foreach (var extensionGroup in sorted)
                {
                    writer.WriteLine(extensionGroup.Key);

                    foreach (var fileInfo in extensionGroup)
                    {
                        writer.WriteLine("--{0} - {1:F3}kb", fileInfo.Name, fileInfo.Length / 1024.0);
                    }
                }
            }
        }
    }
}
