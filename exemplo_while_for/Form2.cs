using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_while_for
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 FORFORME = new Form1();

            FORFORME.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2016;

            while (contador >= 1950) {
                cboDatas.Items.Add(contador);
                contador = contador - 1;
            }
        }
    }
}
