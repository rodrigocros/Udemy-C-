namespace Udemy;

class Program
{
    static void Main(string[] args)
    {
        string[] aluno = new string[5] { "João", "Maria", "José", "Pedro", "Ana" };

        foreach (var item in aluno) 
        {
            Console.WriteLine($"Bem vindo, {item}");
        }


    }
}