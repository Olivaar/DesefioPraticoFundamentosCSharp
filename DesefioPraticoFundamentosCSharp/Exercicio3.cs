namespace DesefioPraticoFundamentosCSharp;

public class Exercicio3
{
    public static void Main3()
    {
        double primeiroValor = 10;
        double segundoValor = 5;

        Console.WriteLine("Primeiro valor: "+primeiroValor);
        Console.WriteLine("Segundo valor: "+segundoValor);

        Console.WriteLine("A soma dos valores é: "+(primeiroValor + segundoValor));

        Console.WriteLine("A subtracao dos valores é: "+(primeiroValor - segundoValor));

        Console.WriteLine("A multiplicacao dos valores é: " + (primeiroValor * segundoValor));
        
        if (primeiroValor != 0)
        {
            Console.WriteLine("A divisao dos valores é: " + (primeiroValor / segundoValor));
        } 
        else 
        {
            Console.WriteLine("O segundo valor é zero");
        }

        Console.WriteLine("A medio dos valores é: " + ((primeiroValor+segundoValor) / 2));
    }
}
