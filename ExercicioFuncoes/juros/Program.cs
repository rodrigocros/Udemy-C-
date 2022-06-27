namespace juros;

public class Program
{


    
    static void Main(string[] args)
    {
        // ///Exercicio 1
        // Console.WriteLine("Digite o Valor Inicial: ");
        // int PrecoInicial = int.Parse(Console.ReadLine());
        // Console.WriteLine("Digite o juros ");
        // int Juros = int.Parse(Console.ReadLine()); 
        // int ValorFinal = ValorComJuros(PrecoInicial, Juros);
        // Console.WriteLine("O valor com Juros é: " + ValorFinal);

        // ///Exercicio 2
        // float Pizza =  AreaCirculo(30);
        // Console.WriteLine("A área da pizza é: " + Pizza);

        // ///Exercicio 3
        float Triangulo = AreaTriangulo(10, 20);
        Console.WriteLine("A área do triângulo é: " + Triangulo);
    }

    // Exercicio1
    // // static int ValorComJuros(int precoInicial, int juros)
    // // {
    // //     return precoInicial + (precoInicial * juros / 100);
    // // }

    // // // Exercicio2
    // static float AreaCirculo(int r)
    // {
    //     float pi = 3.14f;
    //     float area = pi * r * r;
    //     return area;
    // }

    static float AreaTriangulo(int baseTriangulo, int altura)
    {
        float area = baseTriangulo * altura / 2;
        return area;
    }

}
