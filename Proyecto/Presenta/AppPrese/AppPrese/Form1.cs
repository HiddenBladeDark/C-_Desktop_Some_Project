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
using System.Data.SqlClient;
using LibParametro;

namespace AppPrese
{
    public partial class Form1 : Form
    {

        //Llamamos metodo de SqlConnection para la funcion de la DataGridView solamente la cual servira en el evento del BOTON "Consultar"
        SqlConnection conexion = new SqlConnection("server=DESKTOP-OCF82RR\\SQLEXPRESS;database=BD_CD_Ejemplo;integrated security = true");




        private void cempleado()
        {
            //metodo para consultar
            try
            {

                string nit = txtnit.Text;
                lbl_LN_EMP objL = new lbl_LN_EMP();
                objL.Nit = Convert.ToInt32(nit);
                if (!objL.Consultar(objL.Nit))
                {
                    MessageBox.Show(objL.Error);
                    objL = null;
                    return;
                }
                if (objL.ObjLeer.HasRows)
                {
                    objL.ObjLeer.Read();
                    txtnom.Text = objL.ObjLeer.GetString(1);
                    txtape.Text = objL.ObjLeer.GetString(2);
                    txttel.Text = objL.ObjLeer.GetString(3);
                    txtsal.Text = objL.ObjLeer.GetDecimal(4).ToString();

                    objL.ObjLeer.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void AñadirUser()

        { lbl_LN_EMP ObjAña = new lbl_LN_EMP();
            try
                //Metodo para Insertar Datos
            {


                ObjAña.Nit = Convert.ToInt32(txtnit.Text);
                ObjAña.Nombre = txtnom.Text;
                ObjAña.Apellido = txtape.Text;
                ObjAña.Telefono = Convert.ToInt32(txttel.Text);
                ObjAña.Salario = Convert.ToDouble(txtsal.Text);


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
            if (!ObjAña.InsertarDatos())
            {
                MessageBox.Show("Se guardo correctamente datos ingresados");

                return;
            }
            else
            {
                MessageBox.Show(ObjAña.Error);
                return;
            }
        }
        private void EliminarUser()
        {
            {
                lbl_LN_EMP ObjAña = new lbl_LN_EMP();
                try
                    //Metodo para Eliminar datos
                {


                    ObjAña.Nit = Convert.ToInt32(txtnit.Text);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (!ObjAña.EliminarDatos())
                {
                    MessageBox.Show("Se elimino correctamente los datos especificos");

                    return;
                }
                else
                {
                    MessageBox.Show(ObjAña.Error);
                    return;
                }
            }
        }
        private void ModificarUser()

        {
            //Metodo para Modificar Datos

            lbl_LN_EMP ObjAña = new lbl_LN_EMP();
            try
            {


                ObjAña.Nit = Convert.ToInt32(txtnit.Text);
                ObjAña.Nombre = txtnom.Text;
                ObjAña.Apellido = txtape.Text;
                ObjAña.Telefono = Convert.ToInt32(txttel.Text);
                ObjAña.Salario = Convert.ToDouble(txtsal.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (!ObjAña.ActualizarDatos())
            {
                MessageBox.Show("Se modifico correctamente");

                return;
            }
            else
            {
                MessageBox.Show(ObjAña.Error);
                return;
            }
        }
    

        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llamamos el mtodo de consulta en el evento del boton de Consultar
            cempleado();
            try
            {
             
                SqlCommand COMANDO = new SqlCommand("select * from empleado", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = COMANDO;
                DataTable table = new DataTable();
                adaptador.Fill(table);
                list.DataSource = table;

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Llamamos el metodo de guardar en el evento del boton de Guardar
            AñadirUser();
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            //Llamamos el metodo de Eliminar en el evento del boton de Eliminar
            EliminarUser();
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            //Llamamos el metodo de Modificar en el boton Modificar
            ModificarUser();
        }
    }
}
