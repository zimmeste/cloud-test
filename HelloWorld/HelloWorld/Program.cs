using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (true)
            {
                i++;
                Console.WriteLine(i + ": Hello World!");
                Thread.Sleep(1000);
            }
        }
    }
}
