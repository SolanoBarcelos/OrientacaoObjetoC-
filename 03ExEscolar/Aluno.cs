using System;

class Aluno
{
    //Atributos
    public string nome;

    public double nota1, nota2;

    //Métodos

    public double media()
    {
        return (nota1+nota2)/2;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void mensagem()
    {
        //Obter média
        double obterMedia = media();

        // obter a situação

        string obterSituacao = situacao(obterMedia);

        Console.WriteLine(nome + " esta " + obterSituacao + " com média " + obterMedia + ".");
    }
}