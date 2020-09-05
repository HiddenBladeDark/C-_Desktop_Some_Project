using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Consultas
    {
        private AccesoDatos Conexion = new AccesoDatos();

        SqlDataReader leer; //Leer sin modificar
        DataTable table = new DataTable();//Para almacenar las fila de las consultas
        SqlCommand Comandos = new SqlCommand(); //Para ejecutar Instruciones o procedimientos almacenados
        
        public DataTable Mostrar()
        {
            //Con Insutricones sql
            Comandos.Connection = Conexion.AbrirConexion(); //Abrir conexion con command
            Comandos.CommandText = "USP_MostrarEmpleado"; //Ejecutar la instrucion sql
            Comandos.CommandType = CommandType.StoredProcedure; //Especificar que es tipo procedimiento
            leer = Comandos.ExecuteReader();//Devuelve filas
            table.Load(leer);//Rellenar tabla
            Conexion.CerrarConexion();//Cerrar la conexion
            return table;//Retornar la tabla con los registro cargado
            //Procedimientos Almacenados

        }
        //ingresar registros

        public void InsertarDatos(String Cedula,String Nombre, String Apellido, String Direccion, String telefono, Double Salario )
        {
            Comandos.Connection = Conexion.AbrirConexion();//Abrimos Conexion
            Comandos.CommandText = "USP_IngresarEmpleado";//Instrucion SQL
            Comandos.CommandType = CommandType.StoredProcedure;//Procedimiento tipo Texto para ejecutar la instrucion sql
            
            Comandos.ExecuteNonQuery();//Ejecutamos la instrucion sql

        }


    }
}
