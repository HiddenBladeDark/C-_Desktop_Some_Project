using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNnomina;

namespace aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldobase, dias;

            try
            {
                sueldobase = Convert.ToDouble(txtsueldb.Text);
                dias = Convert.ToDouble(txtdia.Text);

                LNnominas objL = new LNnominas();

                objL.SetsueldoB = sueldobase;
                objL.Setdia = dias;

                if (!objL.calcular())
                {
                    MessageBox.Show(objL.Geterror);
                    return;
                }
                else
                {
                    txtbasic.Text = objL.Getsueld.ToString();
                    txtbonif.Text = objL.Getresul.ToString();
                    txtaux.Text = objL.Getauxsuel.ToString();
                    txtpagar.Text = objL.Gettotal.ToString();
                    return;
                }
            }catch(Exception X)
            {
                MessageBox.Show(X.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
