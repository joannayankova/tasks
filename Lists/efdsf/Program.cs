using System;
using System.Collections.Generic;

namespace efdsf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            var person1 = new Person("Mitko", 21);
            var person2 = new Person("Alex", 17);
            var person3 = new Person("Sashko", 28);
            //List ot personi

            // Implement .Sort();
            // na baza na sort method iskam da sortira edin put po name
            // s vtori sort method da sortira po age

            ///Output
            /// By name: 
            /// Alex
            /// Mitko
            /// Sashko

            /// By Age 
            /// 17
            /// 21
            /// 28
            MyCustomList<Person> people = new MyCustomList<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Sort((x, y) => 0 > string.Compare(x.FirstName, y.FirstName));
        }

        public static bool AgeSortingDescending(Person person, Person person1)
        {
            return person.Age < person1.Age;
        }

        public static bool AgeSorting2(Person person, Person person1)
        {
            return person.Age > person1.Age;
        }


        public static bool NameSortingDescending(Person person, Person person1)
        {
            return true;//;return 0 < string.CompareOrdinal(person.FirstName, person1.FirstName);
        }

        public static bool NameSortingAscending(Person person, Person person1)
        {
            return true; // return 0 > string.CompareOrdinal(person.FirstName, person1.FirstName);
        }


        public class Person
        {
            public Person(string firstName, int age)
            {
                FirstName = firstName;
                Age = age;
            }

            public string FirstName { get; set; }

            public int Age { get; set; }

        }
    }
}