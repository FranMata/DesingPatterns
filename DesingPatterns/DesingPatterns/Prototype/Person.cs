namespace DesingPatterns.Prototype
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person Copy() => (Person)this.MemberwiseClone();        
    }
}