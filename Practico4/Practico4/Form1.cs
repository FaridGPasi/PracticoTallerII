using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public int desde;
        public int hasta;

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }

            // Es primo :)
            return true;
        }
        public Form1()
        {
            InitializeComponent();
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

        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TDesde.Text) || string.IsNullOrEmpty(THasta.Text))
            {
                MessageBox.Show("Debe ingresar los dos numeros", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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

        private void BNumerosPares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TDesde.Text) || string.IsNullOrEmpty(THasta.Text))
            {
                MessageBox.Show("Debe ingresar los dos numeros", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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

                        if (i % 2 == 0)
                        {
                            LBListaNumeros.Items.Add(i);
                        }
                    }
                }
            }
        }

        private void BNumerosImpares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TDesde.Text) || string.IsNullOrEmpty(THasta.Text))
            {
                MessageBox.Show("Debe ingresar los dos numeros", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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
                        if (i % 2 != 0)
                        {
                            LBListaNumeros.Items.Add(i);
                        }
                    }
                }
            }
        }

        private void BNumerosPrimos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TDesde.Text) || string.IsNullOrEmpty(THasta.Text))
            {
                MessageBox.Show("Debe ingresar los dos numeros", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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
                        if (EsPrimo(i))
                        {
                            LBListaNumeros.Items.Add(i);
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BLimpiarLista_Click(object sender, EventArgs e)
        {
            LBListaNumeros.Items.Clear();
        }

        private void BGenerarGrafico_Click(object sender, EventArgs e)
        {
            if (LBListaNumeros.Items.Count > 0)
            {
                for (int i = 0; i <= LBListaNumeros.Items.Count - 1; i++)
                {
                    CGrafico.Series["Desde / Hasta"].Points.AddXY(LBListaNumeros.Items[i], LBListaNumeros.Items[i]);
                   
                }
            }
            else {
                MessageBox.Show("No hay numeros en la lista", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CGrafico_Click(object sender, EventArgs e)
        {

        }

        private void BLimpiarGrafico_Click(object sender, EventArgs e)
        {
            CGrafico.Series["Desde / Hasta"].Points.Clear();
        }
    }
}
