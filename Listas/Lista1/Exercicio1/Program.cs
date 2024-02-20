using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de dias que deseja converter!");

        int DiaInicial = int.Parse(Console.ReadLine());

        int ano = DiaInicial / 365;
        int dia = DiaInicial % 365;

        Console.WriteLine("O total deu " + ano + " ano(s) e, " + dia + " dia(s)");
    }
}
