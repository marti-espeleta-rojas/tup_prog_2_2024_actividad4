using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Mejorado.Models
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado):base(lado, lado)
        {

        }

        public override string ToString()
        {
            return $"Cuadrado: - Area: {CalcularArea():F2} - Perimetro: {CalcularPerimetro():F2}";
        }
    }
}
