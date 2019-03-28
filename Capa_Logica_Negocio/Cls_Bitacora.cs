using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Capa_Logica_Negocio
{
    public class Cls_Bitacora
    {
        Cls_Bitacora_DAL bitacoraDAL = new Cls_Bitacora_DAL();
        public void AgregarBitacora(Bitacora bitacora)
        {
            try
            {
                bitacoraDAL.AgregarBitacora(bitacora);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
