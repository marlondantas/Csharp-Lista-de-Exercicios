using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double calcularIMC(double imc) {

            string mensagem_resultado = "";
            
            if (imc < 18.49)
            {
                mensagem_resultado = "Você está abaixo do peso.";
            }
            else if (imc > 18.49 && imc < 24.99)
            {
                mensagem_resultado = "Você está com peso dentro da normalidade.";
            }
            else if (imc > 25 && imc < 29.99)
            {
                mensagem_resultado = "Você está acima do peso.";
            }
            else if (imc > 30 && imc < 34.99)
            {
                mensagem_resultado = "Atenção, você está com Obesidade Grau I.";
            }
            else if (imc > 35 && imc < 39.99)
            {
                mensagem_resultado = "Atenção, você está com Obesidade Grau II (severa).";
            }
            else if (imc > 40)
            {
                mensagem_resultado = "Atenção, você está com Obesidade Grau III (mórbida).";
            }

            MessageBox.Show(mensagem_resultado, "Resultado IMC",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return imc;

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*
             Declaração de variaveis
             */
            double peso, altura, imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            imc = peso / (altura * altura);

            txtIMC.Text = calcularIMC(imc).ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtIMC.Text = "";
            txtPeso.Text = "";
        }
    }
}
