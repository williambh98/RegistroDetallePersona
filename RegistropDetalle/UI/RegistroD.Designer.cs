namespace RegistropDetalle.UI
{
    partial class RegistroD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Filabutton = new System.Windows.Forms.Button();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(106, 47);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "F.Nacimiento";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(373, 156);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(174, 22);
            this.FechadateTimePicker.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo:";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(106, 88);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(441, 22);
            this.NombretextBox.TabIndex = 11;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(105, 122);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(441, 22);
            this.DirecciontextBox.TabIndex = 12;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(105, 156);
            this.CedulamaskedTextBox.Mask = "999-999999-9";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(139, 22);
            this.CedulamaskedTextBox.TabIndex = 18;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(108, 30);
            this.TelefonomaskedTextBox.Mask = "999-999-9999";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(138, 22);
            this.TelefonomaskedTextBox.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Filabutton);
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Controls.Add(this.TipocomboBox);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TelefonomaskedTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 260);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Telefonos";
            // 
            // Filabutton
            // 
            this.Filabutton.Image = global::RegistropDetalle.Properties.Resources.Eliminar;
            this.Filabutton.Location = new System.Drawing.Point(198, 209);
            this.Filabutton.Name = "Filabutton";
            this.Filabutton.Size = new System.Drawing.Size(163, 45);
            this.Filabutton.TabIndex = 23;
            this.Filabutton.Text = "Remove Fila";
            this.Filabutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Filabutton.UseVisualStyleBackColor = true;
            this.Filabutton.Click += new System.EventHandler(this.Filabutton_Click);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(18, 58);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.RowTemplate.Height = 24;
            this.DetalledataGridView.Size = new System.Drawing.Size(516, 150);
            this.DetalledataGridView.TabIndex = 22;
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Location = new System.Drawing.Point(298, 28);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(145, 24);
            this.TipocomboBox.TabIndex = 21;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(460, 25);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 27);
            this.Agregar.TabIndex = 20;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Eliminar
            // 
            this.Eliminar.Image = global::RegistropDetalle.Properties.Resources.Eliminar1;
            this.Eliminar.Location = new System.Drawing.Point(393, 450);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(117, 42);
            this.Eliminar.TabIndex = 17;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::RegistropDetalle.Properties.Resources.icons8_guardar_48;
            this.Guardar.Location = new System.Drawing.Point(231, 446);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(123, 51);
            this.Guardar.TabIndex = 16;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Image = global::RegistropDetalle.Properties.Resources.icons8_nuevo_48;
            this.Nuevo.Location = new System.Drawing.Point(64, 446);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(128, 51);
            this.Nuevo.TabIndex = 15;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Buscar
            // 
            this.Buscar.Image = global::RegistropDetalle.Properties.Resources.Buscar;
            this.Buscar.Location = new System.Drawing.Point(245, 37);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(109, 45);
            this.Buscar.TabIndex = 10;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // RegistroD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "RegistroD";
            this.Text = "RegistroD";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Filabutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}