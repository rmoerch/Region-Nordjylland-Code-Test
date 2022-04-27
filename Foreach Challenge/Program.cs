using System;
using System.Collections.Generic;

namespace ForeachChallenge
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Peter", "Andersen");
            Person person2 = new Person("Lars", "Hansen");
            Person person3 = new Person("Kaj", "Overgaard");
            Person person4 = new Person("Lise", "Andreasen");
            Person person5 = new Person("Karla", "Birgittesen");
            Person person6 = new Person("Johnny", "Madsen");
            Person person7 = new Person("Sofie", "Dahl");

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person7);

            foreach(Person person in people)
            {
                Console.WriteLine("First Name: " + person.FirstName + "\nLast Name: " + person.LastName + "\n");
            }

            //create a list of people with first and last names
            //list<string> people1 = new list<string>();
            //people.add("peter andersen");
            //people.add("lars hansen");
            //people.add("kaj overgaard");
            //people.add("lise andreasen");
            //people.add("klara birgit");
            //people.add("johnny madsen");
            //people.add("sofie dahl");

            //loop through the list of people
            //foreach (string name in people1)
            //{
            //    console.writeline(name);

            //}

        }
    }

}
