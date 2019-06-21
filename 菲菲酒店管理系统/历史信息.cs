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
    public partial class 历史信息 : Form
    {
        protected string connStr = ConfigurationManager.ConnectionStrings["xscj.Properties.Settings.ConnectionString"].ConnectionString;
        private 功能选择 last;
        public 历史信息()
        {
            InitializeComponent();
        }

        private void 历史信息_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fJMlist.FJ”中。您可以根据需要移动或删除它。
            this.fJTableAdapter.Fill(this.fJMlist.FJ);

        }

        private void 查询_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);	        //创建Oracle连接
            string fjStrView = "select FJH AS 房间号, XM AS 姓名, XB AS 性别, RZSJ AS 入住时间, TFSJ AS 退房时间 from FJH_VIEW";
            //查询视图的SQL语句

            try
            {
                conn.Open();							                    //打开数据库连接
                /**执行存储过程*/
                OracleCommand proCommand = new OracleCommand();             //创建SQL命令对象
                /*设置SQL命令各参数*/
                proCommand.Connection = conn;                               //所用的数据连接
                proCommand.CommandType = CommandType.StoredProcedure;	    //命令类型为“存储过程”
                proCommand.CommandText = "FJH_PROC";		                    //存储过程名
                OracleParameter OrclFj = proCommand.Parameters.Add("fjh", OracleDbType.Char, 5);
                //添加存储过程的参数
                OrclFj.Direction = ParameterDirection.Input;		        //参数类型为“输入参数”
                OrclFj.Value = fjh.Text.Trim();
                proCommand.ExecuteNonQuery();				                //执行命令，生成视图
                /**访问视图*/
                OracleDataAdapter mda = new OracleDataAdapter(fjStrView, conn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "FJH_VIEW");					                //视图数据先读取到数据集中
                fjhview.DataSource = ds.Tables["FJH_VIEW"].DefaultView;    //动态设置数据源
                回显.Text = "查询成功！";
            }
            catch
            {
                回显.Text = "查询失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();
            }
        }

        private void 查询1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);	        //创建Oracle连接
            string orclStr = "select XM AS 姓名, FJH AS 房间号, XB AS 性别, RZSJ AS 入住时间, TFSJ AS 退房时间 from ls where XM ='" + xm.Text.Trim() + "'";
            try
            {

                conn.Open();								                //打开数据库连接
                OracleDataAdapter mda = new OracleDataAdapter(orclStr, conn);
                DataSet dg = new DataSet();
                mda.Fill(dg, "GK");						                //查询的数据读取到数据集中
                gkView.DataSource = dg.Tables["GK"].DefaultView;
                回显1.Text = "查询成功！";

            }
            catch
            {
                回显1.Text = "查询失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);	        //创建Oracle连接
            string orclStr = "select XM AS 姓名, FJH AS 房间号, XB AS 性别, RZSJ AS 入住时间, TFSJ AS 退房时间 from ls where RZSJ like '" + shijian.Text.ToString() + "%'";
            try
            {

                conn.Open();								                //打开数据库连接
                OracleDataAdapter mda = new OracleDataAdapter(orclStr, conn);
                DataSet gk = new DataSet();
                mda.Fill(gk, "LS");						                //查询的数据读取到数据集中
                dataView.DataSource = gk.Tables["LS"].DefaultView;
                回显2.Text = "查询成功！";

            }
            catch
            {
                回显2.Text = "查询失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();
            }
        }

        private void allsearch_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);	        //创建Oracle连接
            string orclStr = "select XM AS 姓名, FJH AS 房间号, XB AS 性别, RZSJ AS 入住时间, TFSJ AS 退房时间 from ls";

            try
            {
                conn.Open();								                //打开数据库连接
                OracleDataAdapter mda = new OracleDataAdapter(orclStr, conn);
                DataSet al = new DataSet();
                mda.Fill(al, "all");						                //查询的数据读取到数据集中
                allview.DataSource = al.Tables["all"].DefaultView;
                回显3.Text = "查询成功！";

            }
            catch
            {
                回显3.Text = "查询失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            last = new 功能选择();
            this.Hide();
            last.ShowDialog();
            Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            last = new 功能选择();
            this.Hide();
            last.ShowDialog();
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);	        //创建Oracle连接
            string orclStr = "DELETE FROM LS";

            try
            {
                conn.Open();								                //打开数据库连接
                OracleCommand cmd0 = new OracleCommand(orclStr, conn);
                cmd0.ExecuteNonQuery();
                回显3.Text = "删除成功！";

            }
            catch
            {
                回显3.Text = "删除失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
