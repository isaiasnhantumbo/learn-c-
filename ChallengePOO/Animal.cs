namespace ChallengePOO;

public class Animal
{
    protected string Name { set; get; }

    public Animal()
    {
        Name = "Default name";
    }

    public Animal(string name)
    {
        Name = name;
    }

}