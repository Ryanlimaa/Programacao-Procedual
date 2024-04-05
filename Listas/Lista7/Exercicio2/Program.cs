using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        System.Console.WriteLine(Funcao(num1, num2, num3));
    }

    static int Funcao(int num1, int num2, int num3)
    {
        int maiorNumero = 0;

        if(num1 > num2 && num1 > num3)
        {
            return maiorNumero += num1;
        }
        if(num2 > num1 && num2 > num3)
        {
            return maiorNumero += num2;
        }
        else
        {
            return maiorNumero += num3;
        }
    }
}
