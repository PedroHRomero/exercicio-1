using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nt, n1, n2, notatotal, media;
            Console.WriteLine("Escreva o nome do aluno");
            Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("CASO A NOTA CONTENHA UMA CASA DECIMAL UTILIZAR VIRGULA!!");

            Console.WriteLine();

            Console.WriteLine("Digite a Nota do Trabalho");
            nt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota da Pimeira Prova");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota da Segunda Prova");
            n2 = Convert.ToDouble(Console.ReadLine());

            notatotal = nt + n1 + n2;
            media = notatotal / 3;

            if (media >= 8.5)
            {
                Console.WriteLine("média final = " +  media);
                Console.WriteLine("Conceito A");
            }
            else if (media >= 7)
            {
                Console.WriteLine("média final = " +  media);
                Console.WriteLine("Conceito B");
            }
            else if (media >= 6)
            {
                Console.WriteLine("média final = " +  media);
                Console.WriteLine("Conceito C");
            }
            else if (media >= 0.1)
            {
                Console.WriteLine("média final = " +  media);
                Console.WriteLine("Conceito D");
            }
            else if (media >= 0.0)
            {
                Console.WriteLine("média final = " +  media);
                Console.WriteLine("Conceito E");
            }
            Console.ReadKey();
        }
    }
}
