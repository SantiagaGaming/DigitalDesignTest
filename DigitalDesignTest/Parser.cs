using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalDesignTest
{
 public class Parser
    {
        private string _allText;
        public Parser(string fileName)
        {        
            string[] words = DeleteAllSigns(fileName).Split(' ');
            Dictionary<string, int> _parser  = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (_parser.Keys.Contains(words[i]))
                {
                    _parser[words[i]] += 1;
                }
                else _parser.Add(words[i], +1);
            }
            var sort = _parser.OrderByDescending(x => x.Value);
            foreach (KeyValuePair<string, int> kvp in sort)
            {
                Console.WriteLine($"Слово: {kvp.Key}  Повторения: { kvp.Value}");
                _allText+=$"Слово: {kvp.Key}  Повторения: { kvp.Value}" +"\n";
            }
        }
        private string DeleteAllSigns(string text)
        {
            text = text.Replace(".", string.Empty).Replace("?", string.Empty).Replace("!", string.Empty).Replace(",", string.Empty).Replace(",", string.Empty);
            return text;
        }
        public override string ToString()
        {
            return _allText;
        }
    }
}
