using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmCmparaPolegadas : Form
    {
        public frmCmparaPolegadas()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double centimetros = Convert.ToDouble(txtCentimetros.Text);
            double resultado = centimetros / 2.54;
            txtPolegadas.Text = Convert.ToString(resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCentimetros.Text = "";
            txtPolegadas.Text = "";
        }
    }
}
