namespace Capa_Aplicacion
{
    partial class FRM_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoUsuariosToolStripMenuItem,
            this.mantenimientoClientesToolStripMenuItem,
            this.prestamosToolStripMenuItem1});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // mantenimientoUsuariosToolStripMenuItem
            // 
            this.mantenimientoUsuariosToolStripMenuItem.Name = "mantenimientoUsuariosToolStripMenuItem";
            this.mantenimientoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mantenimientoUsuariosToolStripMenuItem.Tag = "2";
            this.mantenimientoUsuariosToolStripMenuItem.Text = "Mantenimiento Libros";
            this.mantenimientoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoUsuariosToolStripMenuItem_Click);
            // 
            // mantenimientoClientesToolStripMenuItem
            // 
            this.mantenimientoClientesToolStripMenuItem.Name = "mantenimientoClientesToolStripMenuItem";
            this.mantenimientoClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mantenimientoClientesToolStripMenuItem.Tag = "3";
            this.mantenimientoClientesToolStripMenuItem.Text = "Mantenimiento Clientes";
            this.mantenimientoClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClientesToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem1
            // 
            this.prestamosToolStripMenuItem1.Name = "prestamosToolStripMenuItem1";
            this.prestamosToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.prestamosToolStripMenuItem1.Tag = "1";
            this.prestamosToolStripMenuItem1.Text = "Prestamos";
            this.prestamosToolStripMenuItem1.Click += new System.EventHandler(this.prestamosToolStripMenuItem1_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.asignarPermisosToolStripMenuItem,
            this.ventanasToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.administrarToolStripMenuItem.Text = "Seguridad";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.asignarPermisosToolStripMenuItem.Text = "Asignar Permisos";
            this.asignarPermisosToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosToolStripMenuItem_Click);
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            this.ventanasToolStripMenuItem.Click += new System.EventHandler(this.ventanasToolStripMenuItem_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 309);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_Principal";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
    }
}