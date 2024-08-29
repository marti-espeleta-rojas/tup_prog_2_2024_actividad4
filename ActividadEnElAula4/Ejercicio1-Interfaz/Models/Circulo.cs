using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaz.Models
{
    public class Circulo : Figura, IComparable
    {
        public double Radio { get; private set; }
        public Circulo(double radio) 
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            double res = Math.PI * Math.Pow(Radio, 2);
            return res;
        }
        public override string ToString()
        {
            return $"Círculo: {CalcularArea():F2}";
        }
        public double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            Circulo circulo = obj as Circulo;
            double area = CalcularArea();
            if (circulo != null)
            {
                return area.CompareTo(circulo.CalcularArea());
            }
            return 1;
        }
    }
}
