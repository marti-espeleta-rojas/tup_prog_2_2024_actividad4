using II_Ejercicio1_Sort.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        ArrayList psas = new ArrayList() { new Persona("Marti", 47175513), new Persona("Julio", 24264435), new Persona("Andrea", 45112413), new Persona("Mario", 56879332), new Persona("Gustavo", 43221687), new Persona("Jesus", 65777432) };
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

            int dni1 = 24264435;
            tbListar.Text+= $"\r\n\r\nBuscando DNI {dni1}";
            psas.Sort();
            BuscarPersona(psas.BinarySearch(new Persona(dni1)));

            int dni2 = 44354232;
            tbListar.Text += $"\r\n\r\nBuscando DNI {dni2}";
            psas.Sort();
            BuscarPersona(psas.BinarySearch(new Persona(dni2)));
        }
        public void BuscarPersona(int idx)
        {
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
