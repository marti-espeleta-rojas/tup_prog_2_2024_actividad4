using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Mejorado.Models
{
    public abstract class Figura : IComparable, IFigura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public int CompareTo(object obj)
        {
            Figura fig = obj as Figura;
            if (fig != null)
            {
                return this.CalcularArea().CompareTo(fig.CalcularArea());
            }
            return 1;
        }
    }
}
