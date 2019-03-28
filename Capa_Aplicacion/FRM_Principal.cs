using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Entidades;
using Capa_Logica_Negocio;


namespace Capa_Aplicacion
{
    public partial class FRM_Principal : Form
    {
        #region Variables
        public usuarios user;
        FRM_Clientes frmClientes;
        FRM_Libros frmLibros;
        FRM_Prestamos frmPrestamo;
        FRM_Usuarios frmUsuarios;
        FRM_Roles frmRoles;
        FRM_AdmPermisos frmAdmPermisos;
        FRM_Ventana frmVentana;
        #endregion


        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        #region Eventos
        private void mantenimientoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibros.ShowDialog();
        }

        private void devolucinesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmClientes.ShowDialog();

        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Prestamos frmPrestamos = new FRM_Prestamos();
            frmPrestamos.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUsuarios.ShowDialog();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrestamo.ShowDialog();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles.ShowDialog();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmPermisos.ShowDialog();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ventanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana.ShowDialog();
        }
        #endregion



        private void FRM_Principal_Load(object sender, EventArgs e)
        {

            EstadoInicial();
            try
            {
                FRM_Login autenticacion = new FRM_Login();
                autenticacion.miPadre(this);
                autenticacion.ShowDialog();
                user = autenticacion.UsuarioIngresado();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Bitacora
            Bitacora bitacora = new Bitacora
            {
                nombreUsuario = user.nombreUsuario,
                fechaIngreso = System.DateTime.Now

            };


            new Cls_Bitacora().AgregarBitacora(bitacora);

            #region Clientes
            //PermisosDirectos
            frmClientes = new FRM_Clientes();
            permisosAUsuarios permisos = Permisos(Convert.ToInt32(frmClientes.Tag));
            if (permisos != null)
            {
                mantenimientoClientesToolStripMenuItem.Enabled = true;
                frmClientes.VerificarPermisos(permisos);
            }

            //Permisos del Rol
            permisosDeRol permisosR = VerificarRoles(user.idUsuario, Convert.ToInt32(frmClientes.Tag));
            if (permisosR != null)
            {
                mantenimientoClientesToolStripMenuItem.Enabled = true;
                frmClientes.VerificarPermisoRol(permisosR);
            }
            #endregion

            #region Libros
            frmLibros = new FRM_Libros();
            permisos = Permisos(Convert.ToInt32(frmLibros.Tag));
            if (permisos != null)
            {
                mantenimientoUsuariosToolStripMenuItem.Enabled = true;
                frmLibros.VerificarPermisos(permisos);
            }
     
            permisosR = VerificarRoles(user.idUsuario, Convert.ToInt32(frmLibros.Tag));
            if (permisosR != null)
            {
                mantenimientoUsuariosToolStripMenuItem.Enabled = true;
                frmLibros.VerificarPermisoRol(permisosR);
            }
            #endregion

            #region Prestamo
            frmPrestamo = new FRM_Prestamos();
            permisos = Permisos(Convert.ToInt32(frmPrestamo.Tag));
            if (permisos != null)
            {
                prestamosToolStripMenuItem1.Enabled = true;
                frmPrestamo.VerificarPermisos(permisos);
            }

            permisosR = VerificarRoles(user.idUsuario, Convert.ToInt32(frmPrestamo.Tag));
            if (permisosR != null)
            {
                prestamosToolStripMenuItem1.Enabled = true;
                frmPrestamo.VerificarPermisoRol(permisosR);
            }
            #endregion

            #region Usuarios
            frmUsuarios = new FRM_Usuarios();
            permisos = Permisos(Convert.ToInt32(frmUsuarios.Tag));
            if (permisos != null)
            {
                usuariosToolStripMenuItem.Enabled = true;
                frmUsuarios.VerificarPermisos(permisos);
            }
    

            permisosR = VerificarRoles(user.idUsuario, Convert.ToInt32(frmUsuarios.Tag));
            if (permisosR != null)
            {
                usuariosToolStripMenuItem.Enabled = true;
                frmUsuarios.VerificarPermisoRol(permisosR);
            }
            #endregion

            #region Roles
            frmRoles = new FRM_Roles();
            permisos = Permisos(Convert.ToInt32(frmRoles.Tag));
            if (permisos != null)
            {
                rolesToolStripMenuItem.Enabled = true;
                frmRoles.VerificarPermisos(permisos);
            }


            permisosR = VerificarRoles(user.idUsuario, Convert.ToInt32(frmRoles.Tag));
            if (permisosR != null)
            {
                rolesToolStripMenuItem.Enabled = true;
                frmRoles.VerificarPermisoRol(permisosR);
            }

            #endregion

            #region Administracion De Permisos
            frmAdmPermisos = new FRM_AdmPermisos();
            permisos = Permisos(Convert.ToInt32(frmAdmPermisos.Tag));
            if (permisos != null)
            {
                asignarPermisosToolStripMenuItem.Enabled = true;
                frmAdmPermisos.VerificarPermisos(permisos);
            }


            permisosR = VerificarRoles(user.idUsuario, Convert.ToInt32(frmAdmPermisos.Tag));
            if (permisosR != null)
            {
                asignarPermisosToolStripMenuItem.Enabled = true;
                frmAdmPermisos.VerificarPermisoRol(permisosR);
            }
            #endregion

            #region Ventanas
            frmVentana = new FRM_Ventana();
            permisos = Permisos(Convert.ToInt32(frmVentana.Tag));
            if (permisos != null)
            {
                ventanasToolStripMenuItem.Enabled = true;
                frmVentana.VerificarPermisos(permisos);
            }


            permisosR = VerificarRoles(user.idUsuario, Convert.ToInt32(frmVentana.Tag));
            if (permisosR != null)
            {
                ventanasToolStripMenuItem.Enabled = true;
                frmVentana.VerificarPermisoRol(permisosR);
            }
            #endregion



        }
        /// <summary>
        /// Este metodo retorna el usuario con el que se ha ingresado al sistema
        /// </summary>
        /// <returns usuario></returns>
        public usuarios UsuarioIngresado()
        {
            return user;
        }

        #region Metodos
        /// <summary>
        /// Este metodo retorna los permisos de los usuarios
        /// </summary>
        /// <param name="tag"></param>
        /// <returns PermisosAUsuarios></returns>
        public permisosAUsuarios Permisos(int tag)
        {
            try
            {
                return new Cls_PermisosUsuarios().ConsultarPermisos(tag, user.idUsuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        /// <summary>
        /// Metodo que consulta los permisos del rol
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public permisosDeRol VerificarRoles(int idUsuario, int tag)
        {  
             return new Cls_RolAsignado().PermisosRol(idUsuario, tag);
        }

        public void EstadoInicial()
        {
            mantenimientoClientesToolStripMenuItem.Enabled = false;
            mantenimientoUsuariosToolStripMenuItem.Enabled = false;
            prestamosToolStripMenuItem1.Enabled = false;
            usuariosToolStripMenuItem.Enabled = false;
            rolesToolStripMenuItem.Enabled = false;
            asignarPermisosToolStripMenuItem.Enabled = false;
            ventanasToolStripMenuItem.Enabled = false;
        }









        #endregion

        
    }
}
