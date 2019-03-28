using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Biblioteca general de acceso
using System.Data.SqlClient;//Biblioteca de coneccion con sql server
using Capa_Logica_Negocio;//Bibliotea de la logica del negocio

namespace Capa_Acceso_Datos
{
    public class Cls_Usuario_ADO
    {
        #region "Variables"
        private string strConexion;
        private SqlConnection sqlConexion;
        private SqlCommand sqlComando;
        #endregion

        #region "Constructor"
        public Cls_Usuario_ADO(string pStringConexion)
        {
            this.StringConexion = pStringConexion;
        }
        #endregion

        #region "Propiedades"
        public string StringConexion
        {
            get
            {
                return this.strConexion;
            }
            set
            {
                this.strConexion = value.Trim();
            }
        }
        #endregion

        #region Metodos
        public void InsertarNombre(string nombre)
        {
            try
            {
                this.sqlConexion = new SqlConnection(this.StringConexion);
                this.sqlComando = new SqlCommand();
                this.sqlConexion.Open();
                this.sqlComando.Connection = this.sqlConexion;


                this.sqlComando.CommandText = "insert into nombres values('"+nombre+"')";
                this.sqlComando.CommandType = CommandType.Text;
                this.sqlComando.ExecuteNonQuery();

                this.sqlConexion.Close();
                this.sqlComando.Dispose();
                this.sqlConexion.Dispose();

            }//fin de try
            catch (Exception ex)
            {
                throw ex;
            }//fin de catch
        }
        #endregion

    }
}
