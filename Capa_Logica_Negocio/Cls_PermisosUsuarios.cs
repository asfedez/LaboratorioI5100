using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Transactions;
using System.Windows.Forms;

namespace Capa_Logica_Negocio
{
    public class Cls_PermisosUsuarios
    {

        Cls_PermisosUsuarios_DAL permisosUserDAL = new Cls_PermisosUsuarios_DAL();

        public void Agregar(permisosAUsuarios pPermisos)
        {
            try
            {
                permisosUserDAL.Agregar(pPermisos);
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
                return permisosUserDAL.ConsultarPermisos(tag, idUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Este metodo llena los datagridview con los permisos y roles asignados a un usario en especifico
        /// </summary>
        public void ConsultarPermisosUsuario(DataGridView dtg, string nombreUsuario, DataGridView dtgRoles)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {

                    usuarios user = new Cls_Usuario().Consultar(nombreUsuario);

                    ventanas ventana;
                    Array ListaPermisos = permisosUserDAL.ListaPermisos(user.idUsuario);
                    foreach (permisosAUsuarios per in ListaPermisos)
                    {
                        ventana = new Cls_Ventanas().ConsultarVentanas(Convert.ToInt32(per.idventana));
                        dtg.Rows.Add(per.idventana, ventana.nombre, per.consultar, per.insertar, per.modificar, per.eliminar);
                    }

                    ListaPermisos = new Cls_RolAsignado().ListaRoles(user.idUsuario);
                    foreach (rolAsignadoAUsuario per in ListaPermisos)
                    {
                        roles rol = new Cls_Rol().Consultar(Convert.ToInt32(per.idRol));
                        dtgRoles.Rows.Add(per.idRol, rol.nombre );
                    }

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Este metodo elimina los permisos y roles asignados al usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        public void EliminarPermisos(string nombreUsuario)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    usuarios user = new Cls_Usuario().Consultar(nombreUsuario);

                    permisosUserDAL.EliminarPermisos(user.idUsuario);
                    new Cls_RolAsignado().EliminarRolAsignado(user.idUsuario);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw new Exception("No se puede eliminar permisos o roles asignados");
                }
            }
                


        }

        /// <summary>
        /// Este metodo permite modificar los permisos y roles asignados al usuario
        /// </summary>
        public void ModificarPermisos(string nombreUsuario, DataGridView dtgPermisos)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    usuarios user = new Cls_Usuario().Consultar(nombreUsuario);

                    //Modificar permisos
                    int numFila = dtgPermisos.RowCount - 1;
                    for (int i = 0; i < numFila; i++)
                    {

                        permisosAUsuarios permisosUsuario = new permisosAUsuarios
                        {
                            idusuario = user.idUsuario,
                            idventana = Convert.ToInt32(dtgPermisos.Rows[i].Cells[0].Value),
                            consultar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[2].Value),
                            insertar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[3].Value),
                            modificar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[4].Value),
                            eliminar = Convert.ToInt32(dtgPermisos.Rows[i].Cells[5].Value)
                        };

                        permisosUserDAL.Modificar(permisosUsuario);

                    }
                    

                    scope.Complete();

                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw ex;
                }
            }
        }





    }
}
