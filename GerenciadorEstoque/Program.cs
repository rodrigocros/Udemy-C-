namespace GerenciadorEstoque;
class Program
{
    static List<IEstoque> produtos = new List<IEstoque>();
    enum Menu
    {
        ListarProdutos = 1,
        Adicionar = 2,
        Remover = 3,
        Entrada = 4,
        Saida = 5,
        Sair = 6
    }

    static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            System.Console.WriteLine("Gerenciador de Estoque");
            System.Console.WriteLine("1 - Listar Produtos\n2 - Adicionar\n3 - Remover\n4 - Entrada\n5 - Saida\n6 - Sair"); 
            Console.WriteLine("Digite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());
            Menu escolha = (Menu)opcao;
            Console.Clear();
            
            switch(escolha)
            {
                case Menu.ListarProdutos:
                    System.Console.WriteLine("Listando Produtos");
                    // ListarProdutos();
                    break;
                case Menu.Adicionar:
                    System.Console.WriteLine("Adicionando Produto");
                    CadastrarProduto();
                    break;
                case Menu.Remover:
                    System.Console.WriteLine("Removendo Produto");
                    // Remover();
                    break;
                case Menu.Entrada:
                    System.Console.WriteLine("Entrando Produto");
                    // Entrada();
                    break;
                case Menu.Saida:
                    System.Console.WriteLine("Saindo Produto");
                    // Saida();
                    break;
                case Menu.Sair:
                    sair = true;
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }
            Console.Clear();
        }
    } 

    static void CadastrarProduto()
    {
        System.Console.WriteLine("Cadastro de Produto");
        System.Console.WriteLine("1- Produto Físico\n2- Ebook \n3- Curso");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
            CadastrarPFisico();
                break;
            case 2:
            CadastrarEbook();
                break;
            case 3:
            CadastrarCurso();
                break; 
        }
    }

    static void CadastrarPFisico()
    {
        System.Console.WriteLine("Cadastro de Produto Físico");
        System.Console.WriteLine("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Digite o preço do produto: ");
        float preco = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite a quantidade do produto: ");
        float frete = float.Parse(Console.ReadLine());

        ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
        produtos.Add(pf);// Adicionando o produto na lista
        Salvar();

    }
    static void CadastrarEbook()
    {
        System.Console.WriteLine("Cadastro de Ebook");
        System.Console.WriteLine("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Digite o preço do produto: ");
        float preco = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o autor do produto: ");
        string autor = Console.ReadLine();
        System.Console.WriteLine("Digite a quantidade do produto: ");

        Ebook eb = new Ebook(nome, preco, autor);
        produtos.Add(eb); // Adicionando o ebook na lista de produtos
        Salvar();

    }
    static void CadastrarCurso()
    {
        System.Console.WriteLine("Cadastro de Curso");
        System.Console.WriteLine("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Digite o preço do produto: ");
        float preco = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o autor do produto: ");
        string autor = Console.ReadLine();

        Curso curso = new Curso(nome, preco, autor);
        produtos.Add(curso); // Adicionando o curso na lista de produtos
        Salvar();
    }
    
    static void Salvar()
    {
        FileStream stream = new FileStream("produtos.txt", FileMode.OpenOrCreate);
        StreamWriter writer = new StreamWriter(stream);
        foreach (IEstoque produto in produtos)
        {
            writer.WriteLine(produto.ToString());
        }
        writer.Close();
        stream.Close(); 
    }

}
