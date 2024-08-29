using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaz.Models
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado):base(lado, lado)
        {
            LadoUno = lado;
        }

        public double CalcularArea()
        {
            double area = 0;
            area = LadoUno * LadoUno;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 0;
            perimetro = LadoUno * 4;
            return perimetro;
        }
        public override string ToString()
        {
            return $"Cuadrado:\r\n Area: {CalcularArea():F2}\r\n Perimetro: {CalcularPerimetro():F2}";
        }


    }
}
