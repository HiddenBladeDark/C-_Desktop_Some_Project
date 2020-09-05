using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rnegocio;

namespace LogicaNegocio
{
    public class LNegicios
    {
        #region atributos
        private double valor;
        private double cant;
        private double vtotal;
        private string error;
        private double descuento;
        private double total;
        #endregion

        #region metodo publico
        public LNegicios()
        {
            valor = 0;
            cant = 0;
            vtotal = 0;
            error = "";
            descuento = 0;
            total = 0;

        }
        #region propiedades
        public double Setvalor
        {
            set { valor = value; }
        }
        public double Setcant
        {
            set { cant = value; }
        }
        public double Getvtotal
        {
            get { return vtotal; }
        }

        public double Getdescuento
        {
            get { return descuento; }
        }
        public string Geterror
        {
            get { return error; }
        }
        public double Gettotal
        {
            get { return total; }
        }

        #endregion
        public bool calcular()
        {
            try
            {
                if (!validar())
                {
                    return false;
                }
                else
                {
                    vtotal = valor * cant;
                    Reglanegocio objR = new Reglanegocio();
                    objR.SetvalorT = vtotal;
                    if (!objR.hallar())
                    {
                        
                        return false;

                    }else{
                        descuento = objR.Getporcen;
                        total =vtotal-(vtotal *objR.Getporcen);
                        return true;
                    }
                    
                    
                    
                    
                }
            }catch(Exception X)
            {
                error = X.Message;
                return false;

            }
        }

        #endregion

        #region metodos privados
        private bool validar()
        {
            
            if (vtotal<0)
            {
                error = "Ingrese valor";
                    return false;
            }
            else
            {
                return true;
            }

        }
        #endregion

    }
}
