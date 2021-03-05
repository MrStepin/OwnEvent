using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\TEST";

            string text = "test";

            StringFinder finder = new StringFinder();

            finder.Start(path, text);
            string result = finder.ParseStartResults(finder.Start(path, text));
            finder.DisplayMessage(result);

            Console.ReadKey();
        }
    }
}
