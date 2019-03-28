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

namespace Capa_Aplicacion
{
    public partial class FRM_Ventana : Form
    {
        public FRM_Ventana()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ventanas ventana = new ventanas
                {
                    nombre = txtNom.Text
                };

                new Cls_Ventanas().Agregar(ventana);

                MessageBox.Show("Ventana guardada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ventanas ventanas = new ventanas
                {
                    nombre = txtNom.Text

                };
                new Cls_Ventanas().Modificar(ventanas);
                MessageBox.Show("Cliente Modificado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
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

                if (MessageBox.Show("¿Realmente desea eliminar la ventana?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_Ventanas().Eliminar(Convert.ToInt32(txtIdVentana.Text));
                    MessageBox.Show("Ventana eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ventanas ventana = new Cls_Ventanas().Consultar(Convert.ToInt32(txtIdVentana.Text));

                txtNom.Text = ventana.nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_Ventana_Load(object sender, EventArgs e)
        {

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

        public void EstadoInicial()
        {
            txtIdVentana.Text = "";
            txtNom.Text = "";
        }
    }
}
