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
    public partial class frmConversor : Form
    {
        
        public frmConversor()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double celcius = Convert.ToDouble(txtCelcius.Text);
            double resultado = celcius * 1.8 + 32;
            txtFahrenheit.Text = Convert.ToString(resultado);
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelcius.Text = "";
            txtFahrenheit.Text = "";
        }
    }
}
