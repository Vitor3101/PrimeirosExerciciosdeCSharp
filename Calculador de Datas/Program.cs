using System;

namespace Calculador_de_Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de Datas...");
            Console.WriteLine("Para começar, digite a sua idade. E a magica acontecerá!!");
            int idade = int.Parse(Console.ReadLine());
            int meses = idade * 12;
            int dias = idade * 360;
            int horas = idade * 8640;
            int minutos = idade * 207360;
            Console.WriteLine("Informações respectivas a sua idade em: Meses, Dias, Horas e Minutos \n" + meses + " meses\n" + dias + " dias\n" + horas + " Horas\n" + minutos + " minutos\n");
        }
    }
}
