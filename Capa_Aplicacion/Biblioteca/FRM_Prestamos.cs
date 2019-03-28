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
    public partial class FRM_Prestamos : Form
    {
        #region Variables
        DateTime prestamo;
        DateTime devolucion;
        int numFila;
        int contadorLibros=0;
        #endregion


        public FRM_Prestamos()
        {
            InitializeComponent();
        }

        private void FRM_Prestamos_Load(object sender, EventArgs e)
        {
            
            prestamo = Convert.ToDateTime(dtpPrestamo.Text);
            devolucion = Convert.ToDateTime(dtpDevolucion.Text);
            dtpDevolucion.Text = "" + prestamo.AddDays(15);
            contadorLibros = 0;
        }

        private void dtpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            prestamo = Convert.ToDateTime(dtpPrestamo.Text);
            devolucion = Convert.ToDateTime(dtpDevolucion.Text);
            if ((devolucion - prestamo).TotalDays > 15)
            {
                dtpDevolucion.Text = "" + prestamo.AddDays(15);
                MessageBox.Show("Los prestamos no pueden ser mayores a 15 días", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsRaCli_Click(object sender, EventArgs e)
        {
            try
            {
                clientes cliente = new Cls_Cliente().Consultar(txtCed.Text);

                txtCed.Text = cliente.Cedula;
                txtNomCliente.Text = cliente.Nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsRaLib_Click(object sender, EventArgs e)
        {
            try
            {
                Libros libro = new Cls_Libros().ConsultarLibro(Convert.ToInt32(txtCodLibro.Text));
                txtCodLibro.Text = ""+libro.CodLibro;
                txtNomCli.Text = libro.Titulo;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(contadorLibros<3)
                {
                    numFila = dtgListaDetalle.RowCount - 1;
                    bool existe = false;
                    for (int i = 0; i < numFila; i++)
                    {
                        if ("" + dtgListaDetalle.Rows[i].Cells[0].Value == txtCodLibro.Text)
                        {
                            existe = true;
                        }
                    }

                    if (existe)
                    {
                        throw new Exception("No se puede ingresar el mismo libro");
                    }
                    else
                    {
                        if (new Cls_Existencias().ValidarExistencia(txtCodLibro.Text, txtCantidad.Value))
                        {
                            contadorLibros += Convert.ToInt32(txtCantidad.Value);
                            dtgListaDetalle.Rows.Add(txtCodLibro.Text, txtNomCli.Text, txtCantidad.Value);
                        }
                        else
                        {
                            throw new Exception("Existencias insuficientes");
                        }
                    }
                }
                else
                {
                    throw new Exception("Cantidad de libros excedida");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                prestamoEnc encabezado = new prestamoEnc
                {
                    cedula = txtCed.Text,
                    fechaPrestamo = Convert.ToDateTime(dtpPrestamo.Text),
                    fechaDevoluvion = Convert.ToDateTime(dtpDevolucion.Text)
                };

                new Cls_PrestamoENC().Agregar(encabezado, dtgListaDetalle);

                MessageBox.Show("Prestamo guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                prestamoDet detalle = new prestamoDet
                {
                    CodPrestamo = Convert.ToInt32(txtCodPrestamo.Text),
                    CodLibro = Convert.ToInt32(txtCodLibro.Text),
                    cantidad = Convert.ToInt32(txtCantidad.Value)
                };

                new Cls_PrestamoDET().ModificarDetalle(detalle, dtgListaDetalle);

                MessageBox.Show("Prestamo modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                prestamoEnc encabezado = new Cls_PrestamoENC().ConsultarEncabezadp(Convert.ToInt32(txtCodPrestamo.Text), dtgListaDetalle);

                txtCed.Text = encabezado.cedula;
                txtNomCliente.Text = new Cls_Cliente().Consultar(txtCed.Text).Nombre;
                dtpPrestamo.Text = "" + encabezado.fechaPrestamo;
                dtpDevolucion.Text = "" + encabezado.fechaDevoluvion;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void EstadoInicial()
        {
            txtCed.Text = "";
            txtNomCliente.Text = "";
            txtCodLibro.Text = "";
            txtNomCli.Text = "";
            txtCodPrestamo.Text = "";

            numFila = dtgListaDetalle.RowCount - 1;
            for (int i = 0; i < numFila; i++)
            {
                dtgListaDetalle.Rows.RemoveAt(0);
            }

        }

        private void dtgListaDetalle_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCodLibro.Text = ""+dtgListaDetalle.Rows[e.RowIndex].Cells[0].Value;
            txtNomCli.Text = "" + dtgListaDetalle.Rows[e.RowIndex].Cells[1].Value;
            txtCantidad.Text = "" + dtgListaDetalle.Rows[e.RowIndex].Cells[2].Value;


            dtgListaDetalle.Rows.RemoveAt(e.RowIndex);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar el prestamo?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new Cls_PrestamoENC().EliminarEncabezado(Convert.ToInt32(txtCodPrestamo.Text));
                    MessageBox.Show("Prestamo eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
