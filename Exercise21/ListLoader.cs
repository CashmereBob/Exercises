using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class ListLoader
    {
        public List<LanguageData> Languages = new List<LanguageData>();
        public void Load()
        {

            var myReader = new StreamReader(@"language.txt");

            string line;
            while ((line = myReader.ReadLine()) != null)
            {
                var language = new LanguageData();
                var lineArray = line.Split('\t');
                language.name = lineArray[0];
                language.year = int.Parse(lineArray[1]);
                language.description = lineArray[2];

                Languages.Add(language);

            }

            myReader.Close();

        }

        public void SearchLanguage(int min, int max)
        {
            var results = new List<LanguageData>();
            foreach (LanguageData language in Languages)
            {
                if (language.year >= min && language.year <= max)
                {                 
                    results.Add(language);
                }
            }

            results = results.OrderBy(o => o.year).ToList();

            foreach (LanguageData language in results)
            {
                Console.WriteLine(language.year + "\t" + language.name + "\t" + language.description);
            }

            Save(results);
        }

        public void Save(List<LanguageData> list)
        {
            var myWriter = new StreamWriter(@"results.txt");
            foreach (LanguageData line in list)
            {
                myWriter.WriteLine(line.year + "\t" + line.name + "\t" + line.description);
            }
            myWriter.Close();
        }
    }
}
