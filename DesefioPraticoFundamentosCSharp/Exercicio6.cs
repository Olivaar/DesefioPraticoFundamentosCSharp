namespace DesefioPraticoFundamentosCSharp;

public class Exercicio6
{
    public static void Main6()
    {
        Console.WriteLine("Digite 1 para visualizar Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos). \n" +
            "Digite 2 para Apenas a data no formato \"01/03/2024\". \n" +
            "Digite 3 para Apenas a hora no formato de 24 horas.\n" +
            "Dogote 4 para A data com o mês por extenso.");

        var resposta = Console.ReadLine();

        DateTime data = DateTime.Now;


        switch (resposta)
        {
            case "1":
                Console.WriteLine(data.ToString("dddd dd/MM/yyyy HH:mm:ss")); 
            break;
            case "2":
                Console.WriteLine(data.ToString("dd/MM/yyyy")); 
            break;
            case "3":
                Console.WriteLine(data.ToString("HH"));
            break;
            case "4":
                Console.WriteLine(data.ToString("dd/MMMM/yyyy"));
            break;
            default:
                Console.WriteLine("Opcao invalida");
            break;
        }
    }
}
