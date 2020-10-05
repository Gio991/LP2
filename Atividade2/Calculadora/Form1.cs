using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double numero1,numero2,resultado;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))

            {

                resultado = numero1 + numero2;
                txtNum3.Text = resultado.ToString();
            }

            else

                MessageBox.Show("Números inválidos!");
                           
    }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))

            {

                resultado = numero1 - numero2;
                txtNum3.Text = resultado.ToString();
            }

            else

                MessageBox.Show("Números inválidos!");
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))

            {

                resultado = numero1 * numero2;
                txtNum3.Text = resultado.ToString();
            }

            else

                MessageBox.Show("Números inválidos!");
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))

            {
                if (numero2 == 0)
                
                { MessageBox.Show("Erro! Denominador não pode ser zero!"); }

                else
                {
                    resultado = numero1 / numero2;
                    txtNum3.Text = resultado.ToString();
                }
            }

            else

                MessageBox.Show("Números inválidos!");
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtNum1.Text="";
            txtNum2.Text = "";
            txtNum3.Text="";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblres_Click(object sender, EventArgs e)
        {

        }
    }
}
