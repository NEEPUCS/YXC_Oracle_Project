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
    public partial class 顾客入住 : Form
    {
        private 功能选择 last;

        /**获取Oracle 12c数据库连接字符串（位于项目App.config文件中）*/
        protected string connStr = ConfigurationManager.ConnectionStrings["xscj.Properties.Settings.ConnectionString"].ConnectionString;
        protected string filename = "";  //照片文件名

        public 顾客入住()
        {
            InitializeComponent();
        }

        private void 顾客入住_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“fJMlist1.FJ”中。您可以根据需要移动或删除它。
            this.fJTableAdapter1.Fill(this.fJMlist1.FJ);

        }

        private void 浏览_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfDlg = new OpenFileDialog();
            opfDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            opfDlg.Filter = "JPEG图片|*.jpg|GIF图片|*.gif|全部文件|*.*";
            if (opfDlg.ShowDialog(this) == DialogResult.OK)
            {
                filename = opfDlg.FileName;
                照片.Image = Image.FromFile(filename);
            }
        }

        private void inhome_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);          //创建Oracle连接
            string GKinsertsql;
            string RUinsertsql;
            string LSinsertsql;
          //  string FJupdatesql;
        
            if (filename != "")             	                                //如果选择了照片
            {
                GKinsertsql = "insert into GK values(:Name, :IDcard, :Gsex, :Born, :Phone, :Photo)";
                //设置SQL语句（带照片插入）
            }
            else
            {
                GKinsertsql = "insert into GK values(:Name, :IDcard, :Gsex, :Born, :Phone, null)";
                //设置SQL语句（不带照片插入）
            }
            OracleCommand cmd = new OracleCommand(GKinsertsql, conn);           //新建操作数据库的命令对象  
            /*为命令添加参数*/
            cmd.Parameters.Add(":Name", OracleDbType.Char, 10).Value = 姓名.Text.Trim();	        //姓名
            cmd.Parameters.Add(":IDcard", OracleDbType.Char, 20).Value = 身份证.Text.Trim();	        //身份证  
      
            if (男.Checked)                                                                   
                cmd.Parameters.Add(":GSex", OracleDbType.Char, 2).Value = 男.Text.Trim();
            else
                cmd.Parameters.Add(":GSex", OracleDbType.Char, 2).Value = 女.Text.Trim();            //性别

            cmd.Parameters.Add(":Born", OracleDbType.Date).Value = gkCssj.Value;		            //出生年月
            cmd.Parameters.Add(":Phone", OracleDbType.Varchar2, 20).Value = 手机号.Text.Trim();	        //电话

            if (filename != "")                                             //如果选择了照片则加入参数:Photo
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                MemoryStream ms = new MemoryStream();
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                cmd.Parameters.Add(":Photo", OracleDbType.Blob);	        //这里选择Blob类型
                cmd.Parameters[":Photo"].Value = data;	                    //给:Photo参数赋值
                filename = "";
            }

            RUinsertsql = "insert into RU(XM, FJH, YF, YJ, BZ, RZSJ) values(:Name, :FJ_ID, :Moneydata, :rzyj, :Bz, :rzsj)";
            OracleCommand ruz = new OracleCommand(RUinsertsql, conn);           //新建操作数据库的命令对象  
            ruz.Parameters.Add(":Name", OracleDbType.Char, 10).Value = 姓名.Text.Trim();	        //姓名
            ruz.Parameters.Add(":FJ_ID", OracleDbType.Char, 5).Value = lrfjh.Text.Trim();	        //房间号

            if (Allmoney.Checked)
                ruz.Parameters.Add(":Moneydata", OracleDbType.Char, 6).Value = Allmoney.Text.Trim();
            else
                ruz.Parameters.Add(":Moneydata", OracleDbType.Char, 6).Value = Nomoney.Text.Trim();            //付费情况

            ruz.Parameters.Add(":rzyj", OracleDbType.Decimal, 20).Value = lryj.Text.Trim();	        //押金
            ruz.Parameters.Add(":Bz", OracleDbType.Varchar2, 1000).Value = lrbz.Text.Trim();	        //备注
            ruz.Parameters.Add(":rzsj", OracleDbType.Varchar2, 50).Value = DateTime.Now.ToString("yyyy/MM/dd").Replace(" ", "");	        //房时间

            string gkStrSelect = "select XM, TFSJ from LS ";
            //设置查询SQL语句
            try
            {
                conn.Open();                                                //打开数据库连接
                
               
                LSinsertsql = "insert into ls values( :xm, :xb, :fjh, :rzsj, '未退房')";
                OracleCommand ruzls = new OracleCommand(LSinsertsql, conn);
                ruzls.Parameters.Add(":xm", OracleDbType.Char, 10).Value = 姓名.Text.Trim();          //姓名
                if (男.Checked)
                    ruzls.Parameters.Add(":xb", OracleDbType.Char, 2).Value = 男.Text.Trim();
                else
                    ruzls.Parameters.Add(":xb", OracleDbType.Char, 2).Value = 女.Text.Trim();            //性别
                ruzls.Parameters.Add(":fjh", OracleDbType.Char, 5).Value = lrfjh.Text.Trim();           //房间号
                ruzls.Parameters.Add(":rzsj", OracleDbType.Varchar2, 50).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");           //时间
  
                cmd.ExecuteNonQuery();
                ruz.ExecuteNonQuery();
                ruzls.ExecuteNonQuery();//执行SQL语句
                回显.Text = "入住信息已记录。";
            }
            catch
            {
                回显.Text = "入住信息记录失败，请检查输入信息！";
            }
            finally
            {
                conn.Close();                                               //关闭数据库连接
            }
            
            

           
            
            
            照片.Image = null;
            姓名.Text = "";
            身份证.Text = "";
            手机号.Text = "";
            gkCssj.Text = "";
            男.TabStop = true;
            lrbz.Text = "";

            

        }

        private void gkcx_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);	        //创建Oracle连接
            string gkStrSelect = "select XM, SFZ, XB, TO_CHAR(CSSJ, 'YYYY-MM-DD') AS CSSJ, DH, ZP from GK where XM ='" + 姓名.Text.Trim() + "'";
                                                                            //设置查询SQL语句
            string ruStrSelect = "select FJH, YF, YJ, BZ from RU where XM = '" + 姓名.Text.Trim() + "'";

            try
            {
                /**查询顾客信息*/
                conn.Open();							                    //打开数据库连接
                OracleCommand myCommand1 = new OracleCommand(gkStrSelect, conn);
                //创建 DataReader 对象以读取顾客信息
                OracleDataReader reader = myCommand1.ExecuteReader();
                OracleCommand myCommand2 = new OracleCommand(ruStrSelect, conn);
                //创建 DataReader 对象以读取顾客信息
                OracleDataReader rureader = myCommand2.ExecuteReader();
                if ( reader.Read() && rureader.Read() )							                //读取数据不为空
                {
                    /*查询到的顾客信息赋值给界面上的各表单控件显示*/
                    姓名.Text = reader["XM"].ToString();			        //姓名
                    手机号.Text = reader["DH"].ToString();                  //电话
                    string sex = reader["XB"].ToString();                   //性别
                    if (sex == "男")
                        男.Checked = true;
                    else
                        女.Checked = true;
                    string birthday = reader["CSSJ"].ToString();            //出生年月
                    gkCssj.Value = DateTime.ParseExact(birthday, "yyyy-MM-dd", null);
                    身份证.Text = reader["SFZ"].ToString();                 //身份证
                    lrfjh.Text = rureader["FJH"].ToString();                 //房间号
                    string fk = rureader["YF"].ToString();
                    if (fk == "已付款")
                       Allmoney.Checked = true;
                   else
                       Nomoney.Checked = true;
                    lryj.Text = rureader["YJ"].ToString();                 //押金 
                    lrbz.Text = rureader["BZ"].ToString();                  //备注
                    //读取照片
                    if (照片.Image != null)
                       照片.Image.Dispose();
                   string a = reader["ZP"].ToString();
                   if (a == "")
                   {
                       回显.Text = "查找成功！该顾客未录入照片。";
                   }
                   else
                    { 
                    byte[] data = (byte[])reader["ZP"];                   
                    MemoryStream ms = new MemoryStream(data);                 
                    照片.Image = Image.FromStream(ms);                     //照片                  
                    ms.Close();
                    回显.Text = "查找成功！";
                   }
                }

                else
                {
                   回显.Text = "该顾客不存在！";
                    姓名.Text = "";
                    男.Checked = true;
                    gkCssj.Value = DateTime.Now;
                   照片.Image = null;
                    身份证.Text = "";
                    return;
                }
            }
            catch
            {
                回显.Text = "查找失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();
            }
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);          //创建Oracle连接
            string lsupdatesql = "update LS set tfsj=:rzs where XM =:Name ";
            string RUinsertsql = "Delete From RU where XM =:Name ";	            //设置删除的SQL语句
            string GKinsertsql = "Delete From GK where XM =:Name ";	            //设置删除的SQL语句
            

            OracleCommand cmd0 = new OracleCommand(lsupdatesql, conn);	        //新建操作数据库的命令对象
            OracleCommand cmd1 = new OracleCommand(RUinsertsql, conn);	        //新建操作数据库的命令对象
            OracleCommand cmd2 = new OracleCommand(GKinsertsql, conn);	        //新建操作数据库的命令对象
            cmd0.Parameters.Add(":rzs", OracleDbType.Varchar2, 50).Value = DateTime.Now.ToString();	        //退房时间
            cmd0.Parameters.Add(":Name", OracleDbType.Char, 20).Value = 姓名.Text.Trim();
            cmd1.Parameters.Add(":Name", OracleDbType.Char, 20).Value = 姓名.Text.Trim();
            cmd2.Parameters.Add(":Name", OracleDbType.Char, 20).Value = 姓名.Text.Trim();
            //添加参数
            try
            {
                conn.Open();								                //打开数据库连接
                int c = cmd0.ExecuteNonQuery();
                int a = cmd1.ExecuteNonQuery();				                //执行SQL语句
                int b = cmd2.ExecuteNonQuery();
                if (c==1 && a == 1 && b == 1)								                    //返回值为1表示操作成功
                {
                    回显.Text = "成功退房！";
                }
                else
                {
                    回显.Text = "顾客不存在！";
                }
            }
            catch
            {
                回显.Text = "退房失败，请检查操作权限！";
            }
            finally
            {
                conn.Close();                                	            //关闭数据库连接
            }
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
            string GKUpdatesql;
            string RUUpdatesql;


            if (filename != "")             	                                //如果选择了照片
            {
                GKUpdatesql = "update GK set SFZ = :newsfz, XB = :newxb, CSSJ = :newcssj, DH = :newdh, ZP = :newzp where XM ='" + 姓名.Text.Trim() + "'";
                //设置SQL语句（带照片插入）
            }
            else
            {
                GKUpdatesql = "update GK set SFZ = :newsfz, XB = :newxb, CSSJ = :newcssj, DH = :newdh, ZP = null where XM = '" + 姓名.Text.Trim() + "'";
                //设置SQL语句（不带照片插入）
            }

            OracleCommand cmd = new OracleCommand(GKUpdatesql, conn);           //新建操作数据库的命令对象  
            /*为命令添加参数*/
            cmd.Parameters.Add(":newsfz", OracleDbType.Char, 20).Value = 身份证.Text.Trim();           //身份证  

            if (男.Checked)
                cmd.Parameters.Add(":newxb", OracleDbType.Char, 2).Value = 男.Text.Trim();
            else
                cmd.Parameters.Add(":newxb", OracleDbType.Char, 2).Value = 女.Text.Trim();            //性别

            cmd.Parameters.Add(":newcssj", OracleDbType.Date).Value = gkCssj.Value;		            //出生年月
            cmd.Parameters.Add(":newdh", OracleDbType.Varchar2, 20).Value = 手机号.Text.Trim();	        //电话

            if (filename != "")                                             //如果选择了照片则加入参数:Photo
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                MemoryStream ms = new MemoryStream();
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                cmd.Parameters.Add(":newzp", OracleDbType.Blob);	        //这里选择Blob类型
                cmd.Parameters[":newzp"].Value = data;	                    //给:Photo参数赋值
                filename = "";
            }

            RUUpdatesql = "update RU set YF = :newyf, BZ = :newbz where XM = '" + 姓名.Text.Trim() + "'";
            OracleCommand ruz = new OracleCommand(RUUpdatesql, conn);           //新建操作数据库的命令对象  

            if (Allmoney.Checked)
                ruz.Parameters.Add(":newyf", OracleDbType.Char, 6).Value = Allmoney.Text.Trim();
            else
                ruz.Parameters.Add(":Mnewyf", OracleDbType.Char, 6).Value = Nomoney.Text.Trim();            //付费情况


            ruz.Parameters.Add(":newbz", OracleDbType.Varchar2, 1000).Value = lrbz.Text.Trim();	        //备注
            
            try
            {
                conn.Open();              
                cmd.ExecuteNonQuery();
                ruz.ExecuteNonQuery();
                回显.Text = "顾客信息已更新。";
            }
            catch
            {
                回显.Text = "顾客信息更新失败，请检查输入信息！";
            }
            finally
            {
                conn.Close();                                               //关闭数据库连接
            }

            照片.Image = null;
            姓名.Text = "";
            身份证.Text = "";
            手机号.Text = "";
            gkCssj.Text = "";
            男.TabStop = true;
            lrbz.Text = "";
        }
    }
}
