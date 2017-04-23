using System.Collections.Generic;

namespace DataTamplate
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Person(string firstName, string lastName, int age, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
        }
    }

    public class PersonList : List<Person>
    {
        public PersonList()
        {
            this.Add(new Person("Tigran", "Vardanyan", 28, "Developer"));
            this.Add(new Person("Artur", "Mkrtchyan", 40, "Lecturer"));
            this.Add(new Person("Areg", "Gevorgyan", 27, "Manager"));
        }
    }
}
