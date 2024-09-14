using II_Ejercicio1_Sort.Models;
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

namespace II_Ejercicio1_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList psas = new ArrayList() { new Persona(47175513), new Persona(24264435), new Persona(45112413), new Persona(56879332), new Persona(43221687), new Persona(65777432) };
        private void btnListar_Click(object sender, EventArgs e)
        {
            tbListar.Text += "Lista Desordenada\r\n\r\n";
            foreach(Persona p in psas)
            {
                tbListar.Text+=$"{p.ToString()}\r\n";
            }

            psas.Sort();

            tbListar.Text += "\r\n\r\nLista Ordenada\r\n\r\n";

            foreach (Persona p in psas)
            {
                tbListar.Text+= $"{p.ToString()}\r\n";
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbBuscar.Text);
            tbListar.Text += $"\r\n\r\nBuscando DNI {dni}";
            psas.Sort();
            int idx= psas.BinarySearch(new Persona(dni));
            if (idx >= 0)
            {
                tbListar.Text += $"\r\n\r\nPersona encontrada: {psas[idx].ToString()}";
            }
            else
            {
                tbListar.Text += "\r\n\r\nPersona no encontrada";
            }

        }
    }
}
