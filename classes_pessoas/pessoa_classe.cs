using System;
using Microsoft.VisualBasic;

class Pessoa
{
    public string nome = ""; 
    public string endereco = ""; 
    public string telefone = "";

    public string primeiroNome()
    {
        return(nome);
    }


    // construtor sem parametros

    /* public Pessoa()
    {
       nome = "Não informado";
       endereco = "Não informado"; 
       telefone ="Não informado" ;
    }
    */


    // construtor com parametros

    public Pessoa(string nome, string endereco, string telefone)
    {
        this.nome = nome;
        this.endereco = endereco; 
        this.telefone = telefone; 
    }

}


class MainClass
{
    
    public static void Main (string[] args)
    {
        
        Pessoa pessoa = new Pessoa("Laura", "Minas Gerais", "319876589584 deu certo"); 


        Console.WriteLine("Pessoa: ");

        Console.WriteLine("Atributos: ");
        Console.WriteLine($"Nome: {pessoa.nome}");
        Console.WriteLine($"Endereço: {pessoa.endereco}");
        Console.WriteLine($"Telefone: {pessoa.telefone}");

        Console.WriteLine("Métodos:"); 
        Console.WriteLine($"Primeiro nome : {pessoa.primeiroNome()}");

        
    }
}

