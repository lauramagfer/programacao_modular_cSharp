using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading; 

class Pessoa2
{
    // declaração dos atributos
    private string primeiroNome = "";
    private string segundoNome = "";
    private string nomeCompleto = "";
    private string endereco = ""; 
    private string telefone = ""; 

    // declaração das propriedades (para que os valores dos atributos sejam acessados)

    public string PrimeiroNome
    {
        get {return primeiroNome;}
        set {if(value.Length > 0) this.primeiroNome = value;}
    }

    public string Sobrenome
    {
        get {return segundoNome;}
        set {if(value.Length > 0) this.segundoNome = value;}
    }

    public string NomeCompleto
    {
        get {return primeiroNome + " " + segundoNome;}
        set{this.nomeCompleto = value;}
    }

    public string Endereco
    {
        get {return endereco;}
        set {if(value.Length > 0) this.endereco = value;}
    }

    public string Telefone
    {
        get {return telefone;}
        set {this.telefone = value;}
    }

    // declarando o construtor

    public Pessoa2(string primeiroNome, string segundoNome, string endereco, string telefone)
    {
        this.PrimeiroNome = primeiroNome;
        this.Sobrenome = segundoNome; 
        this.NomeCompleto = nomeCompleto;
        this.Endereco = endereco; 
        this.Telefone = telefone;
    }

}

class PessoaFisica : Pessoa2
{
    private string cpf = "";

    public string Cpf
    {
        get {return cpf;}
        set {if(value.Length == 11)this.cpf = value; else throw new Exception ("CPF INVÁLIDO");}
    }

    public PessoaFisica(string primeiroNome, string segundoNome, string endereco, string telefone, string cpf) : base(primeiroNome, segundoNome, endereco, telefone)
    {
        this.Cpf = cpf;
    }
}

class PessoaJuridica : Pessoa2
{
    private string cnpj = "" ;

    public string Cnpj
    {
        get {return cnpj;}
        set{if(value.Length == 14) this.cnpj = value; else throw new Exception ("CNPJ INVÁLIDO");}
    }

    public PessoaJuridica(string primeiroNome, string segundoNome, string endereco, string telefone, string cnpj) : base(primeiroNome, segundoNome, endereco, telefone)
    {
        this.Cnpj = cnpj;
    }
}

class Main2Class
{
    
    public static void Main(string[]args)
    {
        PessoaFisica pessoaFisica = new PessoaFisica("Laura", "Ferreira", "Duquesa", "(31) 984600566", "16853153642");

        Console.WriteLine("Mostrando os dados da primeira pessoa cadastrada: \n");
        
        Console.WriteLine($"Primeiro nome : {pessoaFisica.PrimeiroNome}");
        Console.WriteLine($"Sobrenome : {pessoaFisica.Sobrenome}");
        Console.WriteLine($"Nome Completo: {pessoaFisica.NomeCompleto}"); 
        Console.WriteLine($"Endereço : {pessoaFisica.Endereco}");
        Console.WriteLine($"Telefone : {pessoaFisica.Telefone}");
        Console.WriteLine($"CPF : {pessoaFisica.Cpf}");


        PessoaJuridica pessoaJuridica = new PessoaJuridica("Heitor", "Magalhães", "Parte Alta", "(31) 975680099", " 1632720000197");

        Console.WriteLine("Mostrando os dados da segunda pessoa cadastrada: \n");
        
        Console.WriteLine($"Primeiro nome : {pessoaJuridica.PrimeiroNome}");
        Console.WriteLine($"Sobrenome : {pessoaJuridica.Sobrenome}");
        Console.WriteLine($"Nome Completo: {pessoaJuridica.NomeCompleto}"); 
        Console.WriteLine($"Endereço : {pessoaJuridica.Endereco}");
        Console.WriteLine($"Telefone : {pessoaJuridica.Telefone}");
        Console.WriteLine($"CNPJ : {pessoaJuridica.Cnpj}");

    }
}