using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Class1
    {
        #region atributos
        public String cc;
        public String nombre;
        public String apellido;
        public String direccion;
        public double salario;
        #endregion

        #region propiedades
        public String Setcc
        {
            set { Setcc = value; }
        }
        public String Getcc
        {
            get { return cc; }
        }
        public string Setnombre
        {
            set { nombre = value; }
        }
        public string Getnombre
        {
            get { return nombre; }
        }
        public string Setapellido
        {
            set { apellido = value; }
        }
        public string Getapellido
        {
            get { return apellido; }
        }
        public string Setdireccion
        {
            set { direccion= value; }
        }
        public string Getdireccion
        {
            get { return direccion; }
        }
        public double Setsalario
        {
            set { salario = value; }
        }
        public double Getsalario
        {
            get { return salario; }
        }

        #endregion


    }
}
