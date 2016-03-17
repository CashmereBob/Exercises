using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class ListLoader
    {
        public List<string> Languages = new List<string>();
        public void Load()
        {


            var myReader = new StreamReader(@"languages.txt");

            string line;
            while ((line = myReader.ReadLine()) != null)
            {
                Languages.Add(line);
            }

            myReader.Close();

        }

        public void SearchLanguage(string term)
        {
            foreach (string language in Languages)
            {
                string lang = language.ToLower();

                if (lang.Contains(term.ToLower()))
                {
                    Console.WriteLine(language);
                }
            }
        }
    }
}
