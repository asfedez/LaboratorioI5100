using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Cls_Existencias_DAL
    {
        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();
        existencias existencias;

        public void AgregarExistencia(existencias pExis)
        {
            try
            {

                miContexto.existencias.Add(pExis);
                miContexto.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public existencias ConsultarExistencia(int pIdLibro)
        {
            try
            {
                return miContexto.existencias.Single(existencias => existencias.CodLibro == pIdLibro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarExistencia(int pCodLib, int cantidad)
        {
            try
            {
                existencias = miContexto.existencias.Single(existencias => existencias.CodLibro == pCodLib);
                existencias.cantidad = cantidad;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarExistencia(int pCodLib)
        {
            try
            {
                existencias = miContexto.existencias.Single(existencias => existencias.CodLibro == pCodLib);
                miContexto.existencias.Remove(existencias);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean ValidarExistencias(int pCodLibro, int pCantidad)
        {
            try
            {
                existencias = miContexto.existencias.Single(existencias => existencias.CodLibro == pCodLibro);
                if((existencias.cantidad-pCantidad)<0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            


        }



    }
}
