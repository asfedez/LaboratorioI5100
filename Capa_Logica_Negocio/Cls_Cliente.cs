using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Capa_Logica_Negocio
{
    public class Cls_Cliente
    {

        Cls_Cliente_DAL clienteDAL = new Cls_Cliente_DAL();

        public void AgregarCliente(clientes cliente)
        {
            try
            {
                clienteDAL.AgregarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public clientes Consultar(string pCedula)
        {
            try
            {
                return clienteDAL.ConsultarCliente(pCedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(clientes cliente)
        {
            try
            {
                clienteDAL.ModificarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(string pCedula)
        {
            try
            {
                clienteDAL.EliminarCliente(pCedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
