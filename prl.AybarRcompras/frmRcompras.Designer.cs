namespace prl.AybarRcompras
{
    partial class frmRcompras
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
            btnCargar = new Button();
            lblFecha = new Label();
            lblProducto = new Label();
            lblPrecio = new Label();
            dtmFecha = new DateTimePicker();
            grpDatos = new GroupBox();
            lblCantidad = new Label();
            mskPrecio = new MaskedTextBox();
            nudCantidad = new NumericUpDown();
            lstProducto = new ListBox();
            btnCancelar = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(22, 230);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(65, 30);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(16, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 19);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F);
            lblProducto.Location = new Point(16, 80);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(65, 19);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto";
            lblProducto.Click += label3_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F);
            lblPrecio.Location = new Point(16, 158);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(99, 19);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio Unitario";
            // 
            // dtmFecha
            // 
            dtmFecha.Font = new Font("Segoe UI", 10F);
            dtmFecha.Format = DateTimePickerFormat.Short;
            dtmFecha.Location = new Point(60, 38);
            dtmFecha.Name = "dtmFecha";
            dtmFecha.Size = new Size(95, 25);
            dtmFecha.TabIndex = 6;
            dtmFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // grpDatos
            // 
            grpDatos.BackColor = SystemColors.ActiveCaption;
            grpDatos.Controls.Add(lblCantidad);
            grpDatos.Controls.Add(mskPrecio);
            grpDatos.Controls.Add(nudCantidad);
            grpDatos.Controls.Add(lstProducto);
            grpDatos.Controls.Add(dtmFecha);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(lblProducto);
            grpDatos.Controls.Add(lblFecha);
            grpDatos.Location = new Point(22, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(368, 200);
            grpDatos.TabIndex = 9;
            grpDatos.TabStop = false;
            grpDatos.Text = "DATOS DEL PRODUCTO";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(17, 121);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(64, 19);
            lblCantidad.TabIndex = 12;
            lblCantidad.Text = "Cantidad";
            // 
            // mskPrecio
            // 
            mskPrecio.Font = new Font("Segoe UI", 10F);
            mskPrecio.Location = new Point(121, 158);
            mskPrecio.Mask = "$0000000000000";
            mskPrecio.Name = "mskPrecio";
            mskPrecio.Size = new Size(68, 25);
            mskPrecio.TabIndex = 11;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Font = new Font("Segoe UI", 10F);
            nudCantidad.Location = new Point(87, 119);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(68, 25);
            nudCantidad.TabIndex = 10;
            // 
            // lstProducto
            // 
            lstProducto.Font = new Font("Segoe UI", 10F);
            lstProducto.FormattingEnabled = true;
            lstProducto.ItemHeight = 17;
            lstProducto.Items.AddRange(new object[] { "Pizza", "Hamburguesa", "Pastas", "MENU " });
            lstProducto.Location = new Point(87, 80);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(215, 21);
            lstProducto.TabIndex = 9;
            lstProducto.SelectedIndexChanged += lstProducto_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(93, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(65, 30);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRcompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 344);
            Controls.Add(btnCancelar);
            Controls.Add(grpDatos);
            Controls.Add(btnCargar);
            Name = "frmRcompras";
            Text = "Registro Compras";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private Label lblFecha;
        private Label lblProducto;
        private Label lblPrecio;
        private DateTimePicker dtmFecha;
        private GroupBox grpDatos;
        private Label lblCantidad;
        private MaskedTextBox mskPrecio;
        private NumericUpDown nudCantidad;
        private ListBox lstProducto;
        private Button btnCancelar;
    }
}
