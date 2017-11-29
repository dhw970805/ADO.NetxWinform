using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormHomeWork
{
    public partial class Form1 : Form
    {
        private string connstr = "server=localhost;Database=taidou;uid=root;pwd=root;charset=utf8";
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private string userId;
        private DataTable dt;
        MySqlDataReader reader;
        public Form1(string id)
        {
            userId = id;
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            
            using (conn = new MySqlConnection(connstr))
            {
                conn.Open();
                string cmdctr = "select Id,email from user where Id = '" + userId + "'";
                using (cmd = new MySqlCommand(cmdctr, conn))
                {
                    reader = cmd.ExecuteReader();
                    dt=new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connstr);
            conn.Open();
            string cmdupdate = "update user set email = '" + dataGridView1.Rows[0].Cells["email"].Value+"' where Id = "+userId;
            MySqlCommand cmd = new MySqlCommand(cmdupdate,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
