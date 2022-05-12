using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrao do VA: R$"+ (salario * 0.1) + ".");
    }

    public virtual void ValeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrao do VT: R$" + (salario * 0.06) + ".");
    }
}