namespace calculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void pgbCarregamento_Click(object sender, EventArgs e)
        {

        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
              
            pgbCarregamento.Value = pgbCarregamento.Value + 1;
            

            if (pgbCarregamento.Value == 100)
            {
                tmrTempo.Enabled = false;

                this.Hide();

                new frmCalculadora().ShowDialog();

            }
        }

        private void calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
