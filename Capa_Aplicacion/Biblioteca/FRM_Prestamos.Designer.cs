namespace Capa_Aplicacion
{
    partial class FRM_Prestamos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.btnConsRaCli = new System.Windows.Forms.Button();
            this.dtpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.txtCed = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cédula = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgListaDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarEnLista = new System.Windows.Forms.Button();
            this.btnConsRaLib = new System.Windows.Forms.Button();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.txtCodLibro = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDevolucion);
            this.groupBox1.Controls.Add(this.btnConsRaCli);
            this.groupBox1.Controls.Add(this.dtpPrestamo);
            this.groupBox1.Controls.Add(this.txtCed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cédula);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado Prestamo";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucion.Location = new System.Drawing.Point(395, 51);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(120, 20);
            this.dtpDevolucion.TabIndex = 6;
            this.dtpDevolucion.Tag = "";
            this.dtpDevolucion.Value = new System.DateTime(2017, 6, 15, 8, 6, 20, 0);
            this.dtpDevolucion.ValueChanged += new System.EventHandler(this.dtpDevolucion_ValueChanged);
            // 
            // btnConsRaCli
            // 
            this.btnConsRaCli.BackColor = System.Drawing.Color.Azure;
            this.btnConsRaCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsRaCli.Image = global::Capa_Aplicacion.Properties.Resources._1498019188_search;
            this.btnConsRaCli.Location = new System.Drawing.Point(186, 22);
            this.btnConsRaCli.Name = "btnConsRaCli";
            this.btnConsRaCli.Size = new System.Drawing.Size(43, 23);
            this.btnConsRaCli.TabIndex = 5;
            this.btnConsRaCli.UseVisualStyleBackColor = false;
            this.btnConsRaCli.Click += new System.EventHandler(this.btnConsRaCli_Click);
            // 
            // dtpPrestamo
            // 
            this.dtpPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrestamo.Location = new System.Drawing.Point(395, 20);
            this.dtpPrestamo.Name = "dtpPrestamo";
            this.dtpPrestamo.Size = new System.Drawing.Size(120, 20);
            this.dtpPrestamo.TabIndex = 5;
            this.dtpPrestamo.ValueChanged += new System.EventHandler(this.FRM_Prestamos_Load);
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(80, 24);
            this.txtCed.Mask = "#-####-####";
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(100, 20);
            this.txtCed.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de devolución";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(80, 54);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(178, 20);
            this.txtNomCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // Cédula
            // 
            this.Cédula.AutoSize = true;
            this.Cédula.Location = new System.Drawing.Point(21, 27);
            this.Cédula.Name = "Cédula";
            this.Cédula.Size = new System.Drawing.Size(40, 13);
            this.Cédula.TabIndex = 0;
            this.Cédula.Text = "Cédula";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgListaDetalle);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnGuardarEnLista);
            this.groupBox3.Controls.Add(this.btnConsRaLib);
            this.groupBox3.Controls.Add(this.txtNomCli);
            this.groupBox3.Controls.Add(this.txtCodLibro);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(17, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prestamo Detalle";
            // 
            // dtgListaDetalle
            // 
            this.dtgListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgListaDetalle.Location = new System.Drawing.Point(6, 120);
            this.dtgListaDetalle.Name = "dtgListaDetalle";
            this.dtgListaDetalle.Size = new System.Drawing.Size(350, 114);
            this.dtgListaDetalle.TabIndex = 11;
            this.dtgListaDetalle.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgListaDetalle_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(93, 91);
            this.txtCantidad.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad";
            // 
            // btnGuardarEnLista
            // 
            this.btnGuardarEnLista.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuardarEnLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarEnLista.Image = global::Capa_Aplicacion.Properties.Resources._1493083030_Save_as;
            this.btnGuardarEnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEnLista.Location = new System.Drawing.Point(267, 91);
            this.btnGuardarEnLista.Name = "btnGuardarEnLista";
            this.btnGuardarEnLista.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEnLista.TabIndex = 8;
            this.btnGuardarEnLista.Text = "Guardar";
            this.btnGuardarEnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEnLista.UseVisualStyleBackColor = false;
            this.btnGuardarEnLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsRaLib
            // 
            this.btnConsRaLib.BackColor = System.Drawing.Color.Azure;
            this.btnConsRaLib.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsRaLib.Image = global::Capa_Aplicacion.Properties.Resources._1498019188_search;
            this.btnConsRaLib.Location = new System.Drawing.Point(199, 23);
            this.btnConsRaLib.Name = "btnConsRaLib";
            this.btnConsRaLib.Size = new System.Drawing.Size(43, 23);
            this.btnConsRaLib.TabIndex = 6;
            this.btnConsRaLib.UseVisualStyleBackColor = false;
            this.btnConsRaLib.Click += new System.EventHandler(this.btnConsRaLib_Click);
            // 
            // txtNomCli
            // 
            this.txtNomCli.Location = new System.Drawing.Point(93, 55);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(178, 20);
            this.txtNomCli.TabIndex = 4;
            // 
            // txtCodLibro
            // 
            this.txtCodLibro.Location = new System.Drawing.Point(93, 25);
            this.txtCodLibro.Mask = "##############";
            this.txtCodLibro.Name = "txtCodLibro";
            this.txtCodLibro.Size = new System.Drawing.Size(100, 20);
            this.txtCodLibro.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo Libro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConsultar);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnModificar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Location = new System.Drawing.Point(23, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 52);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Azure;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Image = global::Capa_Aplicacion.Properties.Resources._1498019188_search;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(264, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Snow;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = global::Capa_Aplicacion.Properties.Resources._1493083103_f_cross_256;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(183, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Image = global::Capa_Aplicacion.Properties.Resources._1492759895_custom_reports;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(102, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Honeydew;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Image = global::Capa_Aplicacion.Properties.Resources._1493083030_Save_as;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(21, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Codigo Prestamo";
            // 
            // txtCodPrestamo
            // 
            this.txtCodPrestamo.Location = new System.Drawing.Point(110, 9);
            this.txtCodPrestamo.Mask = "##########";
            this.txtCodPrestamo.Name = "txtCodPrestamo";
            this.txtCodPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtCodPrestamo.TabIndex = 8;
            // 
            // FRM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.txtCodPrestamo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_Prestamos";
            this.Tag = "1";
            this.Text = "Administración de Prestamos";
            this.Load += new System.EventHandler(this.FRM_Prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Cédula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCed;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.DateTimePicker dtpPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCodLibro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsRaCli;
        private System.Windows.Forms.Button btnConsRaLib;
        private System.Windows.Forms.Button btnGuardarEnLista;
        private System.Windows.Forms.TextBox txtNomCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgListaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCodPrestamo;
    }
}