using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class Negocio
    {
        //Intanciamos consulta sql
        private Consultas ObjCon = new Consultas();


        //Guardar los registros de la tabla
        public DataTable MostrarEmpleado()
        {
            DataTable Table = new DataTable();
            Table = ObjCon.Mostrar();

            return Table;

        }
        public void IngresarEmpleado (String Cedula, String Nombre, String Apellido, String Direccion, String telefono, Double Salario)
        {
            ObjCon.InsertarDatos(Cedula, Nombre, Apellido, Direccion, telefono, Convert.ToDouble(Salario));
        }


    }

          

    }

