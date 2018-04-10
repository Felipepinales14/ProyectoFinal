using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo
{
    public partial class Trabajo : Form
    {
        public Trabajo()
        {
            InitializeComponent();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             //Declarando las variables
            double presion;
            double tempreratura;
            double volumen;
            double resultado;
            

            //comvirtiendolas en txt


            presion = double.Parse(txtpresion.Text);
            tempreratura = double.Parse(txttemperatura.Text);
            volumen = double.Parse(txtvolumen.Text);

            //operacion


            resultado = (presion * volumen) / (0.37 * (tempreratura + 460));

            //Salida

            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //limpiando

            txtpresion.Clear();
            txtresultado.Clear();
            txttemperatura.Clear();
            txtvolumen.Clear();
            txtpresion.Focus();
        }
    }
}
