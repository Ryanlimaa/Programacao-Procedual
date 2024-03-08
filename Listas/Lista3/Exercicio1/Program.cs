using System;

class Program
{
    static void Main(string[] args)
    {
        const int habitantes = 20;
        double somatoriaSalarios = 0;
        int somatoriaFilhos = 0;
        double maiorSalario = 0;

        for (int contador = 1; contador <= habitantes; contador++)
        {
            System.Console.WriteLine("Digite o salario da " + contador + "° pessoa:");
            double salarioAtual = double.Parse(Console.ReadLine());
            
            somatoriaSalarios += salarioAtual;

            System.Console.WriteLine("Digite a quantidade de filhos que a " + contador + 
            "° pessoa possui:");
            int numeroAtualFilhos = int.Parse(Console.ReadLine());

            somatoriaFilhos += numeroAtualFilhos;

            if (salarioAtual > maiorSalario)
            {
                maiorSalario = salarioAtual;
            }
        }
        double mediaSalarial = somatoriaSalarios / habitantes;
        double mediaFilhos = somatoriaFilhos / habitantes;

         System.Console.WriteLine("Media salarial dos habitantes: "
         + Math.Round(mediaSalarial, 2) + " R$");
         System.Console.WriteLine("Media de filhos por habitantes: " 
         + mediaFilhos);
         System.Console.WriteLine("Maior salario: "
         + Math.Round(maiorSalario, 2) + " R$");
    }
}
