using System;

namespace CalcularArea
{
    class Triangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            double area = Altura * Largura;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

        public double CalcularDiagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return diagonal;
        }
    }
}
