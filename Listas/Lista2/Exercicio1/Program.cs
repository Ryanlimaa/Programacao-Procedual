using System;
using System.Net.Mail;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main (String[] args)
    {
        const string nome = "admin";
        const string senha = "123senha";

        Console.WriteLine("Digite seu nome de usuario:");
        string nomeDeUsuario = Console.ReadLine();

        Console.WriteLine("Digite sua senha:");
        string senhaDoUsuario = Console.ReadLine();

        if (nomeDeUsuario == nome && senhaDoUsuario == senha)
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas");
        }

    }
}
