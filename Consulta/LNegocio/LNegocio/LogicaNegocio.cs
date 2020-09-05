using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;
using Conexion;

namespace LNegocio
{
    public class LogicaNegocio
    {
        Accesodatos ojbDatos = new Accesodatos();

        public DataTable DatosIngresados()
        {

            return ojbDatos.DatosIngresados();

        }


    }
}
