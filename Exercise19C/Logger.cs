using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19C
{
    class Logger : ILogger, ISaveable, ILoadable
    {


        public List<string> LogPosts { get; set; }

        public Logger()
        {
            LogPosts = new List<string>();
        }
        public void Log(string message)
        {
            // Add the message to a private List<string>
            LogPosts.Add(message);
        }
        public IEnumerator<string> GetEnumerator()
        {

            return LogPosts.GetEnumerator();
        }

        public void Save(string fileName)
        {
            var myWriter = new StreamWriter(@"../../" + fileName);
            foreach (string post in LogPosts)
            {
                myWriter.WriteLine(post);
            }
            myWriter.Close();
        }

        public void Load(string fileName)
        {


            var myReader = new StreamReader(@"../../" + fileName);

            string line;
            while ((line = myReader.ReadLine()) != null)
            {
                Log(line);
            }
        }

    }
}
