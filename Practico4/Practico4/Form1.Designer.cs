namespace Practico4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BGenerarFuncion = new System.Windows.Forms.Button();
            this.BNumerosPares = new System.Windows.Forms.Button();
            this.BNumerosImpares = new System.Windows.Forms.Button();
            this.BNumerosPrimos = new System.Windows.Forms.Button();
            this.BLimpiarLista = new System.Windows.Forms.Button();
            this.LBListaNumeros = new System.Windows.Forms.ListBox();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.LListaNumeros = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.LErrorDesde = new System.Windows.Forms.Label();
            this.LErrorHasta = new System.Windows.Forms.Label();
            this.CGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BLimpiarGrafico = new System.Windows.Forms.Button();
            this.BGenerarGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // BGenerarFuncion
            // 
            this.BGenerarFuncion.Location = new System.Drawing.Point(39, 131);
            this.BGenerarFuncion.Name = "BGenerarFuncion";
            this.BGenerarFuncion.Size = new System.Drawing.Size(127, 23);
            this.BGenerarFuncion.TabIndex = 0;
            this.BGenerarFuncion.Text = "Generar Funcion";
            this.BGenerarFuncion.UseVisualStyleBackColor = true;
            this.BGenerarFuncion.Click += new System.EventHandler(this.BGenerarFuncion_Click);
            // 
            // BNumerosPares
            // 
            this.BNumerosPares.Location = new System.Drawing.Point(39, 160);
            this.BNumerosPares.Name = "BNumerosPares";
            this.BNumerosPares.Size = new System.Drawing.Size(127, 23);
            this.BNumerosPares.TabIndex = 1;
            this.BNumerosPares.Text = "Numeros Pares";
            this.BNumerosPares.UseVisualStyleBackColor = true;
            this.BNumerosPares.Click += new System.EventHandler(this.BNumerosPares_Click);
            // 
            // BNumerosImpares
            // 
            this.BNumerosImpares.Location = new System.Drawing.Point(39, 189);
            this.BNumerosImpares.Name = "BNumerosImpares";
            this.BNumerosImpares.Size = new System.Drawing.Size(127, 23);
            this.BNumerosImpares.TabIndex = 2;
            this.BNumerosImpares.Text = "Numeros Impares";
            this.BNumerosImpares.UseVisualStyleBackColor = true;
            this.BNumerosImpares.Click += new System.EventHandler(this.BNumerosImpares_Click);
            // 
            // BNumerosPrimos
            // 
            this.BNumerosPrimos.Location = new System.Drawing.Point(39, 218);
            this.BNumerosPrimos.Name = "BNumerosPrimos";
            this.BNumerosPrimos.Size = new System.Drawing.Size(127, 23);
            this.BNumerosPrimos.TabIndex = 3;
            this.BNumerosPrimos.Text = "Numeros Primos";
            this.BNumerosPrimos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BNumerosPrimos.UseVisualStyleBackColor = true;
            this.BNumerosPrimos.Click += new System.EventHandler(this.BNumerosPrimos_Click);
            // 
            // BLimpiarLista
            // 
            this.BLimpiarLista.Location = new System.Drawing.Point(283, 373);
            this.BLimpiarLista.Name = "BLimpiarLista";
            this.BLimpiarLista.Size = new System.Drawing.Size(75, 23);
            this.BLimpiarLista.TabIndex = 4;
            this.BLimpiarLista.Text = "Limpiar Lista";
            this.BLimpiarLista.UseVisualStyleBackColor = true;
            this.BLimpiarLista.Click += new System.EventHandler(this.BLimpiarLista_Click);
            // 
            // LBListaNumeros
            // 
            this.LBListaNumeros.FormattingEnabled = true;
            this.LBListaNumeros.Location = new System.Drawing.Point(238, 38);
            this.LBListaNumeros.Name = "LBListaNumeros";
            this.LBListaNumeros.Size = new System.Drawing.Size(120, 329);
            this.LBListaNumeros.TabIndex = 5;
            this.LBListaNumeros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(36, 41);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 6;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(36, 79);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 7;
            this.LHasta.Text = "Hasta";
            // 
            // LListaNumeros
            // 
            this.LListaNumeros.AutoSize = true;
            this.LListaNumeros.Location = new System.Drawing.Point(255, 22);
            this.LListaNumeros.Name = "LListaNumeros";
            this.LListaNumeros.Size = new System.Drawing.Size(87, 13);
            this.LListaNumeros.TabIndex = 8;
            this.LListaNumeros.Text = "Lista de numeros";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(95, 38);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(71, 20);
            this.TDesde.TabIndex = 9;
            this.TDesde.TextChanged += new System.EventHandler(this.TDesde_TextChanged);
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(95, 76);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(71, 20);
            this.THasta.TabIndex = 10;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress);
            // 
            // LErrorDesde
            // 
            this.LErrorDesde.AutoSize = true;
            this.LErrorDesde.ForeColor = System.Drawing.Color.Red;
            this.LErrorDesde.Location = new System.Drawing.Point(95, 60);
            this.LErrorDesde.Name = "LErrorDesde";
            this.LErrorDesde.Size = new System.Drawing.Size(0, 13);
            this.LErrorDesde.TabIndex = 11;
            // 
            // LErrorHasta
            // 
            this.LErrorHasta.AutoSize = true;
            this.LErrorHasta.ForeColor = System.Drawing.Color.Red;
            this.LErrorHasta.Location = new System.Drawing.Point(95, 99);
            this.LErrorHasta.Name = "LErrorHasta";
            this.LErrorHasta.Size = new System.Drawing.Size(0, 13);
            this.LErrorHasta.TabIndex = 12;
            // 
            // CGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.CGrafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CGrafico.Legends.Add(legend2);
            this.CGrafico.Location = new System.Drawing.Point(401, 38);
            this.CGrafico.Name = "CGrafico";
            this.CGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Desde / Hasta";
            this.CGrafico.Series.Add(series2);
            this.CGrafico.Size = new System.Drawing.Size(355, 329);
            this.CGrafico.TabIndex = 13;
            this.CGrafico.Text = "chart1";
            this.CGrafico.Click += new System.EventHandler(this.CGrafico_Click);
            // 
            // BLimpiarGrafico
            // 
            this.BLimpiarGrafico.Location = new System.Drawing.Point(648, 373);
            this.BLimpiarGrafico.Name = "BLimpiarGrafico";
            this.BLimpiarGrafico.Size = new System.Drawing.Size(108, 23);
            this.BLimpiarGrafico.TabIndex = 14;
            this.BLimpiarGrafico.Text = "Limpiar Grafico";
            this.BLimpiarGrafico.UseVisualStyleBackColor = true;
            this.BLimpiarGrafico.Click += new System.EventHandler(this.BLimpiarGrafico_Click);
            // 
            // BGenerarGrafico
            // 
            this.BGenerarGrafico.Location = new System.Drawing.Point(364, 174);
            this.BGenerarGrafico.Name = "BGenerarGrafico";
            this.BGenerarGrafico.Size = new System.Drawing.Size(31, 52);
            this.BGenerarGrafico.TabIndex = 15;
            this.BGenerarGrafico.Text = ">>";
            this.BGenerarGrafico.UseVisualStyleBackColor = true;
            this.BGenerarGrafico.Click += new System.EventHandler(this.BGenerarGrafico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BGenerarGrafico);
            this.Controls.Add(this.BLimpiarGrafico);
            this.Controls.Add(this.CGrafico);
            this.Controls.Add(this.LErrorHasta);
            this.Controls.Add(this.LErrorDesde);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.LListaNumeros);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.LBListaNumeros);
            this.Controls.Add(this.BLimpiarLista);
            this.Controls.Add(this.BNumerosPrimos);
            this.Controls.Add(this.BNumerosImpares);
            this.Controls.Add(this.BNumerosPares);
            this.Controls.Add(this.BGenerarFuncion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGenerarFuncion;
        private System.Windows.Forms.Button BNumerosPares;
        private System.Windows.Forms.Button BNumerosImpares;
        private System.Windows.Forms.Button BNumerosPrimos;
        private System.Windows.Forms.Button BLimpiarLista;
        private System.Windows.Forms.ListBox LBListaNumeros;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LListaNumeros;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Label LErrorDesde;
        private System.Windows.Forms.Label LErrorHasta;
        private System.Windows.Forms.DataVisualization.Charting.Chart CGrafico;
        private System.Windows.Forms.Button BLimpiarGrafico;
        private System.Windows.Forms.Button BGenerarGrafico;
    }
}

