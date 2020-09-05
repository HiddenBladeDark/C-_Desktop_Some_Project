using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using regla;

namespace LNnomina
{
    public class LNnominas
    {

        #region atributos
        private double sueld;
        private double dia;
        private double resul;
        private double aux;
        private string error;
        private double bonif;
        private double sueldoB;
        private double auxsuel;
        private double total;
        #endregion

        #region metodos publicos
        public LNnominas()
        {
            sueld = 0;
            dia = 0;
            resul = 0;
            aux =0;
            error = "";
            bonif = 0;

        }
        #region propiedades
        
        public double Setdia
        {
            set { dia = value; }
        }
        public double Getresul
        {
            get { return resul; }
        }
        public double Getauxsuel
        {
            get { return auxsuel; }
        }
        public string Geterror
        {
            get { return error; }
        }
        public double Getbonif
        {
            get { return bonif; }
        }
        public double SetsueldoB
        {
            set { sueldoB = value; }
        }
        public double Gettotal
        {
            get { return total; }
        }
        public double Getsueld
        {
            get { return sueld; }
        }


        #endregion
        public bool calcular()
        {
            try
            {
                if (!Validar())
                {

                    return false;
                }

                sueld = (sueldoB * dia) / 30;
                if (sueldoB <= 1646232)
                {


                    aux = 97032;
                }
             

            
                RNnomina objR = new RNnomina();
                objR.Setsueldo = sueldoB;
                auxsuel = (aux * dia) / 30;
                
                if (!objR.calcular())
                {
                    error = objR.Geterror;
                    return false;
                }
                else
                {
                    bonif = objR.Getbonif;
                    resul = sueldoB * objR.Getbonif;
                    total = auxsuel + sueld + resul;
                }
                return true;
            }
            catch (Exception X)
            {
                error = X.Message;
                return false;
            }


        }
            #endregion


            #region metodo privado
            private bool Validar()
            {
            if (sueld < 0 )
            {
                error = "Ingrese numero mayor a 0";
                return false;

            }
            if(dia<0 || dia>30)
            {
                error = "Ingrese DIAS mayor a 0 y menor o igual a 30";
                return false;
            }


            return true;
            
            
        }
        #endregion;
    }
}