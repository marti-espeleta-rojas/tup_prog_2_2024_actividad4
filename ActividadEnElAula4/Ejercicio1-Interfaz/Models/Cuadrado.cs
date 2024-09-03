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

        }

        public override string ToString()
        {
            return $"Cuadrado: Area: {CalcularArea():F2}\r\n Perimetro: {CalcularPerimetro():F2}";
        }


    }
}
