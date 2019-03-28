using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Windows.Forms;

namespace Capa_Logica_Negocio
{
    public class Cls_PrestamoDET
    {
        Cls_PrestamoDET_DAL detalleDAL = new Cls_PrestamoDET_DAL();

        public void AgregarDetalle(prestamoDet detalle)
        {
            try
            {
                detalleDAL.AgregarPrestamoDET(detalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public prestamoDet ConsultarDetalle(int codPrestamo)
        {
            try
            {
                //return detalleDAL.ConsultarPrestamoDET(codPrestamo);
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarDetalle(prestamoDet detalle, DataGridView dtgListaDetalle)
        {
            try
            {
                int numFila = dtgListaDetalle.RowCount - 1;
                for (int i = 0; i < numFila; i++)
                {

                    prestamoDet prestamoDEt = new prestamoDet
                    {
                        CodLibro = Convert.ToInt32(dtgListaDetalle.Rows[i].Cells[0].Value),
                        cantidad = Convert.ToInt32(dtgListaDetalle.Rows[i].Cells[2].Value)

                    };

                    detalleDAL.ModificarPresmoDET(prestamoDEt);

                    
                }

                detalleDAL.ModificarPresmoDET(detalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarDetalle(int pCodPrestamo, int codigo)
        {
            try
            {
                detalleDAL.EliminarPrestamoDET(pCodPrestamo, codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Array ListaDetalle(int pCodPrestamo)
        {
            try
            {
                return detalleDAL.ListaPrestamoDET(pCodPrestamo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarDetalles(int pCodPrestamo)
        {
            try
            {
                detalleDAL.EliminarDetalles(pCodPrestamo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
