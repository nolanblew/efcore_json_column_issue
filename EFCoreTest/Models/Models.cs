using System.ComponentModel.DataAnnotations;

namespace EFCoreTest.Models;

public class Person
{
    [Key]
    public int Id { get; set; } = 0;
    public string Name { get; set; }
    public Person? BestFriend { get; set; }
    public List<Animal> Pets { get; set; }

    public Person() { }

    public Person(int id, string name, Person? bestFriend, List<Animal> pets)
    {
        Id = id;
        Name = name;
        BestFriend = bestFriend;
        Pets = pets;
    }
}

public class Animal
{
    public string Name { get; set; }
    public int Legs { get; set; }
    public List<Food> AcceptableFood { get; set; }

    public Animal() { }
}

public class Food
{
    public string Brand { get; set; }
    public double Amount { get; set; }
    public int TimesPerDay { get; set; }

    public Food() { }

    public Food(string brand, double amount, int timesPerDay)
    {
        Brand = brand;
        Amount = amount;
        TimesPerDay = timesPerDay;
    }
}