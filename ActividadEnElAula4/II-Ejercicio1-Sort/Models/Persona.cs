using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II_Ejercicio1_Sort.Models
{
    public class Persona : IComparable
    {
        public string Nombre { get; private set; }
        public int DNI { get; private set; }

        public Persona(int dni)
        {
            DNI = dni;
        }
        public override string ToString()
        {
            return $"{DNI}";
        }

        public int CompareTo(object obj)
        {
            Persona p = obj as Persona;
            if (p != null)
            {
                return this.DNI.CompareTo(p.DNI);
            }
            return 1;
        }
    }
}
