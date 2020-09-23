using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 5) {

                bool produtoExiste = false;
                int produtoCod = Convert.ToInt32(txtCodigo.Text);

                for (int i = 0; i < codigo.Length; i++)
                {
                    if (txtCodigo.Text == codigo[i]) {
                        produtoExiste = true;
                    }
                }



                if (produtoExiste) {
                    lstCaixa.Items.Add(produtoCod.ToString() + " : " + produtos[produtoCod] + " --R$" + valor[produtoCod].ToString());

                    soma = soma + valor[produtoCod];
                    lblValorTotal.Text = "R$" + soma.ToString();

                    picProduto.ImageLocation = @"C:\Users\marlo\Documents\Fundação BRadesco\Arquivos de apoio\C# - Básico\Imagens de apoio para desenvolvimento\" + produtos[produtoCod] + ".jfif";

                    txtCodigo.Text = "";

                    txtCodigo.Focus();
                }
                else
                {
                    picProduto.ImageLocation = "";

                    txtCodigo.Text = "";
                    txtCodigo.Focus();

                    MessageBox.Show("Produto não encontrado!", "Aviso");
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soma = 0;
            carregarArray();
        }

        public void carregarArray() {
            for (int i = 0; i < 10; i++)
            {
                codigo[i] = "0000" + i.ToString();
                valor[i] = (i * 10.1) + 1;
            }

            produtos[0] = "pastel";
            produtos[1] = "pizza";
            produtos[2] = "coxinha";
            produtos[3] = "shushi";
            produtos[4] = "tapioca";
        }
    }
}
