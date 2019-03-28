using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAL
{
   public class Cls_PrestamoENC_DAL
    {
        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();
        prestamoEnc prestamoENC;

        public void AgregarPrestamoENC(prestamoEnc prestamoENC)
        {
            try
            {
                using (DB_BibliotecaEntities contexto = new DB_BibliotecaEntities())
                {
                    contexto.prestamoEnc.Add(prestamoENC);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public prestamoEnc ConsultarPrestamoENC(int pCodPrestamo)
        {
            try
            {
                return miContexto.prestamoEnc.Single(prestamoEnc => prestamoEnc.CodPrestamo == pCodPrestamo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public void ModificarPresmoENC(prestamoEnc pPrestamoENC)
        {
            try
            {
                prestamoENC = ConsultarPrestamoENC(pPrestamoENC.CodPrestamo);
                prestamoENC.fechaPrestamo = pPrestamoENC.fechaPrestamo;
                prestamoENC.fechaDevoluvion = pPrestamoENC.fechaDevoluvion;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPrestamoENC(int pCodPrestamo)
        {
            try
            {
                prestamoENC = miContexto.prestamoEnc.First(prestamoEnc => prestamoEnc.CodPrestamo == pCodPrestamo);
                miContexto.prestamoEnc.Remove(prestamoENC);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
