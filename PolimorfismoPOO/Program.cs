
public class Person
{
    protected string Name { set; get; }
    protected int Age { set; get; }

    public Person()
    {
        Name = "Default name";
        Age = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void Print()
    {
        Console.WriteLine($"Nome:{Name}, Idade:{Age}");
    }
}
public class Student : Person
{
    protected double Test1 { get; set; }
    protected double Test2 { get; set; }

    public Student(string name, int age, double test1, double test2)
    {
        Name = name;
        Age = age;
        Test1 = test1;
        Test2 = test2;
    }



    public double CalculateAvarage()
    {
        return (Test1 + Test2) / 2;
    }

    public string ShowStudentSituation()
    {
        if (CalculateAvarage() >= 10 && CalculateAvarage() <=14)
        {
            return "Aprovado";
        }

        if (CalculateAvarage() >= 14)
        {
            return "Dispensado";
        }

        return "Reprovado";
    }

    public override void Print()
    {
        Console.WriteLine(
            $"Nome:{Name}, Idade:{Age}, Situação Academica:{ShowStudentSituation()}, " +
            $"Média final:{CalculateAvarage()}");
    }
}


public class Program
{
    public static void Main()
    {
        Person person = new Person("Larson", 8);
        Student student = new Student("Isaias",18,12,10);
         student.Print();
         person.Print();

    }
}