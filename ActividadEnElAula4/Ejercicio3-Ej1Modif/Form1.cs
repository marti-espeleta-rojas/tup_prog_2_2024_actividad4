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

namespace Ejercicio3_Ej1Modif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPrueba_Click_1(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList() { new Circulo(5), new Rectangulo(6.4, 9), new Cuadrado(7.4), new Circulo(8.3), new Rectangulo(5.4, 3) };
            foreach (var v in lista)
            {
                tbPrueba.Text += v.ToString() + "\r\n\r\n";
            }


            tbPrueba.Text += "Lista ordenada por área\r\n\r\n";

            lista.Sort();

            foreach (var v in lista)
            {
                tbPrueba.Text += v.ToString() + "\r\n\r\n";
            }
        }
    }
}
