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
    public partial class 房间信息 : Form
    {
        private 功能选择 last;

        /**获取Oracle 12c数据库连接字符串（位于项目App.config文件中）*/
        protected string connStr = ConfigurationManager.ConnectionStrings["xscj.Properties.Settings.ConnectionString"].ConnectionString;

        public 房间信息()
        {
            InitializeComponent();
        }

        private void 房间信息_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fJMlist.FJ”中。您可以根据需要移动或删除它。
            this.fJTableAdapter.Fill(this.fJMlist.FJ);

        }

        private void inhome_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);          //创建Oracle连接
            string FJinsertsql;

            FJinsertsql = "insert into FJ values(:Fjh, :Jg, :Type, '空',:lryj)";
            
            OracleCommand cmd = new OracleCommand(FJinsertsql, conn);           //新建操作数据库的命令对象  
            /*为命令添加参数*/
            cmd.Parameters.Add(":Fjh", OracleDbType.Char, 5).Value = lrfjh.Text.Trim();	        //房间号
            cmd.Parameters.Add(":Jg", OracleDbType.Decimal, 20).Value = lrjg.Text.Trim();           //价格

            if (fjtype1.Checked)
                cmd.Parameters.Add(":Type", OracleDbType.Char, 10).Value = fjtype1.Text.Trim();
            else if(fjtype2.Checked)
                cmd.Parameters.Add(":Type", OracleDbType.Char, 10).Value = fjtype2.Text.Trim();
            else if (fjtype3.Checked)
                cmd.Parameters.Add(":Type", OracleDbType.Char, 10).Value = fjtype3.Text.Trim();
            else if (fjtype4.Checked)
                cmd.Parameters.Add(":Type", OracleDbType.Char, 10).Value = fjtype4.Text.Trim();
            else 
                cmd.Parameters.Add(":Type", OracleDbType.Char, 10).Value = fjtype5.Text.Trim();
            cmd.Parameters.Add(":lryj", OracleDbType.Decimal, 20).Value = lryj.Text.Trim();           //押金


            try
            {
                conn.Open();                					            //打开数据库连接
                cmd.ExecuteNonQuery();
                回显.Text = "房间已录入。（若不继续录入请重新打开程序）";
            }
            catch
            {
                回显.Text = "房间录入失败，请检查输入信息！";
            }
            finally
            {
                conn.Close();                              	                //关闭数据库连接
            }
            lrfjh.Text = "";
            lrjg.Text = "";
            fjtype1.TabStop = true;
        }


        private void gkcx_Click_1(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);	        //创建Oracle连接
            string gkStrSelect = "select FJH, JG, TYPE, RZQK, YJ from FJ where FJH ='" + 房间号.Text.Trim() + "'";


            /**查询房间信息*/
            conn.Open();							                    //打开数据库连接
            OracleCommand myCommand = new OracleCommand(gkStrSelect, conn);
            //创建 DataReader 对象以读取顾客信息
            OracleDataReader reader = myCommand.ExecuteReader();
            if (reader.Read())							                //读取数据不为空
            {
                /*查询到的学生信息赋值给界面上的各表单控件显示*/
                jg.Text = reader["JG"].ToString();			        //J价格
                lx.Text = reader["TYPE"].ToString();                  //种类
                rzqk.Text = reader["RZQK"].ToString();                  //入住情况
                yj.Text = reader["YJ"].ToString();
                回显1.Text = "房间查询成功！";
            }

            else
            {
                回显1.Text = "房间查询失败！";
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            last = new 功能选择();
            this.Hide();
            last.ShowDialog();
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            last = new 功能选择();
            this.Hide();
            last.ShowDialog();
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);          //创建Oracle连接
            string fjdeletesql = "Delete From FJ where FJH =:fjm ";	            //设置删除的SQL语句



            OracleCommand cmd0 = new OracleCommand(fjdeletesql, conn);	        //新建操作数据库的命令对象

            cmd0.Parameters.Add(":fjm", OracleDbType.Char, 20).Value = 房间号.Text.Trim();
            //添加参数
            try
            {
                conn.Open();								                //打开数据库连接
                int a = cmd0.ExecuteNonQuery();
                if (a == 1 )								                    //返回值为1表示操作成功
                {
                    回显1.Text = "成功删除！";
                }
                else
                {
                    回显1.Text = "房间不存在！";
                }
            }
            catch
            {
                回显1.Text = "删除失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();                                	            //关闭数据库连接
            }
        }
    }
}
