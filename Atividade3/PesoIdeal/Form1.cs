using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        Double peso, altura, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtboxPeso.Text, out peso)) && (double.TryParse(txtboxAltura.Text, out altura)))
            {
                if(rbttnMasc.Checked)
                {
                    resultado = (72.7 * altura) - 58;

                }
            else if(rbttnFem.Checked)
               {
                    resultado = (62.1 * altura) - 44.7;

                }
                if(resultado<peso)
                {
                    MessageBox.Show("Regime.Obrigatório.Já.");
                }
                else if(resultado==peso)
                {
                    MessageBox.Show("Peso ideal!");

                }
                else if(resultado>peso)
                {
                    MessageBox.Show("Coma a vontade!");
                    
                }


            }

            
        }
    }
}
