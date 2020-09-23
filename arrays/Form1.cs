using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];

            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;

            int valor = vetor[1];

            System.Array.Sort(vetor);

            for (int index = 0; index < 4; index++) {
                MessageBox.Show(vetor[index].ToString(), "Array BRO");
            }
        }

        private void btnTestarTexto_Click(object sender, EventArgs e)
        {
            string[] vetor = new string[7];

            vetor[0] = "SAG";
            vetor[1] = "TER";
            vetor[2] = "QUA";
            vetor[3] = "QUI";
            vetor[4] = "SEX";
            vetor[5] = "SAB";
            vetor[6] = "DOM";

            string valor = vetor[1];

            for (int index = 0; index < 7; index++)
            {
                MessageBox.Show(vetor[index], "Array BRO");
            }
        }
    }
}
