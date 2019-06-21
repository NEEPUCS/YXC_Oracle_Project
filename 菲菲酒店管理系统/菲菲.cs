using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;


namespace 菲菲酒店管理系统
{
    public partial class 菲菲 : Form
    {

        private 功能选择 uchose;

        protected string connStr = ConfigurationManager.ConnectionStrings["xscj.Properties.Settings.ConnectionString"].ConnectionString;

        public int flag = 0;

        public 菲菲()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.BackgroundImage = Image.FromFile("..\\..\\Resources\\登录1.png");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = Image.FromFile("..\\..\\Resources\\登录.png");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.button1.BackgroundImage = Image.FromFile("..\\..\\Resources\\登录2.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 0;
            OracleConnection conn = new OracleConnection(connStr);
            string checksql = "select username, passwd From UP";
            
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(checksql, conn);          
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {                   
                    string user = reader["username"].ToString();
                    string passwd = reader["passwd"].ToString();
                    if (user.Trim() == luser.Text.ToString().Trim() && passwd.Trim() == lpasswd.Text.ToString().Trim())
                        { flag = 1; break; }
                    else
                        flag = 0;
                }
            }
            catch
            {
                label3.Text = "*账号或密码有误！请重新输入！";
            }
            finally
            {
                conn.Close();                                	            
            }
            if ( flag == 1 )
            {
                uchose = new 功能选择();
                this.Hide();
                uchose.ShowDialog();
                Application.ExitThread();
            }
           
           else
            {
                label3.Text = "*账号或密码有误！请重新输入！";
            }
        }

        private void lpasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                button1_Click(sender, e);
            }
        }

        private void luser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
