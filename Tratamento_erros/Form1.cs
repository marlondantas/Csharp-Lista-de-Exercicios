using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nUm, nDois, nResultado;

            try
            {
                nUm = Convert.ToDouble(txtNum.Text);
                nDois = Convert.ToDouble(txtNdois.Text);

                nResultado = nUm + nDois;

                txtResultado.Text = nResultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode por letra irmão!", "ERRO");

                txtNum.Text = "";
                txtNdois.Text = "";

                txtNum.Focus();
            }
            finally {
                MessageBox.Show("Aperte ok, para sair do sistema!");

                this.Close();
            }
        }
    }
}
