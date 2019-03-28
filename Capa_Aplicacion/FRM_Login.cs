using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_Negocio;
using Entidades;
using System.Transactions;

namespace Capa_Aplicacion
{
    public partial class FRM_Login : Form
    {
        private FRM_Principal frmMenu;
        private Boolean autenticado;
         usuarios user;

        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }

        public void miPadre(FRM_Principal frm)
        {
            this.frmMenu = frm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                user = new usuarios
                {
                    nombreUsuario = txtNombre.Text,
                    contrasenna = txtContra.Text
                };

                Cls_Usuario usuario = new Cls_Usuario();
                

                this.autenticado = usuario.ValidarIngreso(user); 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (autenticado == true)
            {
                MessageBox.Show("Sesión iniciada \nBienvenido usuario " + txtNombre.Text);
            }
            
        }

        public usuarios UsuarioIngresado()
        {
            return new Cls_Usuario().Consultar(user.nombreUsuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void FRM_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.autenticado == false)
            {
                this.frmMenu.Close();
            }
        }
    }
}
