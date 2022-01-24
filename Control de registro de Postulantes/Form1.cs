using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_registro_de_Postulantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tsRegistrar_Click(object sender, EventArgs e)
        {
           string postulante = txtPostulante.Text;
            string carrera = cbCarrera.Text;
            double puntaje = double.Parse(txtPuntaje.Text);

            string condicion = "Ingresa";
            double puntos = 0;
        }
    }
}
