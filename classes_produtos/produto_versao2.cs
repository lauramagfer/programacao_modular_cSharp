using System; 
using System.Threading;

// classe produto encapsulada (utilizando métodos)

class Produto2
{
    private int id;
    private string descricao = ""; 
    private float preco; 
    private int quantidade; 

    private static int contador = 0; 
    private static int instancias = 0; 

    public static int GetContador()
    {
        return contador; 
    }

    public static int GetInstancias()
    {
        return instancias;
    }

    public int GetId()
    {
        return this.id;
    }

    public string GetDescricao()
    {
        return this.descricao;
    }

    public void SetDescricao(string descricao)
    {
        if(descricao.Length  >= 3)
        {
            this.descricao = descricao;
        }
    }

    public float GetPreco()
    {
        return preco;
    }

    public void SetPreco(float preco)
    {
        if (preco > 0)
        {
            this.preco = preco;
        }
    }

    public int GetQuantidade()
    {
        return this.quantidade;
    }

    public void SetQuantidade(int quantidade)
    {
        if(quantidade >= 0)
        {
            this.quantidade = quantidade; 
        }
    }

     public Produto2(String descricao, float preco, int quantidade)
    {
        Produto2.instancias++;
        this.id = ++Produto2.contador;
        this.SetDescricao(descricao);
        this.SetPreco(preco);
        this.SetQuantidade(quantidade);
    }

    public Produto2()
    {
        Produto2.instancias++;
        this.id = ++Produto.contador;
        this.descricao = "Novo Produto";
        this.preco = 0.01F;
        this.quantidade = 0;
    }

    ~Produto2()
    {
        Console.WriteLine("Executando o destrutor...");
        Produto2.instancias--;
    }

    public bool emEstoque()
    {
        return (quantidade > 0);
    }

}

class classeTesteProduto2
{

  public static void Main(string[] args)
  {
    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto2.GetContador());

    Produto2 produto1 = new Produto2();

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto2.GetContador());

    Console.WriteLine("Produto 1: construtor default");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto1.GetId());
    Console.WriteLine("     Descrição: {0}", produto1.GetDescricao());
    Console.WriteLine("         Preço: {0}", produto1.GetPreco());
    Console.WriteLine("    Quantidade: {0}", produto1.GetQuantidade());
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto1.emEstoque() ? "sim" : "não"));


    Produto2 produto2 = new Produto2("Leite", 3.59F, 12);

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto2.GetContador());

    Console.WriteLine("Produto 2: construtor com parâmetros");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto2.GetId());
    Console.WriteLine("     Descrição: {0}", produto2.GetDescricao());
    Console.WriteLine("         Preço: {0}", produto2.GetPreco());
    Console.WriteLine("    Quantidade: {0}", produto2.GetQuantidade());
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto2.emEstoque() ? "sim" : "não"));
  }
}