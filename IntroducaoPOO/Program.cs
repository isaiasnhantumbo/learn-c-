using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public String ToStringOverrided()
    {
       return $"Chamo-me {Name}, tenho {Age} anos de idade";
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Isaias", 18);
        Console.WriteLine(person1.ToStringOverrided());
    }

}