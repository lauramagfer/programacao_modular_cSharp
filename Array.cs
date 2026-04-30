using System;

class Array
{
    public static void Main()
    {
        int n = 10;
        int[] vet = new int[n];

        for(int i = n - 1; i >= 0; i--)
        {
            vet[i] = int.Parse(Console.ReadLine()!);
        }
    }
}