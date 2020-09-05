using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Conexion;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Accesodatos
    {
        
        SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        #region metodo publico
        public DataTable DatosIngresados() //nos pide un procedimiento almacenado
        {
            SqlCommand commandos = new SqlCommand("USP_Consultars"); //Procedimiento almacenado
            commandos.CommandType = CommandType.StoredProcedure; //declaramos stored procedured
            SqlDataAdapter da = new SqlDataAdapter(commandos); //Se procede ejecutar el procedimiento almacenado se guarda de "command" a "da"
            DataTable dt = new DataTable(); //Creamos datatable para llenarlo con da

            da.Fill(dt); //vaciamos el da para almacenarlo en "dt"
            return dt; //retornamos el dt
        }

        #endregion
    }
}
