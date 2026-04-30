using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
// aplicando conceitos de classes abstratas

public abstract class Figura
{
    public int X {get; set;}
    public int Y {get;set; }
    public Color Cor {get;set;}
    public bool Preenchido{get;set;}

    // declaração de contrutor 

    public Figura(int x, int y, Color cor, bool preenchido)
    {
        this.X = x;
        this.Y = y;  
        this.Cor = cor;
        this.Preenchido = preenchido;
    }

    // declaração de método abstrato!!!!!

    public abstract void Desenha();
    public abstract void CalcPerimetro();
    public abstract void CalcArea();

}


class Circulo : Figura
{
    public int Raio {get;set;}
    public Circulo(int x, int y, int raio, Color cor, bool preenchido) : base(x, y, cor, preenchido)
    {
        this.Raio = raio;
    }

    public override void Desenha()
    {
        Console.WriteLine($"Desenhando um circulo na posição ({X},{Y}), com o raio {Raio} a cor {Cor}. Preenchido : {(Preenchido ? "Sim" : "Não")}");
    }

    public override void CalcPerimetro()
    {
        Console.WriteLine($"O perímetro do círculo é {(2 * 3 * Raio)}");
    }

    public override void CalcArea()
    {
        Console.WriteLine($"A área do círculo é {(3 * (Raio * Raio))}");
    }
}

class Quadrado : Figura
{
    public int Lado {get; set;}
    public Quadrado(int x, int y, int lado, Color cor, bool preenchido) : base(x, y, cor, preenchido)
    {
        this.Lado = lado; 
    }

    public override void Desenha()
    {
        Console.WriteLine($"Desenhando um quadrado na posição ({X},{Y}), com o lado {Lado} a cor {Cor}. Preenchido: Preenchido : {(Preenchido ? "Sim" : "Não")}");
    }

    public override void CalcPerimetro()
    {
        Console.WriteLine($"O perímetro do quadrado é {(Lado * 4)}");
    }

    public override void CalcArea()
    {
        Console.WriteLine($"A área do quadrado é {(Lado * Lado)}");
    }
}

class MainClass3
{
  public static Figura[] figuras = new Figura[10];
  public static int numFig = 0;

  public static void Main(string[] args)
  {
    figuras[numFig++] = new Quadrado(10, 20, 5, Color.Red, true);
    figuras[numFig++] = new Circulo(213, 78, 3, Color.Navy, true);
    figuras[numFig++] = new Quadrado(95, 4, 4, Color.Brown, true);

    for (int pos = 0; pos < numFig; pos++) 
    {
      figuras[pos].Desenha();
      figuras[pos].CalcPerimetro();
      figuras[pos].CalcArea();
    }

  }
}