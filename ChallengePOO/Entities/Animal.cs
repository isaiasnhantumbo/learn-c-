namespace ChallengePOO.Entities;

public class Animal
{
    public Animal()
    {
        Name = "Default name";
    }

    public Animal(string name)
    {
        Name = name;
    }

    protected string Name { set; get; }
}