using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    public static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        if (ehPar(numero))
        {
            System.Console.WriteLine(ehPar(numero));
        }
    }
    static bool ehPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        System.Console.WriteLine();

        return false;
    }
}
