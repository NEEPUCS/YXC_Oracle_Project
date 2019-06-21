using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 菲菲酒店管理系统
{
    public partial class 功能选择 : Form
    {
        private 顾客入住 rz;
        private 房间信息 fj;
        private 历史信息 ls;
        private 修改密码 mm;


        public 功能选择()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void inhome_Click(object sender, EventArgs e)
        {
            rz = new 顾客入住();
            this.Hide();
            rz.ShowDialog();
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fj = new 房间信息();
            this.Hide();
            fj.ShowDialog();
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ls = new 历史信息();
            this.Hide();
            ls.ShowDialog();
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mm = new 修改密码();
            this.Hide();
            mm.ShowDialog();
            Application.ExitThread();
        }
    }
}
