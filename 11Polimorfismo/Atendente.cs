using System;

class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrao do VA: R$"+ (salario * 0.12) + ".");
    }
}