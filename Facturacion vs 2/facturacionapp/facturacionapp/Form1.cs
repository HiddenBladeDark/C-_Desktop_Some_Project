using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Rnegocio;

namespace facturacionapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valores, cantidades;
            try
            {
                valores = Convert.ToDouble(txpre.Text);
                cantidades = Convert.ToDouble(txcant.Text);

                LNegicios objL = new LNegicios();
                objL.Setvalor = valores;
                objL.Setcant = cantidades;

                if (!objL.calcular())
                {
                    MessageBox.Show(objL.Geterror);
                    return;
                }
                else
                {
                    txval.Text = objL.Getvtotal.ToString();
                    txdesc.Text = objL.Getdescuento.ToString();
                    txtol.Text = objL.Gettotal.ToString();

                }
            }catch(Exception X)
            {
                MessageBox.Show(X.Message);
            }


        }
    }
}
