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

            //List<Person> people = InitPeopleList();

            //AddPersonToList(people);

            //foreach (Person itemInList in people)
            //{
            //    Console.WriteLine(itemInList.Details());
            //}
            Calc();
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

        /// <summary>
        /// Will force the user to enter a number.
        /// </summary>
        /// <param name="whatNumber">will add string infront of " number:" when asking the user for a number</param>
        /// <returns>double number</returns>
        static double AskUserForNumber(string whatNumber)
        {
            double number = 0;
            string input = string.Empty;
            do
            {
                input = AskUserFor(whatNumber + " number");
            } while ( ! double.TryParse(input, out number));

            return number;
        }

        /// <summary>
        /// defaultly prints "Press any key to continue." to Console
        /// then awaiting a key press that will not be printed to console.
        /// </summary>
        /// <param name="OverrideMessage">string to replace default "Press any key to continue."</param>
        static void PressAnyKeyToContinue(string OverrideMessage = "Press any key to continue.")//assigning a input paramater is like giving it a default value that can be overriden.
        {
            Console.WriteLine(OverrideMessage);
            Console.ReadKey(true);
        }

        static void Calc()
        {

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("--- Calc menu ---\nA - do Addition\nS - do Subtration\nM - do Multiplication\nD - do Divide\nQ - quit/exit\n\nPress corresponding key to menu option:");

                ConsoleKey selection = Console.ReadKey(true).Key;
                if (selection == ConsoleKey.Q)
                {
                    PressAnyKeyToContinue("Thanks for using this program!\nPress any key to close program.");
                    keepGoing = false;
                    continue;
                }

                double numA = AskUserForNumber("First");
                double numB = AskUserForNumber("Second");
                double result = 0;

                char mathSymbol = ' ';
                switch (selection)
                {
                    case ConsoleKey.A:
                        result = CalcNumber.Addition(numA, numB);
                        mathSymbol = '+';
                        break;
                    case ConsoleKey.S:
                        result = CalcNumber.Subtration(numA, numB);
                        mathSymbol = '-';
                        break;
                    case ConsoleKey.M:
                        result = CalcNumber.Multiplication(numA, numB);
                        mathSymbol = '*';
                        break;
                    case ConsoleKey.D:
                        try
                        {
                            result = CalcNumber.Divide(numA, numB);
                            mathSymbol = '/';
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
                if (mathSymbol != ' ')
                {
                    Console.WriteLine($"{numA} {mathSymbol} {numB} = {result}");
                }
                PressAnyKeyToContinue();
            }
        }
    }
}
