using System;
using System.IO;

namespace DigitalDesignTest
{
  public  class FileReader
    {
        StreamReader sr;
        public  FileReader(string path)
        {
            try
            {
                sr = new StreamReader(path);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
            }
        }
        public string GetFileText()
        {
            return sr.ReadToEnd();
        }
    }
}
