using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using LibParametro;
using LibConexionBD;

namespace Logica_de_negocios
{
    public class lbl_LN_EMP
    {
        #region atributos
        private SqlDataReader objLeer;
        private string nombre, apellido, usuario, contraseña, error;
        private int nit, telefono;
        private double salario;
        #endregion

        #region propiedades
        public SqlDataReader ObjLeer
        {
            get
            {
                return objLeer;
            }

            set
            {
                objLeer = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        public int Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
        #endregion

        #region metodos publicos
        public bool Consultar(int nit)
        {
            try
            {
                ClsConexion objConex = new ClsConexion();
                String Setencia = "USP_Consultars'" + nit + "'";
                if (objConex.Consultar(Setencia, false))
                {
                    objLeer = objConex.Reader;
                    objConex = null;
                    return true;
                }
                else
                {
                    error = objConex.Error;
                    objConex = null;
                    return false;
                }





            }
            catch (Exception X)
            {
                error = X.Message;
                return false;
            }
            #endregion

            #region metodos privados
            #endregion

        }
    }
}
