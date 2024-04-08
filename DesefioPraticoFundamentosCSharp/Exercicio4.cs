namespace DesefioPraticoFundamentosCSharp;

public class Exercicio4
{
    public static void Main4()
    {
        Console.WriteLine("Digite a primeira palavra:");
        List<String> palvras = new List<String>();
        palvras.Add(Console.ReadLine());


        int resposta = 0;

        do
        {
            Console.WriteLine("Digite 1 para continuar digitando ou 2 para encerrar:");
            resposta = int.Parse(Console.ReadLine());

            if (resposta != 1 && resposta != 2)
            {
                Console.WriteLine("Resposta invalida! Digite novamente: ");
                resposta = int.Parse(Console.ReadLine());
            }

            if (resposta == 1)
            {
                Console.WriteLine("Digite a palavra:");
                palvras.Add(Console.ReadLine());
            }
        }
        while (resposta == 1);

        for(int i = 0; i < palvras.Count; i++)
        {
            Console.WriteLine("A palavra " + palvras[i] + " possui " + palvras[i].Length + " letras.");
        }
    }
}
