using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Mejorado.Models
{
    public class Rectangulo : Figura
    {
        public double Largo { get; private set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public override double CalcularArea()
        {
            double area = Largo * Ancho;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perim = (Largo + Ancho) * 2;
            return perim;
        }

        public override string ToString()
        {
            return $"Rectangulo: - Area: {CalcularArea():F2} - Perímetro: {CalcularPerimetro():F2}";
        }

    }
}
