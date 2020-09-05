using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rnegocio
{
    public class Reglanegocio
    {
        #region atributos
        private double valorT;
        private double porcen;
        private string error;
        #endregion

        #region metodos privados
        private bool validar()
        {
            if (valorT < 0)
            {
                error = "Faltan datos";
                return false;
            }
            return true;
        }
        #endregion



        #region metodos publicos
        public Reglanegocio()
        {
            valorT = 0;
            error = "";
            porcen = 0;
        }

        

        #region propiedades
        public double SetvalorT
        {
            set { valorT = value; }
        }
        public string Geterror
        {
            get { return error; }
        }
        public double Getporcen
        {
            get { return porcen; }
        }
        #endregion
        public bool hallar()
        {
            if (!validar())
                return false;
            else
            {

            } 

            if(valorT>=1000000)
            
                porcen = 0.20;
            
            else
            
                porcen = 0.05;
                return true;
            
        }
        #endregion



    }
}
    
        


    

