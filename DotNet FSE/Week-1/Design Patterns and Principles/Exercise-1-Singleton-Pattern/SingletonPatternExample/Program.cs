using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Application Started");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Loading Configuration");

            Console.WriteLine();

            Console.WriteLine("Checking if both objects are the same...");

            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("SUCCESS: Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("ERROR: Multiple Logger instances created.");
            }
        }
    }
}