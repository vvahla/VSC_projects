using System;
using Zoo;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" + args[0]);

            Animal nameable = new Animal("Pertti");
            PrintName(nameable);
        }

        static void PrintName(INameable nameable)
        {
            Console.WriteLine(nameable.Name);
        }
    }
}
