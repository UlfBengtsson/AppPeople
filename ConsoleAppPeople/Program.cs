using System;
using System.Collections.Generic;

namespace ConsoleAppPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person person = new Person("Ulf", "Bengtsson");

            //Console.WriteLine(person.FullName);

            Person anotherPerson = new Person("Kent", "Svensson", 42, Gender.Male, true);

            //Console.WriteLine(anotherPerson.FullName);
            */

            List<Person> people = InitPeopleList();

            AddPersonToList(people);

            foreach (Person itemInList in people)
            {
                Console.WriteLine(itemInList.Details());
            }

        }

        static List<Person> InitPeopleList()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Kent", "Svensson", 42, Gender.Male, true),
                new Person("Ulf", "Bengtsson", 39, Gender.Male, false)
            };

            return people;
        }

        static void AddPersonToList(List<Person> people)
        {
            people.Add(new Person(AskUserFor("First name"), AskUserFor("Last name")));
        }

        static string AskUserFor(string what)
        {
            Console.Write(what + ": ");
            return Console.ReadLine();
        }
    }
}
