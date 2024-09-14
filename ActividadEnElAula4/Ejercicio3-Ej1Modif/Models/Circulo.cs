using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaz.Models
{
    public class Circulo : IFigura, IComparable
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
            return $"Círculo: - Area: {CalcularArea():F2} - Perímetro: {CalcularPerimetro():F2}";
        }
        public double CalcularPerimetro()
        {
            double res = Math.PI * (Radio*2);
            return res;
        }

        public int CompareTo(object obj)
        {
            IFigura fig = obj as IFigura;
            if (fig != null)
                return this.CalcularArea().CompareTo(fig.CalcularArea()); //se implementa el CalcularArea() del círculo actual y el fig.CalcularArea() según el tipo de objeto de IFigura
            return 1; 
        }
    }
}
