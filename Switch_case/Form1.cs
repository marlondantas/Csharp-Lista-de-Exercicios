using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dia_escolhido = "";

            switch (cboSemana.Text)
            {
                case "Domingo":
                    dia_escolhido = "Primeiro";
                    break;
                case "Segunda":
                    dia_escolhido = "Segundo";
                    break;
                case "Terça":
                    dia_escolhido = "Terceiro";
                    break;
                case "Quarta":
                    dia_escolhido = "Quarto";
                    break;
                case "Quinta":
                    dia_escolhido = "Quinto";
                    break;
                case "Sexta":
                    dia_escolhido = "Sexto";
                    break;
                case "Sábado":
                    dia_escolhido = "Setimo";
                    break;
            }

            MessageBox.Show("Você escolheu o " + cboSemana.Text + " que é o " + dia_escolhido + " Dia da semana", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 proximo = new Form2();

            proximo.Show();
            this.Visible = false;
        }
    }
}

