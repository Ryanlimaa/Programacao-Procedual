using System;

class Program
{
    public static void Main (string[] args) 
  {
   Console.WriteLine("Digite um valor em numeros inteiros que queira converter para reais;");
    int valor = int.Parse(Console.ReadLine());

    int reais = valor / 100;
    int centavos = valor % 100;

    Console.WriteLine("O total em dinheiro é: " + reais + " real(is), e " + centavos + " centavo(s)");
  }
}
