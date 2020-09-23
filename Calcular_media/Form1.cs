using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, resultado;

            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);

            resultado = (n1 + n2 + n3) / 3;

            txtMedia.Text = resultado.ToString();

            if (resultado < 5)
            {
                MessageBox.Show("Você foi reprovado Amigo");
            }
            else if (resultado >= 7) {
                MessageBox.Show("Você foi Aprovado Amigo");
            }
            else {
                MessageBox.Show("Você Foi para a recuperação Amigo!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";

            txtMedia.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
