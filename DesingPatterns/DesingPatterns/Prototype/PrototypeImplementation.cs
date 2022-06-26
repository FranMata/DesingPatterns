using System;

namespace DesingPatterns.Prototype
{
    public class PrototypeImplementation
    {
        public void Implementation()
        {
            Person p1 = new Person();
            p1.Name = "Cletus";
            p1.Age = 32;

            Console.WriteLine("P1 VALUES");

            Console.WriteLine(string.Format("Name: {0}\nAge: {1}", p1.Name, p1.Age));

            Person p2 = p1.Copy();

            Console.WriteLine("P1 VALES COPIED TO P2");

            Console.WriteLine("P2 VALUES");
            Console.WriteLine(string.Format("Name: {0}\nAge: {1}", p2.Name, p2.Age));

            Console.WriteLine("CHANGING P2 VALUES");
            p2.Name = "LIsa";
            p2.Age = 8;

            Console.WriteLine("P2 VALUES AFTER CHANGE");
            Console.WriteLine(string.Format("Name: {0}\nAge: {1}", p2.Name, p2.Age));
        }
    }
}
