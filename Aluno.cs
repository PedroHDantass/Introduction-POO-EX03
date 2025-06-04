using System;
namespace Modulo01EX03
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double N1, N2, N3;

        public Aluno()
        {

        }
        public Aluno(string nome, double n1, double n2, double n3)
        {
            Nome = nome;
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public double  NotaFinal()
        {
            return N1 + N2 + N3;
           
        }
        public bool VerificarNota()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaParaPassar()
        {
            return 60.0 - NotaFinal();
        }
    }
}
