using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DyakonenkoFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlconnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lirex\source\repos\DyakonenkoFormsApp1\DyakonenkoFormsApp1\Database1.mdf;Integrated Security=True");
            sqlconnection.Open();
            if (sqlconnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установленно");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sqlconnection
        }
    }
}
