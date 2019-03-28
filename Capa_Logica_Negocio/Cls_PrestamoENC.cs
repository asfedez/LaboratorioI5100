using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Transactions;
using System.Windows.Forms;

namespace Capa_Logica_Negocio
{
    public class Cls_PrestamoENC
    {
        Cls_PrestamoENC_DAL encabezadoDAL = new Cls_PrestamoENC_DAL();

        public void AgregarEncabezado(prestamoEnc encabezado)
        {
            try
            {
                encabezadoDAL.AgregarPrestamoENC(encabezado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public prestamoEnc ConsultarEncabezadp(int codPrestamo, DataGridView dtgListaDetalle)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    Array Lista = new Cls_PrestamoDET().ListaDetalle(codPrestamo);

                    Libros lib;
                    foreach (prestamoDet per in Lista)
                    {
                        lib = new Cls_Libros().ConsultarLibro(per.CodLibro);
                        dtgListaDetalle.Rows.Add(per.CodLibro, lib.Titulo, per.cantidad);
                    }

                    prestamoEnc enc = encabezadoDAL.ConsultarPrestamoENC(codPrestamo);
                    scope.Complete();
                    return enc;
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
                
        }

        public void ModificarEncabezado(prestamoEnc encabezado)
        {
            try
            {
                encabezadoDAL.ModificarPresmoENC(encabezado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarEncabezado(int pCodPrestamo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    new Cls_PrestamoDET().EliminarDetalles(pCodPrestamo);
                    encabezadoDAL.EliminarPrestamoENC(pCodPrestamo);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
                
        }

        /// <summary>
        /// Metodo para agregar Los prestamos 
        /// </summary>
        public void Agregar(prestamoEnc encabezado, DataGridView dtgListaDetalle)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    encabezadoDAL.AgregarPrestamoENC(encabezado);

                    int numFila = dtgListaDetalle.RowCount - 1;
                    for (int i = 0; i < numFila; i++)
                    {

                        prestamoDet detalle = new prestamoDet
                        {
                            CodPrestamo = encabezado.CodPrestamo,
                            CodLibro = Convert.ToInt32(dtgListaDetalle.Rows[i].Cells[0].Value),
                            cantidad = Convert.ToInt32(dtgListaDetalle.Rows[i].Cells[2].Value)

                        };

                        new Cls_PrestamoDET().AgregarDetalle(detalle);
                    }

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
        }

    }

}

