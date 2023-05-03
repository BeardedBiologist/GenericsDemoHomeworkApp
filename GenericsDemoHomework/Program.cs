using System;

namespace GenericsDemoHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 42;
            string myString = "Hello, world!";

            PrintItemToString(myInt);
            PrintItemToString(myString);
        }

        static void PrintItemToString<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
}