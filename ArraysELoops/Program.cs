class Program
{
    static void Main()
    {
        // um programa que guarda nome de estudantes de uma turma;
        int capacity;
        string[] students;
        Console.WriteLine("Digite o numero de estudantes");
        try
        {
            int.TryParse(Console.ReadLine(), out capacity);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        students = new string[capacity];
        FillStudents(students);
        ShowStudents(students);
        static void FillStudents(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Digite o nome do estudante");
                students[i] = Console.ReadLine();
            }
        }

        static void ShowStudents(string[] students)
        {
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}