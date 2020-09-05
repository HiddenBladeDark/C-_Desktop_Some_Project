using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNConsult;

namespace ConsultaAPP
{
    public partial class Form1 : Form
    {

        Class1 ObjEmp = new Class1();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            DataTable dt = ObjEmp.ListadoAlumnos();
            dataGridView1.DataSource = dt;
        }
    }
}
