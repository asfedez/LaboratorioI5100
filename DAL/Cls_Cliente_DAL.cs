using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace DAL
{
    public class Cls_Cliente_DAL
    {

        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();
        clientes cliente;

        public void AgregarCliente(clientes cliente)
        {
            try
            {
                using (DB_BibliotecaEntities contexto = new DB_BibliotecaEntities())
                {
                    contexto.clientes.Add(cliente);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public clientes ConsultarCliente(string pCedu)
        {
            try
            {
                return miContexto.clientes.Single(clientes => clientes.Cedula == pCedu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarCliente(clientes pCliente)
        {
            try
            {
                cliente = ConsultarCliente(pCliente.Cedula);
                cliente.Nombre = pCliente.Nombre;
                cliente.Telefono = pCliente.Telefono;
                cliente.Direccion = pCliente.Direccion;
                cliente.fechaNacimiento = pCliente.fechaNacimiento;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarCliente(string pCedula)
        {
            try
            {
                cliente = miContexto.clientes.First(clientes => clientes.Cedula == pCedula);
                miContexto.clientes.Remove(cliente);
                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
