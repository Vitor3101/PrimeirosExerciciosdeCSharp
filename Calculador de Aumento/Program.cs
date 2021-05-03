using System;

namespace Calculador_de_Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de Aumento...");
            Console.WriteLine("Digite aqui o seu salário atual no formato: xxxx ou xxx");
            int salario = int.Parse(Console.ReadLine());

            if (salario < 500)
            {
                salario = salario / 100;
                salario = salario * 130;
                Console.WriteLine("Seu salário agora depois do aumento é de: " + salario + " reais");
            }
            else
            {
                Console.WriteLine("Seu aumento não está disponível seguindo os critérios o banco de dados, Pois o seu salário é superior ou igual a 500 Reais");
            }
        }
    }
}
