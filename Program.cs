using System;

namespace CalcularArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Digite o valor de Largura: ");
            triangulo.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor da Altura: ");
            triangulo.Altura = double.Parse(Console.ReadLine());

            double area = triangulo.CalcularArea();
            Console.WriteLine($"A área é: {area}.");

            double perimetro = triangulo.CalcularPerimetro();
            Console.WriteLine($"O perímetro é {perimetro}.");

            double diagonal = triangulo.CalcularDiagonal();
            Console.WriteLine($"A Diagonal é: {diagonal}");
        }
    }
}

