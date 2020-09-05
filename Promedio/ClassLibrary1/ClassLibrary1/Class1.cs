using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Promedionota
    {
        #region atributos
        double num1;
        double num2;
        double num3;
        double resultado;
        string error;




        #endregion

        #region metodos publicos
        public Promedionota()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            resultado = 0;
            error = "";
            
        }


            #region propiedades
        public double setnum1
        {
            set { num1 = value; }

        }
        public double setnum2
        {
            set { num2 = value; }

        }
        public double setnum3
        {
            set { num3 = value; }

        }
        public double getresultado
        {
            get { return resultado; }
        }
        public string geterror
        {
            get { return error; }
        }



        #endregion
        public bool Promedio()
        {
            if (!validar())
                return false;
            try
            {

                resultado = (num1 + num2 + num3) / 3;
                return true;
            }
            catch (Exception x)
            {
                error = x.Message;
                return false;
            }
        }





        #endregion

        #region metodo privado
        private bool validar()
        {
            if (num1<0 || num1>5 || num2<0 || num2>5 || num3<0 || num3>5)
            {
                error = "Ingrese numero mayor a 0 y menor a 5";

                return false;
            
            }return true;
        }
        
        
        #endregion


    }
}

