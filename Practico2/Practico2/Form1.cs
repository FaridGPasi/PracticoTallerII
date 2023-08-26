using Microsoft.VisualBasic;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void LModificar_Click(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            
            if ( string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(TNombre.Text) || string.IsNullOrEmpty(TApellido.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar insercion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = TApellido.Text + " " + TNombre.Text;
                    MessageBox.Show("El cliente " + TApellido.Text + " " + TNombre.Text + " se inserto correctamente", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask;

            ask = MessageBox.Show("Esta a punto de eliminar el cliente: " + TApellido.Text + " " + TNombre.Text, "Confirmar eliminacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {
                LModificar.Text = "modificar";
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                MessageBox.Show("El cliente " + TApellido.Text + " " + TNombre.Text + " se elimino correctamente", "Eliminar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no es Control o algun caracter no numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) ;
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}