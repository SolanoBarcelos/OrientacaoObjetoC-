using System;

class Aluno
{
    private double nota1, nota2;

    private double media()
    {
        return (nota1+nota2)/2;
    }

    public void mensagem()
    {
        Console.WriteLine("Informe a nota 1 abaixo:");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a nota 2 abaixo:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A média é " + media() + ".");
    }
}