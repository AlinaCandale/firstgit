using System;
using System.Diagnostics;
using System.Text;

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
        }
    }
}
