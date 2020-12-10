using System;

namespace ClassAndObjects
{
    public class Example
    {
        public void Result()
        {
           Console.WriteLine("Correct Result.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example Result = new Example();
            Result.Result();
        }
    }
}
