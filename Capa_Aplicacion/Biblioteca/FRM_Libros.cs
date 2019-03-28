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
    public partial class FRM_Libros : Form
    {
        public FRM_Libros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            try
            {

                Libros libro = new Libros
                {
                    ISBN = txtISBN.Text,
                    Autor = txtAutor.Text,
                    Titulo = txtTitulo.Text,
                    FechaPublicacion = Convert.ToDateTime(dtpPublicacion.Text)
                };

                existencias existencia = new existencias
                {
                    CodLibro = libro.CodLibro,
                    cantidad = Convert.ToInt32(txtCantidadEjemplares.Text)
                };

                new Cls_Libros().AgregarLibro(libro, existencia);
                 
                MessageBox.Show("Libro guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }//fin evento agregar

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    Libros libro = new Cls_Libros().ConsultarLibro(Convert.ToInt32(txtCodigo.Text));
                    txtISBN.Text = libro.ISBN;
                    txtTitulo.Text = libro.Titulo;
                    txtAutor.Text = libro.Autor;
                    dtpPublicacion.Text = ""+libro.FechaPublicacion;

                    existencias exis = new Cls_Existencias().Consultar(Convert.ToInt32(txtCodigo.Text));
                    txtCantidadEjemplares.Text = "" + exis.cantidad;

                    scope.Complete();

                }
                catch(Exception ex)
                {
                    scope.Dispose();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }//fin de scope
            
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            try
            {

                Libros libro = new Libros
                {
                    CodLibro = Convert.ToInt32(txtCodigo.Text),
                    ISBN = txtISBN.Text,
                    Autor = txtAutor.Text,
                    Titulo = txtTitulo.Text,
                    FechaPublicacion = Convert.ToDateTime(dtpPublicacion.Text)
                };  

                existencias existencia = new existencias
                {
                    CodLibro = libro.CodLibro,
                    cantidad = Convert.ToInt32(txtCantidadEjemplares.Text)
                };

                new Cls_Libros().ModificarLibro(libro, existencia);
                MessageBox.Show("Libro modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if(MessageBox.Show("¿Realmente desea eliminar el libro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    new Cls_Libros().EliminarLibro(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Libro eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarDataGrid()
        {
            try
            {
                dtgListaLibros.DataSource = new Cls_Libros().ListaLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FRM_Libros_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataGrid();
        }


        public void EstadoInicial()
        {
            txtCodigo.Text = "";
            txtISBN.Text = "";
            txtAutor.Text = "";
            txtTitulo.Text = "";
            txtCantidadEjemplares.Text = "";
        }

        private void dtgListaLibros_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(dtgListaLibros.CurrentRow.Cells[0].Value);
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
    }

}
