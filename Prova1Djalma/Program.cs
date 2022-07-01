using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1Djalma
{
    class Program
    {
        static void Main(string[] args)
        {
            double n2, n3, n4, media;
            string nome;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a sua nota de trabalho");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota da prova 1");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota de prova 2");
            n4 = double.Parse(Console.ReadLine());

            media = ((n2 + n3 + n4) / 3);

            if (media > 8.5)
            {
                Console.WriteLine(" Conceito final : A");
            }
            if (media >= 7.0 == media <= 8.4)
            {
                Console.WriteLine(" Conceito final : B");
            }
            if (media >= 6.0 == media <= 6.9)
            {
                Console.WriteLine(" Conceito final : C");
            }
            if (media >= 0.1 == media <= 5.9)
            {
                Console.WriteLine(" Conceito final : D");
            }
            if (media == 0.0)
            {
                Console.WriteLine(" Conceito final : E");
            }
            Console.ReadKey();
        }
    }
}
