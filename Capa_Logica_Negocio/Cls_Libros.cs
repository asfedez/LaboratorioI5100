using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Transactions;

namespace Capa_Logica_Negocio
{
    public class Cls_Libros
    {

        Cls_Libros_DAL libroDal = new Cls_Libros_DAL();

        public void AgregarLibro(Libros libro, existencias existencia)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    libroDal.AgregarLibro(libro);
                    new Cls_Existencias().Agregar(existencia);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
                
        }

        public Libros ConsultarLibro(int codLibro)
        {
            try
            {
                return libroDal.ConsultarLibro(codLibro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarLibro(Libros libro, existencias existencias)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    libroDal.ModificarLibro(libro);
                    new Cls_Existencias().Modificar(existencias);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }

            }

                
        }

        public void EliminarLibro(int pCodLibro)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    Libros libro = ConsultarLibro(pCodLibro);

                    new Cls_Existencias().Eliminar(libro.CodLibro);

                    libroDal.EliminarLibro(libro.CodLibro);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
                
        }

        public Array ListaLibros()
        {
            try
            {
                return libroDal.ListaLibros();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
