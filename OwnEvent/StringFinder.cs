using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OwnEvent
{
    class StringFinder
    {
        public delegate void Found(string result);
        public event Found Notify;

        public (string, string) Start(string path, string text)
        {
            int lineCount = 0;
            string fileName = "No";
            var filePaths = Directory.GetFiles(path, "*.txt");
            foreach (string file in filePaths)
            {
                lineCount = 0;
                foreach (var line in File.ReadAllLines(file))
                {
                    lineCount += 1;
                    if (line.Contains(text))
                    {
                        Notify += DisplayMessage;
                        fileName = file;
                    }
                }
            }
            return (lineCount.ToString(), fileName);
        }

        public string ParseStartResults((string, string) start)
        {
            return $"{start.Item2} file contains this text in string {start.Item1}";
        }

        public void DisplayMessage(string result)
        {
            Console.WriteLine(result);
        }
    }
}
