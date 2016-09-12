using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var aText = "just a text";

            Console.WriteLine(aText);

            Console.WriteLine(Utils.AddAQuestionmark(aText));

            Console.WriteLine(Utils.AddAQuestionmark(aText));

            Console.WriteLine("Another change");
        }
    }
}
