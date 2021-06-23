using System;
using Xunit;

namespace ConsoleAppPeople.Tests
{
    public class PersonTests
    {
        [Fact]
        public void DetailsContainsCorrectInfo()
        {
            //Arrange
            string firstName = "Kent";
            string lastName = "Svensson";
            int age = 42;
            Gender gender = Gender.Male;
            bool vaccsinated = true;
            string expectedVaccsinated = "Yes";

            Person testPerson = new Person(firstName, lastName, age, gender, vaccsinated);

            //Act
            string result = testPerson.Details();

            //Assert
            Assert.Contains(firstName, result);
            Assert.Contains(lastName, result);
            Assert.Contains(age.ToString(), result);
            Assert.Contains(gender.ToString(), result);
            Assert.Contains(expectedVaccsinated, result);
        }
    }
}
