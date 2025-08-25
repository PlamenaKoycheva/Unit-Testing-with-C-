using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;
    [SetUp]

    public void SetUp()
    {
        _person = new Person();
    }

    
    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };

        Person person = new Person()
        {
            Name = "Alice",
            Age = 35,
            Id = "A001"

        };

        Person person1 = new Person()
        {
            Name = "Bob",
            Age = 30,
            Id = "B002"
        };



        List<Person> expectedPeopleList = new List<Person>();
        expectedPeopleList.Add(person);
        expectedPeopleList.Add(person1);
             
        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
           Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
           Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
          Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> person = new List<Person>()
        { new Person()  {Name = "Plamena", Id = "0001", Age = 33},
        new Person() {Name = "Zdravko", Id = "0002", Age = 33},
        new Person () {Name = "Stefan", Id = "789", Age = 5},
        new Person () {Name = "Dimana", Id = "123", Age = 3},
        };

        string expected = $"Dimana with ID: 123 is 3 years old.{Environment.NewLine}" +
            $"Stefan with ID: 789 is 5 years old.{Environment.NewLine}" +
            $"Plamena with ID: 0001 is 33 years old.{Environment.NewLine}" +
            $"Zdravko with ID: 0002 is 33 years old.";

        // Act
        string result = this._person.GetByAgeAscending(person);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
