namespace Practico4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LDesde = new Label();
            LHasta = new Label();
            LListaNumeros = new Label();
            LBListaNumeros = new ListBox();
            TDesde = new TextBox();
            THasta = new TextBox();
            BGenerarFuncion = new Button();
            BNumerosPares = new Button();
            BNumerosImpares = new Button();
            BNumerosPrimos = new Button();
            LErrorDesde = new Label();
            LErrorHasta = new Label();
            BLimpiarLista = new Button();
            SuspendLayout();
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(121, 84);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(39, 15);
            LDesde.TabIndex = 0;
            LDesde.Text = "Desde";
            LDesde.Click += label1_Click;
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(121, 134);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 1;
            LHasta.Text = "Hasta";
            LHasta.Click += LHasta_Click;
            // 
            // LListaNumeros
            // 
            LListaNumeros.AutoSize = true;
            LListaNumeros.Location = new Point(508, 52);
            LListaNumeros.Name = "LListaNumeros";
            LListaNumeros.Size = new Size(99, 15);
            LListaNumeros.TabIndex = 2;
            LListaNumeros.Text = "Lista de Numeros";
            // 
            // LBListaNumeros
            // 
            LBListaNumeros.FormattingEnabled = true;
            LBListaNumeros.ItemHeight = 15;
            LBListaNumeros.Location = new Point(375, 81);
            LBListaNumeros.Name = "LBListaNumeros";
            LBListaNumeros.Size = new Size(364, 304);
            LBListaNumeros.TabIndex = 3;
            // 
            // TDesde
            // 
            TDesde.Location = new Point(166, 81);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(82, 23);
            TDesde.TabIndex = 4;
            TDesde.TextChanged += TDesde_TextChanged;
            TDesde.KeyPress += TDesde_KeyPress;
            // 
            // THasta
            // 
            THasta.Location = new Point(166, 131);
            THasta.Name = "THasta";
            THasta.Size = new Size(82, 23);
            THasta.TabIndex = 5;
            THasta.KeyPress += THasta_KeyPress;
            // 
            // BGenerarFuncion
            // 
            BGenerarFuncion.Location = new Point(121, 177);
            BGenerarFuncion.Name = "BGenerarFuncion";
            BGenerarFuncion.Size = new Size(127, 24);
            BGenerarFuncion.TabIndex = 6;
            BGenerarFuncion.Text = "Generar Funcion";
            BGenerarFuncion.UseVisualStyleBackColor = true;
            BGenerarFuncion.Click += BGenerarFuncion_Click;
            // 
            // BNumerosPares
            // 
            BNumerosPares.Location = new Point(121, 218);
            BNumerosPares.Name = "BNumerosPares";
            BNumerosPares.Size = new Size(127, 23);
            BNumerosPares.TabIndex = 7;
            BNumerosPares.Text = "Numeros Pares";
            BNumerosPares.UseVisualStyleBackColor = true;
            BNumerosPares.Click += BNumerosPares_Click;
            // 
            // BNumerosImpares
            // 
            BNumerosImpares.Location = new Point(121, 258);
            BNumerosImpares.Name = "BNumerosImpares";
            BNumerosImpares.Size = new Size(127, 23);
            BNumerosImpares.TabIndex = 8;
            BNumerosImpares.Text = "Numeros Impares";
            BNumerosImpares.UseVisualStyleBackColor = true;
            BNumerosImpares.Click += BNumerosImpares_Click;
            // 
            // BNumerosPrimos
            // 
            BNumerosPrimos.Location = new Point(121, 298);
            BNumerosPrimos.Name = "BNumerosPrimos";
            BNumerosPrimos.Size = new Size(127, 23);
            BNumerosPrimos.TabIndex = 9;
            BNumerosPrimos.Text = "Numeros Primos";
            BNumerosPrimos.UseVisualStyleBackColor = true;
            BNumerosPrimos.Click += BNumerosPrimos_Click;
            // 
            // LErrorDesde
            // 
            LErrorDesde.AutoSize = true;
            LErrorDesde.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LErrorDesde.ForeColor = Color.Red;
            LErrorDesde.Location = new Point(166, 107);
            LErrorDesde.Name = "LErrorDesde";
            LErrorDesde.Size = new Size(0, 13);
            LErrorDesde.TabIndex = 10;
            // 
            // LErrorHasta
            // 
            LErrorHasta.AutoSize = true;
            LErrorHasta.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LErrorHasta.ForeColor = Color.Red;
            LErrorHasta.Location = new Point(166, 157);
            LErrorHasta.Name = "LErrorHasta";
            LErrorHasta.Size = new Size(0, 13);
            LErrorHasta.TabIndex = 11;
            // 
            // BLimpiarLista
            // 
            BLimpiarLista.Location = new Point(643, 391);
            BLimpiarLista.Name = "BLimpiarLista";
            BLimpiarLista.Size = new Size(96, 23);
            BLimpiarLista.TabIndex = 12;
            BLimpiarLista.Text = "Limpiar lista";
            BLimpiarLista.UseVisualStyleBackColor = true;
            BLimpiarLista.Click += BLimpiarLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BLimpiarLista);
            Controls.Add(LErrorHasta);
            Controls.Add(LErrorDesde);
            Controls.Add(BNumerosPrimos);
            Controls.Add(BNumerosImpares);
            Controls.Add(BNumerosPares);
            Controls.Add(BGenerarFuncion);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Controls.Add(LBListaNumeros);
            Controls.Add(LListaNumeros);
            Controls.Add(LHasta);
            Controls.Add(LDesde);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LDesde;
        private Label LHasta;
        private Label LListaNumeros;
        private ListBox LBListaNumeros;
        private TextBox TDesde;
        private TextBox THasta;
        private Button BGenerarFuncion;
        private Button BNumerosPares;
        private Button BNumerosImpares;
        private Button BNumerosPrimos;
        private Label LErrorDesde;
        private Label LErrorHasta;
        private Button BLimpiarLista;
    }
}