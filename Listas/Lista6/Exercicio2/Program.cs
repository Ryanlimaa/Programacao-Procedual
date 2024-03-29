using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        for (int contador = 0; contador < nomes.Length; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }
        System.Console.WriteLine();
        for (int contador = 9; contador >= 0; contador--)
        {
            if (contador % 2 == 0)
            {
                System.Console.WriteLine(nomes[contador]);
            }

        }
    }
}