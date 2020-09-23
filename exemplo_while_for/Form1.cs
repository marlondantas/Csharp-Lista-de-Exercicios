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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2016; contador >= 1950; contador--) {
                cboDatas.Items.Add(contador);
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Form2 fordome2 = new Form2();
            
            fordome2.Show();
            this.Visible = false;
        }
    }
}
