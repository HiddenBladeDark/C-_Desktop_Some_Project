using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_clases
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        string error;

       public Form1()
        {
            InitializeComponent();
        }

        clases.suma obj1 = new clases.suma();
        clases.menos obj2 = new clases.menos();
        clases.multi obj3 = new clases.multi();
        clases.division obj4 = new clases.division();


        private void txtnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void txtn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void txtn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void txtn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void txtn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void txtn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void txtn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void txtn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void txtn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void txtn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void txtn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void txtnrest_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void txtnmul_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void txtndiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void txtnce_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void txtnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            double suma;
            double resta;
            double divi;
            double multi;

            switch(operador){
                case "+":
                    suma = obj1.sumar((primero), (segundo));
                    pantalla.Text =suma.ToString();
                    break;
                case "-":
                    resta = obj2.restar((primero), (segundo));
                    pantalla.Text = resta.ToString();
                    break;
                case "*":
                    multi = obj3.multiplicar((primero), (segundo));
                    pantalla.Text = multi.ToString();
                    break;
                case "/":
                    divi = obj4.dividiendo((primero), (segundo));
                    pantalla.Text = divi.ToString();
                    break;

            }
        }
    }
}
