using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaz.Models
{
    public class Rectangulo : Figura, IComparable
    { 
        public double LadoUno { get; set; }
        public double LadoDos { get; set; }
        public override double CalcularArea()
        {
            double area = LadoUno * LadoDos;
            return area;
        }

        public override double CalcularPerimetro()
        {
            return (LadoUno+LadoDos)*2;
        }

        public Rectangulo(double largo, double ancho) 
        {
            LadoUno = largo;
            LadoDos = ancho;
        }

        public override string ToString()
        {
            return $"Rectangulo: - Area: {CalcularArea():F2} - Perímetro: {CalcularPerimetro():F2}";
        }

        public int CompareTo(object obj)
        {
            Figura rect = obj as Figura;
            if (rect != null)
            {
                return this.CalcularArea().CompareTo(rect.CalcularArea());
            }
            return 1;
        }
    }
}
