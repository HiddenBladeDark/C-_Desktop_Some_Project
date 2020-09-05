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
using System.Xml;

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
                String Setencia = "SP_CONSULTAR'" + nit + "'";
                   
                    
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
        }
    public bool InsertarDatos()
            {
            try
            {
                String Setencia = "SP_INSERTAR'" + nit + "','" + Nombre + "','" + Apellido + "','" + Telefono + "'," + Salario;
                ClsConexion ObjCon = new ClsConexion();
                if (ObjCon.EjecutarSentencia(Setencia, false))
                {
                    error = ObjCon.Error;
                    ObjCon = null;
                    return false;

                }
                else
                {
                    ObjCon = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = "Error al guardar";
                return false;
            }

            }
        public bool EliminarDatos()
        {
            String Setencia = "SP_BORRAR'" + nit + "'";
            ClsConexion ObjCon = new ClsConexion();
            if (ObjCon.EjecutarSentencia(Setencia, false))
            {
                error = ObjCon.Error;
                ObjCon = null;
                return false;

            }
            else
            {
                ObjCon = null;
                return false;
            }

        }
        public bool ActualizarDatos()
        {
            try
            {
                String Setencia = "SP_ACTUALIZAR1'" + nit + "','" + Nombre + "','" + Apellido + "','" + Telefono + "'," + Salario;
                ClsConexion ObjCon = new ClsConexion();
                if (ObjCon.EjecutarSentencia(Setencia, false))
                {
                    error = ObjCon.Error;
                    ObjCon = null;
                    return false;

                }
                else
                {
                    ObjCon = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = "Error al modificar";
                return false;
            }

        }





        #endregion

        #region metodos privados
        #endregion

    }
}

