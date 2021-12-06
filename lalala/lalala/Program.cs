using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;

namespace lalala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Alina ");
            string myString = "Hello";
            string myNextString = "World";

            string a = "a";
            string b = "b";
            string c = "c";
            string random = "B";

            int result = string.Compare(a, b); //-1
            int resultLeft = string.Compare(c, b); //1
            int resultXX = string.Compare(random, b, true); //0
            int resultX = string.Compare(random, b); //1

            //Concat
            myString = myString + myNextString;

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                myString += i;
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            Stopwatch stopWatch1 = Stopwatch.StartNew();
            StringBuilder builder = new StringBuilder();
            builder.Append(myString);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
            }
            stopWatch1.Stop();
            Console.WriteLine(stopWatch1.ElapsedMilliseconds);

            //Substring
            string mystring = "This is an awesome string, This is not easy";
            int indexOfThis = mystring.IndexOf("This");
            int lastIndexOf = mystring.LastIndexOf("This");

            string path = "C:/Program Files/Windows";
            string programFiles = path.Substring(3, 13);
            string rest = path.Substring(3);

            string pFiles = path.Substring(path.IndexOf("/") - 1, path.LastIndexOf("/") - path.IndexOf("/") - 1); //Program Files

            //Split
            var splitted = path.Split('/');

            string replace = path.Replace("/", "//");
            string removed = path.Remove(14);

            int awesomeInt = 123456878;
            string intToString = awesomeInt.ToString();

            CultureInfo culture = new CultureInfo("tr-TR");
            string awesomeCulture = awesomeInt.ToString("C", culture);

            // asta de jos nu merge - tema .. de schimbat din string inapoi in int
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int oldInt = int.Parse(awesomeCulture);

            string interpolated = $"This is an int: {awesomeInt}, in tr-TR culture is: {awesomeCulture}";

        }
    }
}
