using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    public class sumar
    {
        #region atributos
        private double num1;
        private double num2;
        private double result;
        private string error;
        #endregion
        #region propiedades
        public double Setnum1
        {
            set { num1 = value; }

        }
        public double Setnum2
        {
            set { num2 = value; }
        }
        public double Getresult
        {
            get { return result; }
        }
        public string Geterror
        {
            get { return error; }
        }

        #endregion

        #region Metodos Publicos
        public sumar()
        {
            num1 = 0;
            num2 = 0;
            result = 0;
            error = "";


        }
        public bool Calcular()
        {
            try { 
            if (!Validar())
            {
                return false;

            }
            else
            {
                result = num1 + num2;
                    return true;
            }
        }catch(Exception X)
            {
                error = X.Message;
                return false;
            }
        }

        #endregion

        #region metodos privados
        private bool Validar()
        {
            if (num1 < 0 || num2 < 0) { 
                error = "Ingrese Numero mayor a 0";
            return false;
        }
            return true;
           
        }
        
        #endregion

    }
}
