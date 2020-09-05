using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;

namespace LNConsult
{
    public class Class1
    {
        #region atributos
        public Int32 cc;
        public string nombre;
        public string apellido;
        public string direccion;
        public double salario;

        #endregion
        #region propiedades
        public Int32 Setcc
        {
            set { value = cc; }
        }
        public Int32 Getcc
        {
            get { return cc; }
        }
        public string Setnombre
        {
            set { value = nombre; }
        }
        public string Getnombre
        {
            get { return nombre; }
        }
        public string Setapellido
        {
            set { value = apellido; }
        }
        public string Getapellido
        {
            get { return apellido; }
        }
        public string Setdireccion
        {
            set { value = direccion; }
        }
        public string Getdireccion
        {
            get { return direccion; }
        }
        public double Setsalario
        {
            set { value = salario; }
        }
        public double Getsalario
        {
            get { return salario; }
        }



        #endregion

        #region metodo publico

        LBconexion objConex = new LBconexion(); //agregamos la conexion
                                                //registrar alumnos
        public string EM_Registro()
        {
            
                String Mensaje = "";
            List<LBparametros> lista = new List<LBparametros>();
               

            try
            {
                //Parametros de entrada
                lista.Add(new LBparametros("@cc",cc));
                lista.Add(new LBparametros("@Nombre", nombre));
                lista.Add(new LBparametros("@Apellido", apellido));
                lista.Add(new LBparametros("@Direccion", direccion));
                lista.Add(new LBparametros("@Salario", salario));

                //parametros de salida
                lista.Add(new LBparametros("@Mensaje", SqlDbType.VarChar, 100));


                //ejecutar procedimiento almacenado
                objConex.Ejecutar_SP("EM_Registro", lista);

                //recuperar parametro de salida "@mensaje"
                Mensaje = lista[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return Mensaje;


        }
        //metodo listar alumnos
        public DataTable ListadoAlumnos()
        {
            return objConex.Lista("EM_Consulta",null);//es una consulta sin condicionales  
        }
        #endregion
    }

}
