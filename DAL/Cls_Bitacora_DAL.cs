using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace DAL
{
    public class Cls_Bitacora_DAL
    {
        private DB_BibliotecaEntities miContexto = new DB_BibliotecaEntities();

        public void AgregarBitacora(Bitacora bitacora)
        {
            try
            {
                miContexto.Bitacora.Add(bitacora);
                miContexto.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
