using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Capa_Logica_Negocio;
using System.Transactions;

namespace Capa_Aplicacion
{
    public partial class FRM_AdmPermisos : Form
    {

        #region Variables
        int vConsul;
        int vInser;
        int vMod;
        int vDel;
        int contador = 0;
        int numFila;
        bool vRoles;
        bool vPermisos;
        bool validado=false;
        #endregion

        public FRM_AdmPermisos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkRol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRol.Checked)
            {
                boxRoles.Enabled = true;
                vRoles = true;
            }
            else
            {
                boxRoles.Enabled = false;
                vRoles = false;
            }

        }

        private void checkDirecto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDirecto.Checked)
            {
                boxVentanas.Enabled = true;
                vPermisos = true;
            }
            else
            {
                boxVentanas.Enabled = false;
                vPermisos = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            numFila = dtgPermisos.RowCount - 1;
            bool existe = false;
            for (int i = 0; i < numFila; i++)
            {
                if (Convert.ToInt32(dtgPermisos.Rows[i].Cells[0].Value) == Convert.ToInt32(cbxVentana.SelectedValue))
                {
                    existe = true;
                }

            }

            if (existe)
            {
                MessageBox.Show("No puede ingresar la misma ventana", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtgPermisos.Rows.Add(cbxVentana.SelectedValue, cbxVentana.Text, vConsul, vInser, vMod, vDel);//cambiar a idventana

            }


        
    }

        private void FRM_AdmPermisos_Load(object sender, EventArgs e)
        {
            contador = 0;
            EstadoInicial();
            LlenarComboBox();
            
        }
        public void LlenarComboBox()
        {
            cbxRoles.DataSource = new Cls_Rol().ListaRoles();
            this.cbxRoles.ValueMember = "ID_Rol";
            this.cbxRoles.DisplayMember = "Nombre";

            cbxVentana.DataSource = new Cls_Ventanas().ListaLibros();
            this.cbxVentana.ValueMember = "ID_Ventana";
            this.cbxVentana.DisplayMember = "Nombre";
        }

        private void checkConsultar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConsultar.Checked)
            {
                vConsul = 1;
            }
            else
            {

                vConsul = 0;
            }
        }

        private void checkInsertar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInsertar.Checked)
            {
                vInser = 1;
            }
            else
            {

                vInser = 0;
            }
        }

        private void checkModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModificar.Checked)
            {
                vMod = 1;
            }
            else
            {

                vMod = 0;
            }
        }

        private void checkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                vDel = 1;
            }
            else
            {

                vDel = 0;
            }
        }

        private void btnGuardarRol_Click(object sender, EventArgs e)
        {
            numFila = dtgRoles.RowCount - 1;
            bool existe = false;
            for (int i = 0; i < numFila; i++)
            {
                if (Convert.ToInt32(dtgRoles.Rows[i].Cells[0].Value) == Convert.ToInt32(cbxRoles.SelectedValue))
                {
                    existe = true;
                }

            }

            if (existe)
            {
                MessageBox.Show("No puede ingresar la misma ventana", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtgRoles.Rows.Add(cbxRoles.SelectedValue, cbxRoles.Text, vConsul, vInser, vMod, vDel);//cambiar a idventana

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                usuarios usuario = new Cls_Usuario().Consultar(txtNomUsuario.Text);
                new Cls_Usuario().AgregarPermisos(usuario, dtgRoles, dtgPermisos, vRoles, vPermisos, cbxRoles);

                MessageBox.Show("Permisos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                usuarios user = new Cls_Usuario().Consultar(txtNomUsuario.Text);
                txtContra.Text = user.contrasenna;
                validado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(validado)
            {
                checkRol.Enabled = true;
                checkDirecto.Enabled = true;
            }


        }

        public void VerificarPermisos(permisosAUsuarios permisos)
        {
            if (permisos.consultar == 0)
            {
                btnConsultar.Enabled = false;
            }
            if (permisos.insertar == 0)
            {
                btnAgregar.Enabled = false;
            }
            if (permisos.modificar == 0)
            {
                btnModificar.Enabled = false;
            }
            if (permisos.eliminar == 0)
            {
                btnEliminar.Enabled = false;
            }
        }

        public void VerificarPermisoRol(permisosDeRol permisos)
        {
            if (permisos.consultar == 0)
            {
                btnConsultar.Enabled = false;
            }
            if (permisos.insertar == 0)
            {
                btnAgregar.Enabled = false;
            }
            if (permisos.modificar == 0)
            {
                btnModificar.Enabled = false;
            }
            if (permisos.eliminar == 0)
            {
                btnEliminar.Enabled = false;
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                new Cls_PermisosUsuarios().ConsultarPermisosUsuario(dtgPermisos, txtNomUsuario.Text, dtgRoles);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar todos los permisos y roles asignados a este usuario?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_PermisosUsuarios().EliminarPermisos(txtNomUsuario.Text);
                    MessageBox.Show("Permisos y roles eliminados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EstadoInicial()
        {
            
            txtNomUsuario.Text = "";
            txtContra.Text = "";

            int numFila = dtgPermisos.RowCount - 1;
            for (int i = 0; i < numFila; i++)
            {
                dtgPermisos.Rows.RemoveAt(0);
            }

            numFila = dtgRoles.RowCount - 1;
            for (int i = 0; i < numFila; i++)
            {
                dtgRoles.Rows.RemoveAt(0);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea modificar los permisos directos", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_PermisosUsuarios().ModificarPermisos(txtNomUsuario.Text, dtgPermisos);
                    MessageBox.Show("Permisos modificados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPermisos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbxVentana.SelectedValue = dtgPermisos.Rows[e.RowIndex].Cells[0].Value;

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[2].Value) == 1)
            {
                checkConsultar.Checked = true;
            }
            else
            {
                checkConsultar.Checked = false;
            }

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[3].Value) == 1)
            {
                checkInsertar.Checked = true;
            }
            else
            {
                checkConsultar.Checked = false;
            }

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[4].Value) == 1)
            {
                checkModificar.Checked = true;
            }
            else
            {
                checkModificar.Checked = false;
            }

            if (Convert.ToInt32(dtgPermisos.Rows[e.RowIndex].Cells[5].Value) == 1)
            {
                checkEliminar.Checked = true;
            }
            else
            {
                checkEliminar.Checked = false;
            }


            dtgPermisos.Rows.RemoveAt(e.RowIndex);
        }
    }
}
