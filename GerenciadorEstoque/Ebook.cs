namespace GerenciadorEstoque;

[Serializable]
class Ebook : Produto, IEstoque
{
    public string autor { get; set; }
    private int vendas { get; set; }

    public Ebook(string nome, float preco, string autor)
    {
        this.nome = nome;
        this.preco = preco;
        this.autor = autor;
    }

    public void AdicionarEntrada()
    {
        vendas++;
    }

    public void AdicionarSaida()
    {
        vendas--;
    }

    public void Exibir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Vendas: " + vendas);
    }

}