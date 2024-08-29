using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaz.Models
{
    public class Rectangulo : Figura 
    { 
        public double LadoUno { get; set; }
        public double LadoDos { get; set; }
        double area = 0;
        double perimetro = 0;
        public double CalcularArea()
        {
            area = LadoUno * LadoDos;
            return area;
        }

        public double CalcularPerimetro()
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
            return $"Rectangulo: {CalcularArea():F2}"; ;
        }
    }
}
