class Program
{
    static void Main()
    {
        // variveis => Declaração e atribuição
        // string nome = "Isaias";
        // Console.Write(nome);
        //
        // double nota1 = 15.5;
        // double nota2 = 13;
        // int numero = 847755221;
        // string nomeDoAluno = "Yazalde";
        //
        // double media = (nota1 + nota2) / 2;
        //
        // if (media > 14)
        // {
        //     if (nota1 > 16 || nota2 > 16)
        //     {
        //         Console.WriteLine("O aluno " + nomeDoAluno + " passou com merito " + "\t" + media);
        //         Console.WriteLine("Numero de telefone: " + "+258 " + numero);
        //     }
        //
        //     if (nota1 >= 10 || nota2 >= 10)
        //     {
        //         Console.WriteLine("O aluno " + nomeDoAluno + " passou sem merito " + "\t" + media);
        //         Console.WriteLine("Numero de telefone: " + numero);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("O aluno " + nomeDoAluno + " chumbado com merito " + "\t" + media);
        // }

        // programa que recebe dois numeros e operador artimetrico;
        double firstNumber, secondNumber, result;
        try
        {
            Console.Write("Digite um número: ");
            double.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Digite outro número: ");
            double.TryParse(Console.ReadLine(), out secondNumber);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }

        char userOperator;
        try
        {
            Console.Write("Digite o operador desejado ");
            char.TryParse(Console.ReadLine(), out userOperator);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        switch (userOperator)
        {
            case '+':
                result = firstNumber + secondNumber;
                Console.WriteLine(result);
                break;
            case '-':
                result = firstNumber - secondNumber;
                Console.WriteLine(result);
                break;
            case '/':
                result = firstNumber / secondNumber;
                Console.WriteLine(result);
                break;
            case '*':
                result = firstNumber * secondNumber;
                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("Operador invalido");
                break;

        }
    }
}