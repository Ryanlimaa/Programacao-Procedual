using System;

class Program
{
    static void Main(string[] args)
    {
        int totalItens = 1;
        double somatorio = 0;
        const int promocaoFreteGratis = 150;

        System.Console.WriteLine("Digite a quantidade de itens comprados:");
        int compraQuantidadeIten = int.Parse(Console.ReadLine());

        while (totalItens <= compraQuantidadeIten)
        {
            System.Console.WriteLine("Digite o valor do " + totalItens + "° item:");
            double ValorIten = double.Parse(Console.ReadLine());

            somatorio += ValorIten;
            totalItens++;
        }
        if (somatorio >= promocaoFreteGratis)
        {
            System.Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor: "
             + somatorio + " R$");
        }
        else
        {
            System.Console.WriteLine("A compra nao possui frete gratis.");
        }
    }
}
