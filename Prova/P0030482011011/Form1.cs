using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prova_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] arrayVendas = new double[1, 4];
        double totSemana, totMes, totGeral;
        string valor;




        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    valor = Interaction.InputBox("Entrada de dados", "Digite o valor de vendas.");

                    double vendas = double.Parse(valor);

                    totSemana = vendas;
                    totMes = totMes + totSemana;
                    

                    lstbxSaidas.Items.Add($" Total da semana {j + 1}: {totSemana:c2}");

                }
                totGeral = totGeral + totMes;

                lstbxSaidas.Items.Add($" Total do mês: {totMes:c2}");
                lstbxSaidas.Items.Add($" Total geral: {totGeral:c2}");

            }
        }
    }
}
