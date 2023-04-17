using System;
using System.IO;

namespace DigitalDesignTest
{
  public  class FileReader
    {
       private StreamReader _sr;
        public  FileReader(string path)
        {
            try
            {
                _sr = new StreamReader(path);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
            }
        }
        public string GetFileText()
        {
            return _sr.ReadToEnd();
        }
    }
}
