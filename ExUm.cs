// Faça um programa que leia a nota e o nome de n alunos e mostre na tela o nome daqueles que ficaram acima da média do grupo, sendo n um número inteiro lido no teclado
/*

using System;
using Microsoft.VisualBasic;

class ExUm
{
    
    public static void Main()
    {
        int n;
        double[] nota;
        string[] nome;
        double media = 0;

        Console.WriteLine("Digite o número de alunos: ");
        n = int.Parse(Console.ReadLine()!);
        nota = new double[n];
        nome = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite o nome do {0}o aluno: ", (i + 1));
            nome[i] = Console.ReadLine()!;

            Console.WriteLine("Digite a nota do {0}o aluno: ", (i + 1));
            nota[i] = double.Parse(Console.ReadLine()!);

            media += nota[i];
        }

        media /= n;
         Console.WriteLine(media);

        for(int i = 0; i < n; i++)
        {
            if(nota[i] >= media)
            {
                Console.WriteLine("Aluno {0} -- nota {1}", nome[i], nota[i]);
            }
        }
    }
}

*/