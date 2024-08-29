using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaz.Models
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
        public override string ToString()
        {
            return $"Círculo: {CalcularArea():F2}";
        }
        public override double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
