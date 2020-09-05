using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_de_negocios;

namespace AppPrese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;

            try
            {
                N = Convert.ToInt32(txtnit.Text);

                lbl_LN_EMP objL = new lbl_LN_EMP();
                objL.Nit = N;
                if (!objL.Consultar(objL.Nit))
                {
                    MessageBox.Show(objL.Error);

                    return;
                }
                else
                {
                    txtnom.Text = objL.Nit.ToString();
                    txtsal.Text = objL.Nombre.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
