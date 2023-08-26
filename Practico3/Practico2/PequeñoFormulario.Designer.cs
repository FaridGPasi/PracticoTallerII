namespace Practico2
{
    partial class PequeñoFormulario
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
            LNyA = new Label();
            LModificar = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            panel1 = new Panel();
            CBMastercard = new CheckBox();
            CBVisa = new CheckBox();
            CBNaranja = new CheckBox();
            LTarjetaCredito = new Label();
            TTelefono = new TextBox();
            LTelefono = new Label();
            BSalir = new Button();
            LNuevoCliente = new Label();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            PBCliente = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBCliente).BeginInit();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.BackColor = SystemColors.ControlDark;
            LNyA.Location = new Point(121, 99);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(139, 20);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            LNyA.Click += Label1_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.ControlDark;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(294, 99);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(73, 20);
            LModificar.TabIndex = 1;
            LModificar.Text = "modificar";
            LModificar.Click += LModificar_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.BackColor = SystemColors.ControlDark;
            LDni.Location = new Point(26, 90);
            LDni.Name = "LDni";
            LDni.Size = new Size(51, 20);
            LDni.TabIndex = 2;
            LDni.Text = "DNI(*)";
            LDni.Click += label3_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = SystemColors.ControlDark;
            LApellido.Location = new Point(26, 137);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(82, 20);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido(*)";
            LApellido.Click += LApellido_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.ControlDark;
            LNombre.Location = new Point(26, 189);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(80, 20);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre(*)";
            LNombre.Click += LNombre_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(242, 152);
            TDni.Name = "TDni";
            TDni.Size = new Size(125, 27);
            TDni.TabIndex = 5;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(242, 199);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(125, 27);
            TApellido.TabIndex = 6;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(242, 251);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(125, 27);
            TNombre.TabIndex = 7;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Image = Properties.Resources.Document_save32;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(121, 508);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(116, 48);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Image = Properties.Resources.delete_users32;
            BEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BEliminar.Location = new Point(264, 508);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(116, 48);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(CBMastercard);
            panel1.Controls.Add(CBVisa);
            panel1.Controls.Add(CBNaranja);
            panel1.Controls.Add(LTarjetaCredito);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LDni);
            panel1.Location = new Point(86, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 407);
            panel1.TabIndex = 10;
            // 
            // CBMastercard
            // 
            CBMastercard.AutoSize = true;
            CBMastercard.Location = new Point(156, 346);
            CBMastercard.Name = "CBMastercard";
            CBMastercard.Size = new Size(105, 24);
            CBMastercard.TabIndex = 7;
            CBMastercard.Text = "Mastercard";
            CBMastercard.UseVisualStyleBackColor = true;
            // 
            // CBVisa
            // 
            CBVisa.AutoSize = true;
            CBVisa.Location = new Point(156, 316);
            CBVisa.Name = "CBVisa";
            CBVisa.Size = new Size(58, 24);
            CBVisa.TabIndex = 6;
            CBVisa.Text = "Visa";
            CBVisa.UseVisualStyleBackColor = true;
            // 
            // CBNaranja
            // 
            CBNaranja.AutoSize = true;
            CBNaranja.Location = new Point(156, 286);
            CBNaranja.Name = "CBNaranja";
            CBNaranja.Size = new Size(83, 24);
            CBNaranja.TabIndex = 5;
            CBNaranja.Text = "Naranja";
            CBNaranja.UseVisualStyleBackColor = true;
            // 
            // LTarjetaCredito
            // 
            LTarjetaCredito.AutoSize = true;
            LTarjetaCredito.Location = new Point(26, 286);
            LTarjetaCredito.Name = "LTarjetaCredito";
            LTarjetaCredito.Size = new Size(128, 20);
            LTarjetaCredito.TabIndex = 2;
            LTarjetaCredito.Text = "Tarjeta de credito:";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(156, 230);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(125, 27);
            TTelefono.TabIndex = 1;
            TTelefono.TextChanged += TTelefono_TextChanged;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(26, 237);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(67, 20);
            LTelefono.TabIndex = 0;
            LTelefono.Text = "Telefono";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.exit32;
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(631, 508);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(116, 48);
            BSalir.TabIndex = 11;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click_1;
            // 
            // LNuevoCliente
            // 
            LNuevoCliente.AutoSize = true;
            LNuevoCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LNuevoCliente.ForeColor = SystemColors.Highlight;
            LNuevoCliente.Location = new Point(347, 9);
            LNuevoCliente.Name = "LNuevoCliente";
            LNuevoCliente.Size = new Size(202, 38);
            LNuevoCliente.TabIndex = 12;
            LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(568, 332);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(68, 24);
            RBVaron.TabIndex = 13;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(679, 332);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(68, 24);
            RBMujer.TabIndex = 14;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // PBCliente
            // 
            PBCliente.BackgroundImage = Properties.Resources.Icons_Land_Medical_People_Patient_Male_256;
            PBCliente.Location = new Point(531, 69);
            PBCliente.Name = "PBCliente";
            PBCliente.Size = new Size(245, 232);
            PBCliente.TabIndex = 15;
            PBCliente.TabStop = false;
            // 
            // PequeñoFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 578);
            Controls.Add(PBCliente);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(LNuevoCliente);
            Controls.Add(BSalir);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LModificar);
            Controls.Add(LNyA);
            Controls.Add(panel1);
            Name = "PequeñoFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label LNyA;
        private Label LModificar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button BGuardar;
        private Button BEliminar;
        private Panel panel1;
        private Button BSalir;
        private Label LNuevoCliente;
        private TextBox TTelefono;
        private Label LTelefono;
        private Label LTarjetaCredito;
        private CheckBox CBMastercard;
        private CheckBox CBVisa;
        private CheckBox CBNaranja;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private PictureBox PBCliente;
    }
}