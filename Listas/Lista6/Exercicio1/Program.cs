using System;

class Program
{
    static void Main(string[] args)
    {
        bool temJulia = false;
        string[] nomes = new string[10];

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }
        for (int contador = 0; contador < nomes.Length; contador++)
        {
            if (nomes[contador] == "Julia")
            {
                temJulia = true;
            }
        }
        if (temJulia)
        {
            System.Console.WriteLine("ACHEI");
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI");
        }
    }
}
