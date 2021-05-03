using System;

namespace Calculador_de_Idade_atual
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input de informações do usuário
            Console.WriteLine("Calculador de Idade Atual...");
            Console.WriteLine("Digite o Ano em que você nasceu no formato xxxx");
            int anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Mês em que você nasceu em formato numérico xx");
            int mesNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite em que dia você nasceu");
            int diaNascimento = int.Parse(Console.ReadLine());
            
            // Input de data atual
            string diaAtuals = DateTime.Now.Day.ToString();
            string mesAtuals = DateTime.Now.Month.ToString();
            string anoAtuals = DateTime.Now.Year.ToString();
            
            // Conversão de String para Int
            int diaAtual = Int16.Parse(diaAtuals);
            int mesAtual = Int16.Parse(mesAtuals);
            int anoAtual = Int16.Parse(anoAtuals);
            
            // Calculadora de idade
            int idadeDia = diaAtual - diaNascimento;
            int idadeMes = mesAtual - mesNascimento;
            int idadeAno = anoAtual - anoNascimento;

            if (mesAtual < mesNascimento)
            {
                idadeAno = idadeAno - 1;
            }
            int semanasIdade = idadeAno / 52;
            Console.WriteLine("Sua idade é de " + idadeAno + " Ou, " + semanasIdade + "semanas de idade");
        }
    }
}
