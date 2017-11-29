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
    public partial class SignIn : Form
    {
        private string connstr = "server=localhost;Database=taidou;uid=root;pwd=root;charset=utf8";
        public SignIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sure_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();
                if (passwod.Text == surepassword.Text)
                {
                    string cmd = "insert into user (Id,password,email) values (" + userid.Text + "," + passwod.Text + "," +
                                 email.Text + ")"; //insert into 表名(字段名1,字段名2) values(值1,值2)
                    using (MySqlCommand conncmd=new MySqlCommand(cmd,conn))
                    {
                        conncmd.ExecuteNonQuery();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("请确认两遍密码一致");
                }
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
