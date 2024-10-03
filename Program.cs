using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadradinho = new Quadrado();

            Console.WriteLine("Digite o valor da aresta do quadrado: ");
            int aresta = int.Parse(Console.ReadLine());

            quadradinho.SetAresta(aresta);
            quadradinho.CalcularA();

            Console.WriteLine("A área é: " + quadradinho.GetArea());
            Console.ReadLine();
        }
    }
}
