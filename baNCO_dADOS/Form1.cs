using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace baNCO_dADOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;


            try
            {
                con.Open();

                MySqlCommand cnm = new MySqlCommand();
                cnm.CommandText = "SELECT * FROM TBOD_CLIENTES";
                cnm.CommandType = CommandType.Text;
                cnm.Connection = con;

                DataTable tabela = new DataTable();
                tabela.Load(cnm.ExecuteReader());

                dgvClientes.DataSource =tabela;
                dgvClientes.Refresh();


                con.Close();

                MessageBox.Show("Conexao realizada com sucesso");
            }
            catch (Exception xe)
            {
                MessageBox.Show("Deu erro irmão: "+xe.ToString());
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
