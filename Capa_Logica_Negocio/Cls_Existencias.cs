using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Capa_Logica_Negocio
{
    public class Cls_Existencias
    {
        Cls_Existencias_DAL existenciasDAL = new Cls_Existencias_DAL();

        public void Agregar(existencias exis)
        {
            try
            {
                existenciasDAL.AgregarExistencia(exis);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public existencias Consultar(int codLib)
        {
            try
            {
                return existenciasDAL.ConsultarExistencia(codLib);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public void Modificar(existencias exis)
        {
            try
            {
                existenciasDAL.ModificarExistencia(exis.CodLibro, Convert.ToInt16(exis.cantidad));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int codLib)
        {
            try
            {
                existenciasDAL.EliminarExistencia(codLib);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean ValidarExistencia(string pCodLibro, decimal pCantidad)
        {
            try
            {               
                return existenciasDAL.ValidarExistencias(Convert.ToInt32(pCodLibro), Convert.ToInt32(pCantidad));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
