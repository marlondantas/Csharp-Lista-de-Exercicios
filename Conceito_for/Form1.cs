using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador < 500; contador++)
            {

                //MessageBox.Show("O valor do contador é: " + Convert.ToString(contador));

                Console.WriteLine("O valor do contador é: " + Convert.ToString(contador));
            }
        }
    }
}
