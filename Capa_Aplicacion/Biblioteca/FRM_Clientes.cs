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
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clientes cliente = new clientes
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    fechaNacimiento = Convert.ToDateTime(dtpFecha.Text)

                };
                new Cls_Cliente().AgregarCliente(cliente);
                MessageBox.Show("Cliente guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                clientes cliente = new clientes
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    fechaNacimiento = Convert.ToDateTime(dtpFecha.Text)

                };
                new Cls_Cliente().Modificar(cliente);
                MessageBox.Show("Cliente Modificado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                clientes cliente = new Cls_Cliente().Consultar(txtCedula.Text);

                txtCedula.Text = cliente.Cedula;
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                dtpFecha.Text = "" + cliente.fechaNacimiento;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)// se debe modificar, ya que hay que eliminar las foraneas
        {  
            try
            {

                if (MessageBox.Show("¿Realmente desea eliminar el cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_Cliente().Eliminar(txtCedula.Text);
                    MessageBox.Show("Cliente eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_Clientes_Load(object sender, EventArgs e)
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
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }
    }
}
