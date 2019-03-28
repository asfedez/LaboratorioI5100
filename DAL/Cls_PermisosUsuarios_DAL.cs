using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Cls_PermisosUsuarios_DAL
    {

        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();
        permisosAUsuarios permisosUser;

        public void Agregar(permisosAUsuarios pPermisosUser)
        {
            try
            {

                miContexto.permisosAUsuarios.Add(pPermisosUser);
                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public permisosAUsuarios ConsultarPermisos(int tag, int idUser)
        {
            try
            {
                permisosAUsuarios permiso=null;

                var resultado =
                    from permisos in miContexto.permisosAUsuarios
                    where permisos.idventana == tag && permisos.idusuario == idUser
                    select permisos;

                foreach(permisosAUsuarios per in resultado)
                {
                    permiso = per;
                }

                return permiso;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo retorna la lista de permisos por idusuario
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public Array ListaPermisos(int pIdUsuario)
        {
            try
            {
                var ListaPermisos =
                    from permisos in miContexto.permisosAUsuarios
                    where permisos.idusuario==pIdUsuario
                    select permisos;


                return ListaPermisos.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPermisos(int pIdUsuario)
        {
            try
            {
                Array Lista = ListaPermisos(pIdUsuario);
                
                foreach(permisosAUsuarios per in Lista)
                {
                    miContexto.permisosAUsuarios.Remove(per);
                }  

                miContexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(permisosAUsuarios pPermisosUser)
        {
            try
            {

                var ListaPermisos =
                    from permisos in miContexto.permisosAUsuarios
                    where permisos.idusuario == pPermisosUser.idusuario && permisos.idventana==pPermisosUser.idventana
                    select permisos;

                foreach (permisosAUsuarios per in ListaPermisos)
                {
                    per.insertar = pPermisosUser.insertar;
                    per.consultar = pPermisosUser.consultar;
                    per.modificar = pPermisosUser.modificar;
                    per.eliminar = pPermisosUser.eliminar;

                }

                miContexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*  public roles Consultar(int codigoRol)
          {
              try
              {
                  return miContexto.roles.Single(roles => roles.idrol == codigoRol);
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }

          public void Modificar(permisosAUsuarios pPermisosUser)
          {
              try
              {
                  permisosUser = miContexto.permisosDeRol.Single(permisosDeRol => permisosDeRol.idrol == pPermisosUser.idrol);
                  permisosUser.idusuario
                  rol.nombre = pRol.nombre;
                  miContexto.SaveChanges();

              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }

          public void EliminarRol(int idPermiso)
          {
              try
              {
                  rol = miContexto.roles.First(roles => roles.idrol == pIDRol);
                  miContexto.roles.Remove(rol);
                  miContexto.SaveChanges();
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }

          public Array ListaRoles()
          {
              try
              {
                  var listaRol =
                      from rol in miContexto.roles
                      select new
                      {
                          ID_Rol = rol.idrol,
                          Nombre = rol.nombre
                      };
                  return listaRol.ToArray();
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }*/
    }
}
