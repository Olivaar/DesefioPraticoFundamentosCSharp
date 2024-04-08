using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace DesefioPraticoFundamentosCSharp;

public class Exercicio5
{
    public static void Main5()
    {
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Console.ReadLine();

        bool legitima = false;

        if (placa.Length == 7)
        {

            var validation = new Regex("[a-zA-Z][0-9]");
            if (validation.IsMatch(placa))
            {
                legitima = true;
            }

        } else
        {
            Console.WriteLine("Placa falsa!");
        }

        if (legitima)
        {
            Console.WriteLine("Placa legitima!");
        } else
        {
            Console.WriteLine("Placa falsa!");
        }
    }
}
