using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.IO;

namespace 菲菲酒店管理系统
{
    public partial class 修改密码 : Form
    {
        /**获取Oracle 12c数据库连接字符串（位于项目App.config文件中）*/
        protected string connStr = ConfigurationManager.ConnectionStrings["xscj.Properties.Settings.ConnectionString"].ConnectionString;

        private 功能选择 gn;

        public 修改密码()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            string checksql = "update UP set username = :uname, passwd = :upasswd where FLAG = 'admin'";

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(checksql, conn);
                cmd.Parameters.Add(":uname", OracleDbType.Varchar2, 18).Value = luser.Text.Trim();	        //账号
                cmd.Parameters.Add(":upasswd", OracleDbType.Varchar2, 18).Value = lpasswd.Text.Trim();	        //密码
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("密码已修改");
            }
            catch
            {
                MessageBox.Show("密码修改失败！");
            }
            finally
            {
                conn.Close();                                               //关闭数据库连接
            }

            
            gn = new 功能选择();
            this.Hide();
            gn.ShowDialog();
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gn = new 功能选择();
            this.Hide();
            gn.ShowDialog();
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("确定重置所有数据吗？(此操作不可恢复。)", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OracleConnection conn = new OracleConnection(connStr);          //创建Oracle连接
                string orclStr0 = "DELETE FROM LS";
                string orclStr1 = "DELETE FROM RU";
                string orclStr2 = "DELETE FROM FJ";
                string orclStr3 = "DELETE FROM GK";


                try
                {
                    conn.Open();                                                //打开数据库连接
                    OracleCommand cmd0 = new OracleCommand(orclStr0, conn);
                    OracleCommand cmd1 = new OracleCommand(orclStr1, conn);
                    OracleCommand cmd2 = new OracleCommand(orclStr2, conn);
                    OracleCommand cmd3 = new OracleCommand(orclStr3, conn);
                    cmd0.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    回显.Text = "重置成功！";

                }
                catch
                {
                    回显.Text = "重置失败，请检查操作权限！";
                }
                finally
                {
                    conn.Close();
                }
            }
            else { return; }
         
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gn = new 功能选择();
            this.Hide();
            gn.ShowDialog();
            Application.ExitThread();
        }
    }
}
