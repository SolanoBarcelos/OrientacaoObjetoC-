using System;

class Pessoa
{
    private string nome = "Marcela";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); // O this Sempre vai ligar o atriburo da classe ao seu metodo, quanto tem this remete a um atribruto e quando não tem remete a um parametro.
    }
}