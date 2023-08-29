namespace Practico4
{
    public partial class Form1 : Form
    {
        public int desde;
        public int hasta;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LHasta_Click(object sender, EventArgs e)
        {

        }

        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TDesde.Text) || string.IsNullOrEmpty(THasta.Text))
            {
                MessageBox.Show("Debe ingresar los dos numeros", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                desde = int.Parse(TDesde.Text);
                hasta = int.Parse(THasta.Text);
                if (hasta <= desde)
                {
                    MessageBox.Show("El segundo numero debe ser mayor al primero", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    for (int i = desde; i <= hasta; i++)
                    {
                        LBListaNumeros.Items.Add(i);
                    }
                }
            }
            
            
        }

        private void TDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                LErrorDesde.Text = "solo numeros";
            }
            else
            {
                LErrorDesde.Text = "";
            }

        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                LErrorHasta.Text = "solo numeros";
            }
            else
            {
                LErrorHasta.Text = "";
            }
        }

        private void LErrorDesde_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}