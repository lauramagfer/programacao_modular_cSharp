using System;

// treinando sobreposição de métodos (utilizando  virtual e override)
class SuperMostra
{
  public string str = "Super String";

  public virtual void mostra()
  {
    Console.WriteLine("Super mostra!");
  }
}


class EstendeMostra : SuperMostra
{
    
    public new string str = "Estende String";

    public override void mostra()
    {
        Console.WriteLine("---");
        base.mostra();
        Console.WriteLine("Estende mostra!");
        Console.WriteLine("---");
    }

    public static void Main(string[] args)
    {
        SuperMostra obj = new EstendeMostra();
        obj.mostra();
    }
}
