using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regla
{
    public class RNnomina
    {
        #region atributos
        private double sueldo;
        private double bonif;
        private string error;

        #endregion

        #region metodo publico
        public RNnomina()
        {
            sueldo = 0;
            bonif = 0;
            error = "";
        }
        #region propiedades
        public double Setsueldo
        {
            set { sueldo = value; }
        }
        public double Getbonif
        {
            get { return bonif; }
        }
        public string Geterror
        {
            get { return error; }
        }
        #endregion
        public bool calcular()
        {

            try
            {
                if (!Validar())
                
                    return false;
                
                
                if (sueldo > 3000000) { 
                
                    bonif = 0;
                    }
                
                if (sueldo>=2000000 && sueldo <= 3000000) { 
                
                    bonif = 0.15;
                   }


                if (sueldo < 2000000) { 
                    bonif = 0.25;
                    return true;
                }
                return true;

            


            }catch(Exception X)
            {
                error = X.Message;
                return false;
            }
        }
        #endregion
        #region metodo privado
        private bool Validar()
        {
            if (sueldo < 0)
            {
                error = "Ingrese sueldo mayor a 0";
                    return false;
            }return true;
        }
        #endregion

    }
}
