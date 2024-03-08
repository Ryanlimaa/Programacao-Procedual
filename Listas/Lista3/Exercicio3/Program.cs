using System;

class Program
{
    static void Main(string[] args)
    {
        const string nomeCorreto = "admin";
        const string senhaCorreta = "123senha";
        const int numeroMaximo = 3;
        int contadorTentativas = 1;

        do 
        {
            System.Console.WriteLine("Digite o nome de usuario:");
            string nomeUsuario = Console.ReadLine();
            System.Console.WriteLine("Digite sua senha:");
            string senhaUsuario = Console.ReadLine();

            if (nomeUsuario == nomeCorreto && senhaUsuario == senhaCorreta)
            {
                System.Console.WriteLine("Login realizado com sucesso!");
                break;
            }
            contadorTentativas++;
        }
        while (contadorTentativas <= numeroMaximo);

        if (contadorTentativas > numeroMaximo)
        {
            System.Console.WriteLine("Sua conta foi bloqueada.");
        }
        

    }
}
