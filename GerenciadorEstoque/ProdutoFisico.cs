namespace GerenciadorEstoque;

[Serializable]
class ProdutoFisico : Produto, IEstoque
{
    public float frete ;
    private int estoque ;

    public ProdutoFisico(string nome, float preco, float frete)
    {
        this.nome = nome;
        this.preco = preco;
        this.frete = frete;
    }

    public void AdicionarEntrada()
    {
    
    }
    public void AdicionarSaida()
    {
    }

    public void Exibir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Frete: " + frete);
        Console.WriteLine("Estoque: " + estoque);
    }


}



