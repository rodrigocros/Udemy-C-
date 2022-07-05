namespace GerenciadorEstoque;

[Serializable]
class Curso : Produto, IEstoque
{
    public string autor { get; set; }
    public int vagas { get; set; }

    public Curso(string nome, float preco, string autor)
    {
        this.nome = nome;
        this.preco = preco;
        this.autor = autor;
    }

    public void AdicionarEntrada()
    {
        vagas++;
    }

    public void AdicionarSaida()
    {
        vagas--;
    }

    public void Exibir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Autor: " + autor);
        System.Console.WriteLine("=====================================");
    }
}