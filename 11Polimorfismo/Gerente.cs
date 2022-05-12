using System;

class Gerente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrao do VA: R$"+ (salario * 0.15) + ".");
    }
}