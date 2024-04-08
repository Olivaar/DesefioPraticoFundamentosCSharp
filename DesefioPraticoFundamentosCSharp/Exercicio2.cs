using System;
using System.Reflection.Metadata;

namespace DesefioPraticoFundamentosCSharp;

public class Exercicio2
{
    public static void Main2()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("Nome completo: "+nome +" "+ sobrenome);
    }
}
