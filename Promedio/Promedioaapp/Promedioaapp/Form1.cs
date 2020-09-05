using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Promedioaapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3;
            
            try
            {
                n1 =Convert.ToDouble(txtn1.Text);
                n2 = Convert.ToDouble(txtn2.Text);
                n3 = Convert.ToDouble(txtn3.Text);

                Promedionota ObjP = new Promedionota();

                ObjP.setnum1 = n1;
                ObjP.setnum2 = n2;
                ObjP.setnum3 = n3;
                
                if (!ObjP.Promedio())

                    {
                    MessageBox.Show(ObjP.geterror);
                    return;


                }
                result.Text = ObjP.getresultado.ToString();
            }catch(Exception x)
            {
                
                MessageBox.Show(x.Message);
            }           
        }
    }
}
