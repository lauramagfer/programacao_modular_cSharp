using System;



class Conta
{
    public static int numeroContas;
    public int id;
    public string titular = ""; 
    public float saldo; 
    public DateTime criacao;

    public Conta(string titular, float saldo)
    {
       this.id = ++Conta.numeroContas;
       this.titular = titular; 
       this.saldo = saldo; 
       this.criacao = DateTime.Now;
    }
}

class Execucao
{
    public static void Main (string[] args)
    {
        Console.WriteLine($"\nRegistros de contas existentes:{Conta.numeroContas}\n");

        // adicionando conta com parametros 

        Conta conta1 = new Conta("Laura", 1050.04F);

        Console.WriteLine($"\nRegistros de contas existentes:{Conta.numeroContas}\n");

        Console.WriteLine("Conta 1: Construtor com parametros");
        Console.WriteLine($"ID da Conta: {conta1.id}");
        Console.WriteLine($"Nome do Titular: {conta1.titular}");
        Console.WriteLine($"Saldo: {conta1.saldo}");
        Console.WriteLine($"Data de Criação: {conta1.criacao}");


        Conta conta2 = new Conta("Heitor", 2080.06F);

        Console.WriteLine($"\nRegistros de contas existentes:{Conta.numeroContas}\n");

        Console.WriteLine("Conta 2: Construtor com parametros");
        Console.WriteLine($"ID da Conta: {conta2.id}");
        Console.WriteLine($"Nome do Titular: {conta2.titular}");
        Console.WriteLine($"Saldo: {conta2.saldo}");
        Console.WriteLine($"Data de Criação: {conta2.criacao}");

    }
}