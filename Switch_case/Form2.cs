using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string dia_rod = "";
            switch (cboOpcao.Text) {
                case "1 ou 2":
                    dia_rod = "Segunda-Feira";
                    break;
                case "3 ou 4":
                    dia_rod = "Terça-Feira";
                    break;
                case "5 ou 6":
                    dia_rod = "Quarta-Feira";
                    break;
                case "7 ou 8":
                    dia_rod = "Quinta-Feira";
                    break;
                case "9 ou 10":
                    dia_rod = "Sexta-Feira";
                    break;
            }

            lblRes.Text = "O dia de seu Rodízio é " + dia_rod;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 antigo = new Form1();
            antigo.Show();

            this.Visible = false;
        }
    }
}
