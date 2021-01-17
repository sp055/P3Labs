namespace Z7
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Person(string name, string lastName, string position)
        {
            Name = name;
            LastName = lastName;
            Position = position;
        }
    }
}