using System;

namespace Packet.Share
{
    public class Person
    {
        public Person() { }

        protected decimal Salary { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person>? Children { get; set; }


        public Person(decimal initialsalary)
        {
            Salary = initialsalary;
        }
    }   
}

 