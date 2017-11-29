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
    public partial class LogorSign : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private DataSet ds;
        private string connstr = "server=localhost;Database=taidou;uid=root;pwd=root;charset=utf8";
        
        public LogorSign()
        {
           // Closed += FormCloseHandler;
            conn = new MySqlConnection(connstr);
            InitializeComponent();
            
        }

        private void LogorSign_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = userid.Text;
            string pwd = password.Text;
            MySqlDataReader reader = null;
            conn.Open();
            //bool failde = false;
            this.DialogResult = DialogResult.No;
            try
            {
                cmd = new MySqlCommand("select * from user",conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == id && reader[1].ToString() == pwd)
                    {
                       // MessageBox.Show(@"Login Success!", "", MessageBoxButtons.OK);
                        //failde = true;
                        this.DialogResult = DialogResult.OK;
                        Program.useridl = id;
                        //Form1 check=new Form1(id);
                        //check.Show();
                        this.Close();
                        break;
                    }
                }
                if (this.DialogResult==DialogResult.No)
                {
                    MessageBox.Show(@"Login Failed,Please check your Id and password");
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignIn sign=new SignIn();
            //Application.Run(new SignIn());
            sign.Show();
        }

        public void FormCloseHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
