using System;
using System.Threading;


// encpasulamento com propriedades 

class Produto3
{
  private int id;
  private string descricao = "";
  private float preco;
  private int quantidade;

  private static int contador = 0;
  private static int instancias = 0;

  public static int Contador { get => Produto3.contador; }

  public static int Instancias { get => Produto3.instancias; }

  public int Id { get => id; }

  public string Descricao {
    get => this.descricao; 
    set { if (value.Length >= 3) this.descricao = value; }
  }
  public float Preco {
    get => preco;
    set { if (value > 0) this.preco = value; }
  }
  public int Quantidade { 
    get => this.quantidade;
    set { if (value >= 0) this.quantidade = value; }
  }

  public Produto3(String descricao, float preco, int quantidade)
  {
    Produto3.instancias++;
    this.id = ++Produto.contador;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Quantidade = quantidade;
  }

  public Produto3()
  {
    Produto3.instancias++;
    this.id = ++Produto.contador;
    this.descricao = "Novo Produto";
    this.preco = 0.01F;
    this.quantidade = 0;
  }

  ~Produto3()
  {
    Console.WriteLine("Executando o destrutor...");
    Produto3.instancias--;
  }

  public bool emEstoque()
  {
    return (quantidade > 0);
  }
}

class classeTesteProduto3
{

  public static void Main(string[] args)
  {
    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto3.Contador);

    Produto3 produto1 = new Produto3();

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto3.Contador);

    Console.WriteLine("Produto 1: construtor default");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto1.Id);
    Console.WriteLine("     Descrição: {0}", produto1.Descricao);
    Console.WriteLine("         Preço: {0}", produto1.Preco);
    Console.WriteLine("    Quantidade: {0}", produto1.Quantidade);
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto1.emEstoque() ? "sim" : "não"));


    Produto3 produto2 = new Produto3("Carne", 20.78F, 0);

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto3.Contador);

    Console.WriteLine("Produto 2: construtor com parâmetros");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto2.Id);
    Console.WriteLine("     Descrição: {0}", produto2.Descricao);
    Console.WriteLine("         Preço: {0}", produto2.Preco);
    Console.WriteLine("    Quantidade: {0}", produto2.Quantidade);
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto2.emEstoque() ? "sim" : "não"));
  }
}