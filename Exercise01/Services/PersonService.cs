using Exercise01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise01.Services
{
    public class PersonService
    {
        public static List<Person> GetPeople()
        {
            var persons = new List<Person>();
            persons.Add(new Person() { PersonId = 1, Name = "Thomas", Birthday = new DateTime(1999, 7, 3) });
            persons.Add(new Person() { PersonId = 2, Name = "Line", Birthday = new DateTime(1994, 10, 23) });
            persons.Add(new Person() { PersonId = 3, Name = "Trine", Birthday = new DateTime(2001, 2, 28) });

            return persons;
        }

        public static Person GetPerson(int id)
        {
            return GetPeople().Where(p => p.PersonId == id).First();
        }
    }
}