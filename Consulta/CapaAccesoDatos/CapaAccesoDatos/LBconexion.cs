using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;  //conexion a base de datos

namespace CapaAccesoDatos
{
    public class LBconexion
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=Empresa;Integrated Security=True");

        //Metodo para abrir conexion

        void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }
        
        //Metodo para cerrar conexion
        void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        //metodo para ejecutar procedimiento almacenado (Insert, delete, update)

            //sirve para base de datos complejas
        public void Ejecutar_SP(String nombreSP,List<LBparametros> lista )
        {

            SqlCommand command;

            try
            {
                AbrirConexion();
                command = new SqlCommand(nombreSP, conexion);
                command.CommandType = CommandType.StoredProcedure;

                if(lista != null)
                {
                    for(int i = 0; i <lista.Count; i++)
                    {
                        if (lista[i].Direccion == ParameterDirection.Input)
                        {
                            command.Parameters.AddWithValue(lista[i].Nombre, lista[i].Valor); //Enviando un valor 
                        }
                        if (lista[i].Direccion == ParameterDirection.Output)
                        {
                            command.Parameters.Add(lista[i].Nombre, lista[i].TipoDato, lista[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    command.ExecuteNonQuery();
                    //recuperar parametro de salida
                   for(int i = 0; i < lista.Count; i++)
                    {
                        if (command.Parameters[i].Direction == ParameterDirection.Output)
                            lista[i].Valor = command.Parameters[i].Value.ToString();
                    }
                }
                
            }
            catch (Exception ex)
            {
                
            }
            CerrarConexion();
        }


        //metodo para consultar Procedimiento almacenado(select)

        public DataTable Lista (string NombreSP, List<LBparametros> lista)
        {
            DataTable dt = new DataTable();  //contiene un conjunto de datos temporal

            try { 
            SqlDataAdapter da; //permite ejecutar procedimientos almacenados
            
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lista != null)
                {
                    for (int i = 0; i<lista.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lista[i].Nombre, lista[i].Valor);
                    }
                }
                da.Fill(dt); //pasar los valores a sqldataadapter
                

            }catch(Exception ex)
            {

                
            }
            return dt;
            }

    }
}
