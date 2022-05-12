using System;

class Colaborador : Pessoa // Não existe herança multipla em C#- uma classe só pode extender a outra.
{
    private double salario;

    //Construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: " + salario);
    }

}