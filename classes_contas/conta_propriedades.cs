using System;
using System.Data.Common;
using System.Threading;
using Microsoft.VisualBasic;

// classe conta encapsulda com propriedades

class Conta2
{
    
    private static int numeroContas; 
    private int id; 
    private string titular = "";
    private float saldo; 
    private DateTime criacao;  

    // propriedades somente leitura

    public static int NumeroContas
    {
        get {return numeroContas;}
    }

    public int Id
    {
        get {return id;}
    }

    public float Saldo
    {
        get {return saldo;}
        private set {if(value>0) saldo = value;}
    }

    public DateTime Criacao
    {
        get {return criacao;}
    }

    // propriedades leitura e escrita 

    public string Titular
    {
        get {return titular;}
        set {if(value.Length >=3) this.titular = value;}
    }

    // criação de contrutor 

    public Conta2(String titular, float saldo)
    {
        this.id = ++Conta2.numeroContas;
        this.Titular = titular;
        this.Saldo = saldo;
        this.criacao = DateTime.Now;
    }

    // espaço p criação de métodos

    public float Sacar(float valor)
    {
        if(valor <= Saldo)
        {
            Saldo = Saldo - valor;
            return Saldo;
        }
        else
        {
            throw new Exception("Saldo insuficiente");
        }
    }

    public float Depositar(float valor)
    {
        if(valor > 0)
        {
            Saldo = Saldo + valor;
            return Saldo;
        }
        else
        {
            throw new Exception("DEPÓSITO INVÁLIDO");
        }
    }

}

class ExecucaoDois
{
        
    public static void Main (string[] args)
    {
        Console.WriteLine($"Registros de Contas Existentes: {Conta2.NumeroContas}");

        // adicinando conta com parametros 

        Conta2 conta1 = new Conta2("Angélica", 2000.49F);

        Console.WriteLine($"\nRegistros de Contas Existentes: {Conta2.NumeroContas}\n");

        Console.WriteLine($"Conta 1: Construtor com parametros");
        Console.WriteLine($"Nome do Titular: {conta1.Titular}");
        Console.WriteLine($"Saldo: {conta1.Saldo}\n");
        Console.WriteLine($"Data de Criação: {conta1.Criacao}");
        Console.WriteLine($"Chamado de métodos de ação: Exemplo 'Sacar'");
        Console.WriteLine($"Sacando.. R$ 50,00. Total disponível: {conta1.Sacar(50.00F)}");

        Conta2 conta2 = new Conta2("Laura", 1340.49F);

        Console.WriteLine($"\nRegistros de Contas Existentes: {Conta2.NumeroContas}\n");

        Console.WriteLine($"Conta 1: Construtor com parametros");
        Console.WriteLine($"Nome do Titular: {conta2.Titular}");
        Console.WriteLine($"Saldo: {conta2.Saldo}");
        Console.WriteLine($"Data de Criação: {conta2.Criacao}");
        Console.WriteLine($"Chamado de métodos de ação: Exemplo 'Depositar'");
        Console.WriteLine($"Depositando... R$ 0,00. Total disponível: {conta2.Depositar(0.00F)}");


    }
}
 