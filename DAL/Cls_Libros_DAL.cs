using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAL
{
    public class Cls_Libros_DAL
    {
        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();
        Libros libro;

        public void AgregarLibro(Libros libro)
        {
            try
            {
                using (DB_BibliotecaEntities contexto = new DB_BibliotecaEntities())
                {
                    contexto.Libros.Add(libro);
                    contexto.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Libros ConsultarLibro(int pIdLibro)
        {
            try
            {
                return miContexto.Libros.Single(Libros => Libros.CodLibro == pIdLibro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Array ListaLibros()
        {
            try
            {
                var listaLibros =
                    from Libros in miContexto.Libros
                    join existencias in miContexto.existencias on Libros.CodLibro equals existencias.CodLibro
                    orderby Libros.CodLibro
                    select new
                    {
                        CodigoLibro = Libros.CodLibro,
                        ISBN = Libros.ISBN,
                        Titulo = Libros.Titulo,
                        Autor = Libros.Autor,
                        CantidadEjemplares = existencias.cantidad,
                        FechaPublicacion = Libros.FechaPublicacion              
                    };
                return listaLibros.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarLibro(Libros pLibro)
        {
            try
            {
                libro = ConsultarLibro(pLibro.CodLibro);
                libro.Titulo = pLibro.Titulo;
                libro.Autor = pLibro.Autor;
                libro.FechaPublicacion = pLibro.FechaPublicacion;
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarLibro(int pCodLib)
        {
            try
            {
                libro = miContexto.Libros.First(Libros => Libros.CodLibro ==pCodLib);
                miContexto.Libros.Remove(libro);
                miContexto.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



    }

}

