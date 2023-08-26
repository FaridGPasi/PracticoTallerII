using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Practico2.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Practico2
{
    public partial class PequeñoFormulario : Form
    {
        public PequeñoFormulario()
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

            if (string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(TNombre.Text) || string.IsNullOrEmpty(TApellido.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios (*)", "Error",
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
                TTelefono.Clear();
                CBMastercard.Checked = false;
                CBNaranja.Checked = false;
                CBVisa.Checked = false;
                RBMujer.Checked = false; 
                RBVaron.Checked = true;
                MessageBox.Show("El cliente " + TApellido.Text + " " + TNombre.Text + " se elimino correctamente", "Eliminar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            PBCliente.Image = null;
            PBCliente.BackgroundImage = Properties.Resources.Icons_Land_Medical_People_Patient_Male_256;
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            PBCliente.BackgroundImage = Properties.Resources.Icons_Land_Medical_People_Patient_Female_256;
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}