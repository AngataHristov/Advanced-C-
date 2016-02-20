namespace CopyBinaryFile
{
    using System.IO;

    public class CopyBinaryFileMain
    {
        public static void Main()
        {
            string imagePath = "../../404-error.jpg";
            string copyPath = "../../404-error-copy.jpg";

            FileStream source = new FileStream(imagePath, FileMode.Open);
            FileStream destination = new FileStream(copyPath, FileMode.Create);

            using (source)
            {
                using (destination)
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
