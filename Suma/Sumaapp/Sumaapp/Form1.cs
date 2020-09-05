using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suma;
namespace Sumaapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;

            try
            {
                n1 = Convert.ToDouble(txts1.Text);
                n2 = Convert.ToDouble(txts2.Text);

                sumar objS = new sumar();
                objS.Setnum1 = n1;
                objS.Setnum2 = n2;

                if (!objS.Calcular())
                {
                    MessageBox.Show(objS.Geterror);
                    return;
                }
                else
                {
                    txttol.Text = objS.Getresult.ToString();
                }


            }catch(Exception X)
            {
                MessageBox.Show(X.Message);
            }
        }
    }
}
