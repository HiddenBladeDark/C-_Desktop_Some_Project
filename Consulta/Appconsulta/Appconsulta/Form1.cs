using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNegocio;
using Conexion;

namespace Appconsulta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        LogicaNegocio objNe = new LogicaNegocio();
        Class1 objClass = new Class1();

        void ListEmpleado()
        {
            DataTable dt = objNe.DatosIngresados(); //Nos retorna un datatable
            dataGridView1.DataSource = dt; //vaciar dt a datagridView
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
