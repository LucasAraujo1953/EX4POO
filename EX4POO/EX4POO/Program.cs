using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do triângulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do triângulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(baseTriangulo, altura);

            double area = triangulo.CalcularArea();
            Console.WriteLine($"A área do triângulo é: {area}");
        }
    }
}
