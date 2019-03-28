using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;


namespace DAL
{
    public class Cls_PrestamoDET_DAL
    {
        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();
        prestamoDet prestamoDET;

        public void AgregarPrestamoDET(prestamoDet prestamoDET)
        {
            try
            {
                using (DB_BibliotecaEntities contexto = new DB_BibliotecaEntities())
                {
                    contexto.prestamoDet.Add(prestamoDET);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Array ListaPrestamoDET(int pCodPrestamo)//consultar
        {
            try
            {
                var prestamoDETA =
                    from prestamoDet in miContexto.prestamoDet
                    where prestamoDet.CodPrestamo==pCodPrestamo
                    select prestamoDet;

                return  prestamoDETA.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///public prestamoDet ConsultarDet

        public void ModificarPresmoDET(prestamoDet pPrestamoDET)
        {
            try
            {
                var lista =
                    from detalle in miContexto.prestamoDet
                    where detalle.CodLibro == pPrestamoDET.CodLibro && detalle.CodPrestamo == pPrestamoDET.CodPrestamo
                    select detalle;

                foreach(prestamoDet pres in lista)
                {
                    pres.cantidad = pPrestamoDET.cantidad;
                }

                miContexto.SaveChanges(); 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPrestamoDET(int pCodPrestamo, int pcodLibrp)
        {
            try
            {
                prestamoDET = miContexto.prestamoDet.First(prestamoDet => prestamoDet.CodPrestamo == pCodPrestamo);
                miContexto.prestamoDet.Remove(prestamoDET);
                miContexto.SaveChanges();
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
                Array lista = ListaPrestamoDET(pCodPrestamo);
                foreach(prestamoDet pres in lista)
                {
                    miContexto.prestamoDet.Remove(pres);
                }
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
