using System;
using System.IO;

namespace DigitalDesignTest
{
    public class FileWriter
    {
        public FileWriter(string path, string text)
        {
            try
            {
                File.WriteAllText(path, null);
                File.AppendAllText(path, text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}