using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Sirve para manejar todos los metodos y variables sql//

namespace CapaAccesoDatos
{
    public class LBparametros
    {
        //atributos de un parametro DECLARACION DE PARAMETROS

        #region propiedades
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }
        #endregion


        #region metodos publicos
        //Constructores
        //entradas
        public LBparametros (string objNombre, Object objvalor)
        {
            Nombre = objNombre;
            Valor = objvalor;
            Direccion = ParameterDirection.Input;  //entrada 

        }
                //salida
                public LBparametros(string objNombre,SqlDbType objTipoDato, Int32 objtamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = objtamaño;
            Direccion = ParameterDirection.Output; //salida

        }
        #endregion
    }
}
