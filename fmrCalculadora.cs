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
    public partial class fmrCalculadora : Form
    {
        float numero1 = 0;
        string operacao = "";

        public fmrCalculadora()
        {
            InitializeComponent();
        }

        private void fmrCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (this.operacao == "soma")
            {
                float resultado = numero1 + Convert.ToSingle(txtAparecer.Text);
                //txtAparecer.Text = Convert.ToString("hello word");
                txtAparecer.Text = resultado.ToString();
            }

            if (operacao == "subtrair")
            {
                float resultado = numero1 - Convert.ToSingle(txtAparecer.Text);
                txtAparecer.Text = resultado.ToString();
            }

            if (operacao == "multiplicação")
            {
                float resultado = numero1 * Convert.ToSingle(txtAparecer.Text);
                txtAparecer.Text = resultado.ToString();
            }

            if (operacao == "divisão")
            {
                float resultado = numero1 / Convert.ToSingle(txtAparecer.Text);
                txtAparecer.Text = resultado.ToString();
            }

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "1";
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "2";
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "3";
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "4";
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "5";
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "6";
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "7";
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "8";
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = txtAparecer.Text + "0";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToSingle(txtAparecer.Text);
            operacao = "soma";
            txtAparecer.Clear();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToSingle(txtAparecer.Text);
            operacao = "subtrair";
            txtAparecer.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToSingle(txtAparecer.Text);
            operacao = "multiplicação";
            txtAparecer.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToSingle(txtAparecer.Text);
            operacao = "divisão";
            txtAparecer.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAparecer.Text = "";
        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrConversor formularioConversor = new fmrConversor();
            formularioConversor.ShowDialog();
        }

        private void fmrCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
