using System;
using System.Globalization;

namespace Modulo01EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;
            double n1, n2, n3;

            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno = new Aluno(nome, n1, n2, n3);

            Console.WriteLine("NOTA FINAL: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.VerificarNota() == true)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine($"FALTARAM {aluno.NotaParaPassar().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }

        }
    }
}
