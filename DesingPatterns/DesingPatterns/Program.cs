using DesingPatterns.Factory;
using DesingPatterns.Singleton;
using System;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            _PrintPatternName("Singleton");
            new SingletonImplementation().Implementation();
            _PrintPatternName("Factory");
            new FactoryImplementation().Implementation();
        }

        private static void _PrintPatternName(string name)
        {
            Console.WriteLine("----------------{0}-------------------", name);
        }
    }
}
