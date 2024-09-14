using II_Ejercicio2_BinarySearch.Models;
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

namespace II_Ejercicio2_BinarySearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona p1 = null;
        Persona p2 = null;
        ArrayList psas = new ArrayList() { new Persona("Marti", 47175513), new Persona("Julio", 24264435), new Persona("Andrea", 45112413), new Persona("Mario", 56879332), new Persona("Gustavo", 43221687), new Persona("Jesus", 65777432) };
        private void btnVerAlta_Click(object sender, EventArgs e)
        {
            tbMostrar.Clear();
            int dni = Convert.ToInt32(tbDNI.Text);
            psas.Sort();
            p1 = new Persona(dni);
            int idx = psas.BinarySearch(p1);
            if (idx >= 0)
            {
                tbMostrar.Text += $"{(Persona)psas[idx]}";
            }
            else
            {
                FormDatos dat = new FormDatos();
                dat.tbDNI.Text = Convert.ToString(dni);
                dat.tbDNI.Enabled = false;
                if (dat.ShowDialog() == DialogResult.OK)
                {
                    string nombre = dat.tbNombre.Text;
                    p2 = new Persona(nombre, dni);
                    psas.Add(p2);
                    MessageBox.Show($"¡{nombre} ha sido agregado con éxito!");
                }   
            }
            tbDNI.Clear();
        }
    }
}
