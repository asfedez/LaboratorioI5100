namespace Capa_Aplicacion
{
    partial class FRM_AdmPermisos
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
            this.txtContra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxVentanas = new System.Windows.Forms.GroupBox();
            this.dtgPermisos = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarPermiso = new System.Windows.Forms.Button();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.checkModificar = new System.Windows.Forms.CheckBox();
            this.checkInsertar = new System.Windows.Forms.CheckBox();
            this.checkConsultar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxVentana = new System.Windows.Forms.ComboBox();
            this.boxRoles = new System.Windows.Forms.GroupBox();
            this.dtgRoles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarRol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.checkRol = new System.Windows.Forms.CheckBox();
            this.checkDirecto = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.boxVentanas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).BeginInit();
            this.boxRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtNomUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(129, 59);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(133, 20);
            this.txtContra.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contrasenna";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Capa_Aplicacion.Properties.Resources._1498019188_search;
            this.button2.Location = new System.Drawing.Point(278, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(129, 27);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(143, 20);
            this.txtNomUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Usuario";
            // 
            // boxVentanas
            // 
            this.boxVentanas.Controls.Add(this.dtgPermisos);
            this.boxVentanas.Controls.Add(this.btnGuardarPermiso);
            this.boxVentanas.Controls.Add(this.checkEliminar);
            this.boxVentanas.Controls.Add(this.checkModificar);
            this.boxVentanas.Controls.Add(this.checkInsertar);
            this.boxVentanas.Controls.Add(this.checkConsultar);
            this.boxVentanas.Controls.Add(this.label3);
            this.boxVentanas.Controls.Add(this.cbxVentana);
            this.boxVentanas.Enabled = false;
            this.boxVentanas.Location = new System.Drawing.Point(386, 158);
            this.boxVentanas.Name = "boxVentanas";
            this.boxVentanas.Size = new System.Drawing.Size(656, 277);
            this.boxVentanas.TabIndex = 4;
            this.boxVentanas.TabStop = false;
            this.boxVentanas.Text = "Permisos ventanas";
            // 
            // dtgPermisos
            // 
            this.dtgPermisos.AllowUserToDeleteRows = false;
            this.dtgPermisos.AllowUserToResizeColumns = false;
            this.dtgPermisos.AllowUserToResizeRows = false;
            this.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgPermisos.Location = new System.Drawing.Point(6, 135);
            this.dtgPermisos.Name = "dtgPermisos";
            this.dtgPermisos.Size = new System.Drawing.Size(648, 132);
            this.dtgPermisos.TabIndex = 11;
            this.dtgPermisos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPermisos_RowHeaderMouseDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id Ventana";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ventana";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Consultar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Insertar";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modificar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Eliminar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnGuardarPermiso
            // 
            this.btnGuardarPermiso.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuardarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarPermiso.Image = global::Capa_Aplicacion.Properties.Resources._1493083030_Save_as;
            this.btnGuardarPermiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPermiso.Location = new System.Drawing.Point(284, 105);
            this.btnGuardarPermiso.Name = "btnGuardarPermiso";
            this.btnGuardarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPermiso.TabIndex = 7;
            this.btnGuardarPermiso.Text = "Guardar";
            this.btnGuardarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPermiso.UseVisualStyleBackColor = false;
            this.btnGuardarPermiso.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkEliminar
            // 
            this.checkEliminar.AutoSize = true;
            this.checkEliminar.Location = new System.Drawing.Point(387, 82);
            this.checkEliminar.Name = "checkEliminar";
            this.checkEliminar.Size = new System.Drawing.Size(62, 17);
            this.checkEliminar.TabIndex = 6;
            this.checkEliminar.Text = "Eliminar";
            this.checkEliminar.UseVisualStyleBackColor = true;
            this.checkEliminar.CheckedChanged += new System.EventHandler(this.checkEliminar_CheckedChanged);
            // 
            // checkModificar
            // 
            this.checkModificar.AutoSize = true;
            this.checkModificar.Location = new System.Drawing.Point(320, 82);
            this.checkModificar.Name = "checkModificar";
            this.checkModificar.Size = new System.Drawing.Size(69, 17);
            this.checkModificar.TabIndex = 5;
            this.checkModificar.Text = "Modificar";
            this.checkModificar.UseVisualStyleBackColor = true;
            this.checkModificar.CheckedChanged += new System.EventHandler(this.checkModificar_CheckedChanged);
            // 
            // checkInsertar
            // 
            this.checkInsertar.AutoSize = true;
            this.checkInsertar.Location = new System.Drawing.Point(253, 82);
            this.checkInsertar.Name = "checkInsertar";
            this.checkInsertar.Size = new System.Drawing.Size(61, 17);
            this.checkInsertar.TabIndex = 4;
            this.checkInsertar.Text = "Insertar";
            this.checkInsertar.UseVisualStyleBackColor = true;
            this.checkInsertar.CheckedChanged += new System.EventHandler(this.checkInsertar_CheckedChanged);
            // 
            // checkConsultar
            // 
            this.checkConsultar.AutoSize = true;
            this.checkConsultar.Location = new System.Drawing.Point(186, 82);
            this.checkConsultar.Name = "checkConsultar";
            this.checkConsultar.Size = new System.Drawing.Size(70, 17);
            this.checkConsultar.TabIndex = 3;
            this.checkConsultar.Text = "Consultar";
            this.checkConsultar.UseVisualStyleBackColor = true;
            this.checkConsultar.CheckedChanged += new System.EventHandler(this.checkConsultar_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione una ventana";
            // 
            // cbxVentana
            // 
            this.cbxVentana.FormattingEnabled = true;
            this.cbxVentana.Location = new System.Drawing.Point(312, 23);
            this.cbxVentana.Name = "cbxVentana";
            this.cbxVentana.Size = new System.Drawing.Size(156, 21);
            this.cbxVentana.TabIndex = 2;
            // 
            // boxRoles
            // 
            this.boxRoles.Controls.Add(this.dtgRoles);
            this.boxRoles.Controls.Add(this.btnGuardarRol);
            this.boxRoles.Controls.Add(this.label4);
            this.boxRoles.Controls.Add(this.cbxRoles);
            this.boxRoles.Enabled = false;
            this.boxRoles.Location = new System.Drawing.Point(12, 158);
            this.boxRoles.Name = "boxRoles";
            this.boxRoles.Size = new System.Drawing.Size(352, 277);
            this.boxRoles.TabIndex = 8;
            this.boxRoles.TabStop = false;
            this.boxRoles.Text = "Asignar Rol";
            // 
            // dtgRoles
            // 
            this.dtgRoles.AllowUserToDeleteRows = false;
            this.dtgRoles.AllowUserToResizeColumns = false;
            this.dtgRoles.AllowUserToResizeRows = false;
            this.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtgRoles.Location = new System.Drawing.Point(29, 139);
            this.dtgRoles.Name = "dtgRoles";
            this.dtgRoles.Size = new System.Drawing.Size(251, 132);
            this.dtgRoles.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Rol";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Rol";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnGuardarRol
            // 
            this.btnGuardarRol.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuardarRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarRol.Image = global::Capa_Aplicacion.Properties.Resources._1493083030_Save_as;
            this.btnGuardarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRol.Location = new System.Drawing.Point(139, 97);
            this.btnGuardarRol.Name = "btnGuardarRol";
            this.btnGuardarRol.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRol.TabIndex = 7;
            this.btnGuardarRol.Text = "Guardar";
            this.btnGuardarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarRol.UseVisualStyleBackColor = false;
            this.btnGuardarRol.Click += new System.EventHandler(this.btnGuardarRol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Seleccione un Rol";
            // 
            // cbxRoles
            // 
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Location = new System.Drawing.Point(139, 58);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(156, 21);
            this.cbxRoles.TabIndex = 2;
            // 
            // checkRol
            // 
            this.checkRol.AutoSize = true;
            this.checkRol.Enabled = false;
            this.checkRol.Location = new System.Drawing.Point(18, 135);
            this.checkRol.Name = "checkRol";
            this.checkRol.Size = new System.Drawing.Size(80, 17);
            this.checkRol.TabIndex = 9;
            this.checkRol.Text = "Asignar Rol";
            this.checkRol.UseVisualStyleBackColor = true;
            this.checkRol.CheckedChanged += new System.EventHandler(this.checkRol_CheckedChanged);
            // 
            // checkDirecto
            // 
            this.checkDirecto.AutoSize = true;
            this.checkDirecto.Enabled = false;
            this.checkDirecto.Location = new System.Drawing.Point(392, 135);
            this.checkDirecto.Name = "checkDirecto";
            this.checkDirecto.Size = new System.Drawing.Size(170, 17);
            this.checkDirecto.TabIndex = 10;
            this.checkDirecto.Text = "Asignar Permisos directamente";
            this.checkDirecto.UseVisualStyleBackColor = true;
            this.checkDirecto.CheckedChanged += new System.EventHandler(this.checkDirecto_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConsultar);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnModificar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Location = new System.Drawing.Point(206, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 52);
            this.groupBox4.TabIndex = 11;
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
            // FRM_AdmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 525);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.checkDirecto);
            this.Controls.Add(this.checkRol);
            this.Controls.Add(this.boxRoles);
            this.Controls.Add(this.boxVentanas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_AdmPermisos";
            this.Tag = "6";
            this.Text = "Administración de Permisos";
            this.Load += new System.EventHandler(this.FRM_AdmPermisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.boxVentanas.ResumeLayout(false);
            this.boxVentanas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).EndInit();
            this.boxRoles.ResumeLayout(false);
            this.boxRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox boxVentanas;
        private System.Windows.Forms.Button btnGuardarPermiso;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.CheckBox checkModificar;
        private System.Windows.Forms.CheckBox checkInsertar;
        private System.Windows.Forms.CheckBox checkConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxVentana;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox boxRoles;
        private System.Windows.Forms.Button btnGuardarRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRoles;
        private System.Windows.Forms.CheckBox checkRol;
        private System.Windows.Forms.CheckBox checkDirecto;
        private System.Windows.Forms.DataGridView dtgPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dtgRoles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MaskedTextBox txtContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}