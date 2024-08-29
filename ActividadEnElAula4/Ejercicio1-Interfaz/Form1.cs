using Ejercicio1_Interfaz.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            ArrayList sorts = new ArrayList();

            /* Figura rec = new Rectangulo(3,4);
             Figura cuad1 = new Cuadrado(3.5);
             Figura cir1 = new Circulo(2);
             Figura cuad2 = new Cuadrado(1.5);
             Figura cir2 = new Circulo(9.1);
             sorts.Add(rec);
             sorts.Add(cuad1);
             sorts.Add(cir1);
             sorts.Add(cuad2);
             sorts.Add(cir2);

             foreach (Figura f in sorts)
             {
                 tbPrueba.Text += f.ToString();
             }

             sorts.Sort();

             foreach (Figura f in sorts)
             {
                 tbPrueba.Text += f.ToString();
             }*/
            ArrayList lista = new ArrayList();
            lista.Add(new Persona(213435, "Fili"));
            int dni;
            dni=Convert.ToInt32(textBox1.Text);

            int idx = lista.BinarySearch(new Persona(dni));
            if (idx<0)
            {
                Persona p = lista[idx] as Persona;
                tbPrueba.Text += $"{p.DNI}";
            }
        }
    }

    internal class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int DNI, string Nombre)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
        }

        public Persona(int DNI)
        {
            this.DNI = DNI;
        }
    }
}
