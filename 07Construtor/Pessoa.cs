using System;

class Pessoa
{
    //Construtor - Sempre publico
    public Pessoa()
    {
        Console.WriteLine("Construtor executado!");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá " + nome + ".");
    }
}