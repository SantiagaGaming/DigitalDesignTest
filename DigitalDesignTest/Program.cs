using System;

namespace DigitalDesignTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string loadTextePath = Environment.CurrentDirectory.ToString() + "\\Текст.txt";
            string saveTextPath = Environment.CurrentDirectory.ToString() + "\\Список.txt";// parser.ToString();
            FileReader fr = new FileReader(loadTextePath);
            string text = fr.GetFileText();
            Parser parser = new Parser(text);
            FileWriter fw = new FileWriter(saveTextPath, parser.ToString());
            Console.ReadLine();
        }
    }
}
