using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Mejorado.Models
{
    public class Circulo : Figura
    {
        public double Radio { get; private set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            double res = Math.PI * Math.Pow(Radio, 2);
            return res;
        }

        public override double CalcularPerimetro()
        {
            double res = Math.PI * (Radio * 2);
            return res;
        }

        public override string ToString()
        {
            return $"Círculo: - Area: {CalcularArea():F2} - Perímetro: {CalcularPerimetro():F2}";
        }
    }
}
