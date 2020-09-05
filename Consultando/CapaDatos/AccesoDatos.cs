using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class AccesoDatos
    {
        #region metodo publico
        private SqlConnection ConexionDB = new SqlConnection("Server=.;DataBase= Practica;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (ConexionDB.State == ConnectionState.Closed)
                ConexionDB.Open();
            return ConexionDB;
        }

        public SqlConnection CerrarConexion()
        {
            if (ConexionDB.State == ConnectionState.Open)
            
                ConexionDB.Close();
                return ConexionDB;
            
        }


        #endregion
    }
}
