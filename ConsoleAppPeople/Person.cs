using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPeople
{
    public class Person
    {


        string firstName;
        string lastName;//default value stats with is null.
        int age;//default value stats with is 0.
        public Gender Gender { get; set; }
        public bool IsVaccinated { get; set; }//default value stats with is false.

        public string FirstName 
        {
            get { return firstName; } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                lastName = value;
            }
        }
        public string FullName { get { return firstName + ' ' + lastName; } }
        public int Age
        { 
            get { return age; }
            set
            {
                if (value >= 0 && value < 140)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age range is 0 to less then 140");
                }
            }
        }

        public Person(string firstName, string lastName)
        {
            //Gender = Gender.Other;
            //IsVaccinated = false;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(
            string firstName, 
            string lastName, 
            int age, 
            Gender gender, 
            bool vaccinated
            ) 
            : this(firstName, lastName)
        {
            Age = age;
            Gender = gender;
            IsVaccinated = vaccinated;
        }


    }
}
