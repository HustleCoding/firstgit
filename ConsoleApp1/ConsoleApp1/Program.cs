using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Irina ");
            string myString = "Hello";
            string myNextString = "World";

            string a = "a";
            string b = "b";
            string c = "c";

            string random = "B";

            int resultLeft = string.Compare(a, b);
            int resultright = string.Compare(c, b);
            int resultEqual = string.Compare(random, b, true);

            //Concat
            myString = myString + " world";
            string helloWorld = myString + " " + myNextString;

            Stopwatch stopWatch = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                myString += i;
                // myString = myString + i; equivalent with the line before
            }

            stopWatch.Stop();
            Console.WriteLine("For String" + stopWatch.Elapsed);

            //start the stopwatch for stringBuilder
            Stopwatch stopWatch1 = Stopwatch.StartNew();

            StringBuilder builder = new StringBuilder();
            builder.Append(myString);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
            }

            stopWatch1.Stop();
            Console.WriteLine("For StringBuilder" + stopWatch1.Elapsed);

            string path = "C:/Program Files/Windows";
            string programFiles = path.Substring(2, 13);
            string rest = path.Substring(3);
            // program files without giving the length
            string pFiles = path.Substring(path.IndexOf("/", path.LastIndexOf("/")));

            var splitted = path.Split('/');

            string replaced = path.Replace("/", "//");
            string removed = path.Remove(14);

            int awesomeInt = 12345667;
            string intToString = awesomeInt.ToString();
        }
    }
}
