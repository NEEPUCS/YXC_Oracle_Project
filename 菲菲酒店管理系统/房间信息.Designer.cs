namespace 菲菲酒店管理系统
{
    partial class 房间信息
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(房间信息));
            this.房间号 = new System.Windows.Forms.ComboBox();
            this.fJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fJMlist = new 菲菲酒店管理系统.FJMlist();
            this.fJTableAdapter = new 菲菲酒店管理系统.FJMlistTableAdapters.FJTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.房间查询 = new System.Windows.Forms.TabPage();
            this.房间删除 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.回显1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yj = new System.Windows.Forms.TextBox();
            this.rzqk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jg = new System.Windows.Forms.TextBox();
            this.gkcx = new System.Windows.Forms.Button();
            this.lrfjh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lrjg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fjtype1 = new System.Windows.Forms.RadioButton();
            this.fjtype2 = new System.Windows.Forms.RadioButton();
            this.fjtype3 = new System.Windows.Forms.RadioButton();
            this.fjtype4 = new System.Windows.Forms.RadioButton();
            this.fjtype5 = new System.Windows.Forms.RadioButton();
            this.inhome = new System.Windows.Forms.Button();
            this.回显 = new System.Windows.Forms.Label();
            this.lryj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.房间录入 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.fJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJMlist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.房间查询.SuspendLayout();
            this.房间录入.SuspendLayout();
            this.SuspendLayout();
            // 
            // 房间号
            // 
            this.房间号.DataSource = this.fJBindingSource;
            this.房间号.DisplayMember = "FJH";
            this.房间号.DropDownHeight = 90;
            this.房间号.FormattingEnabled = true;
            this.房间号.IntegralHeight = false;
            this.房间号.Location = new System.Drawing.Point(154, 26);
            this.房间号.MaxDropDownItems = 5;
            this.房间号.Name = "房间号";
            this.房间号.Size = new System.Drawing.Size(121, 20);
            this.房间号.TabIndex = 0;
            this.房间号.ValueMember = "FJH";
            // 
            // fJBindingSource
            // 
            this.fJBindingSource.DataMember = "FJ";
            this.fJBindingSource.DataSource = this.fJMlist;
            // 
            // fJMlist
            // 
            this.fJMlist.DataSetName = "FJMlist";
            this.fJMlist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fJTableAdapter
            // 
            this.fJTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "房间号 :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.房间查询);
            this.tabControl1.Controls.Add(this.房间录入);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 452);
            this.tabControl1.TabIndex = 16;
            // 
            // 房间查询
            // 
            this.房间查询.BackColor = System.Drawing.Color.SkyBlue;
            this.房间查询.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("房间查询.BackgroundImage")));
            this.房间查询.Controls.Add(this.房间删除);
            this.房间查询.Controls.Add(this.button1);
            this.房间查询.Controls.Add(this.回显1);
            this.房间查询.Controls.Add(this.label9);
            this.房间查询.Controls.Add(this.yj);
            this.房间查询.Controls.Add(this.rzqk);
            this.房间查询.Controls.Add(this.label7);
            this.房间查询.Controls.Add(this.label5);
            this.房间查询.Controls.Add(this.lx);
            this.房间查询.Controls.Add(this.label6);
            this.房间查询.Controls.Add(this.jg);
            this.房间查询.Controls.Add(this.gkcx);
            this.房间查询.Controls.Add(this.房间号);
            this.房间查询.Controls.Add(this.label1);
            this.房间查询.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.房间查询.Location = new System.Drawing.Point(4, 22);
            this.房间查询.Name = "房间查询";
            this.房间查询.Padding = new System.Windows.Forms.Padding(3);
            this.房间查询.Size = new System.Drawing.Size(792, 426);
            this.房间查询.TabIndex = 0;
            this.房间查询.Text = "房间查询";
            // 
            // 房间删除
            // 
            this.房间删除.BackColor = System.Drawing.SystemColors.Info;
            this.房间删除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.房间删除.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.房间删除.FlatAppearance.BorderSize = 2;
            this.房间删除.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.房间删除.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.房间删除.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.房间删除.Location = new System.Drawing.Point(183, 302);
            this.房间删除.Name = "房间删除";
            this.房间删除.Size = new System.Drawing.Size(111, 39);
            this.房间删除.TabIndex = 36;
            this.房间删除.Text = "删除";
            this.房间删除.UseVisualStyleBackColor = false;
            this.房间删除.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(0, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 回显1
            // 
            this.回显1.AutoSize = true;
            this.回显1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.回显1.Location = new System.Drawing.Point(335, 386);
            this.回显1.Name = "回显1";
            this.回显1.Size = new System.Drawing.Size(0, 12);
            this.回显1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(54, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "押   金：";
            // 
            // yj
            // 
            this.yj.Location = new System.Drawing.Point(154, 232);
            this.yj.Name = "yj";
            this.yj.Size = new System.Drawing.Size(140, 21);
            this.yj.TabIndex = 32;
            // 
            // rzqk
            // 
            this.rzqk.Location = new System.Drawing.Point(154, 179);
            this.rzqk.Name = "rzqk";
            this.rzqk.Size = new System.Drawing.Size(140, 21);
            this.rzqk.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(54, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "入住情况：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(54, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "类   型：";
            // 
            // lx
            // 
            this.lx.Location = new System.Drawing.Point(154, 129);
            this.lx.Name = "lx";
            this.lx.Size = new System.Drawing.Size(140, 21);
            this.lx.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(54, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "价   格：";
            // 
            // jg
            // 
            this.jg.Location = new System.Drawing.Point(154, 78);
            this.jg.Name = "jg";
            this.jg.Size = new System.Drawing.Size(140, 21);
            this.jg.TabIndex = 25;
            // 
            // gkcx
            // 
            this.gkcx.BackColor = System.Drawing.SystemColors.Info;
            this.gkcx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gkcx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gkcx.FlatAppearance.BorderSize = 2;
            this.gkcx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gkcx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gkcx.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gkcx.Location = new System.Drawing.Point(48, 302);
            this.gkcx.Name = "gkcx";
            this.gkcx.Size = new System.Drawing.Size(111, 39);
            this.gkcx.TabIndex = 20;
            this.gkcx.Text = "查询";
            this.gkcx.UseVisualStyleBackColor = false;
            this.gkcx.Click += new System.EventHandler(this.gkcx_Click_1);
            // 
            // lrfjh
            // 
            this.lrfjh.Location = new System.Drawing.Point(165, 21);
            this.lrfjh.Name = "lrfjh";
            this.lrfjh.Size = new System.Drawing.Size(140, 21);
            this.lrfjh.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(65, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "房间号：";
            // 
            // lrjg
            // 
            this.lrjg.Location = new System.Drawing.Point(165, 71);
            this.lrjg.Name = "lrjg";
            this.lrjg.Size = new System.Drawing.Size(140, 21);
            this.lrjg.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(65, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "价   格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(65, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "类   型：";
            // 
            // fjtype1
            // 
            this.fjtype1.AutoSize = true;
            this.fjtype1.BackColor = System.Drawing.Color.Transparent;
            this.fjtype1.Checked = true;
            this.fjtype1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fjtype1.Location = new System.Drawing.Point(165, 124);
            this.fjtype1.Name = "fjtype1";
            this.fjtype1.Size = new System.Drawing.Size(70, 18);
            this.fjtype1.TabIndex = 20;
            this.fjtype1.TabStop = true;
            this.fjtype1.Text = "单人间";
            this.fjtype1.UseVisualStyleBackColor = false;
            // 
            // fjtype2
            // 
            this.fjtype2.AutoSize = true;
            this.fjtype2.BackColor = System.Drawing.Color.Transparent;
            this.fjtype2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold);
            this.fjtype2.Location = new System.Drawing.Point(165, 195);
            this.fjtype2.Name = "fjtype2";
            this.fjtype2.Size = new System.Drawing.Size(70, 18);
            this.fjtype2.TabIndex = 21;
            this.fjtype2.Text = "标准间";
            this.fjtype2.UseVisualStyleBackColor = false;
            // 
            // fjtype3
            // 
            this.fjtype3.AutoSize = true;
            this.fjtype3.BackColor = System.Drawing.Color.Transparent;
            this.fjtype3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold);
            this.fjtype3.Location = new System.Drawing.Point(165, 228);
            this.fjtype3.Name = "fjtype3";
            this.fjtype3.Size = new System.Drawing.Size(70, 18);
            this.fjtype3.TabIndex = 22;
            this.fjtype3.Text = "大床房";
            this.fjtype3.UseVisualStyleBackColor = false;
            // 
            // fjtype4
            // 
            this.fjtype4.AutoSize = true;
            this.fjtype4.BackColor = System.Drawing.Color.Transparent;
            this.fjtype4.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold);
            this.fjtype4.Location = new System.Drawing.Point(165, 159);
            this.fjtype4.Name = "fjtype4";
            this.fjtype4.Size = new System.Drawing.Size(70, 18);
            this.fjtype4.TabIndex = 23;
            this.fjtype4.Text = "家庭房";
            this.fjtype4.UseVisualStyleBackColor = false;
            // 
            // fjtype5
            // 
            this.fjtype5.AutoSize = true;
            this.fjtype5.BackColor = System.Drawing.Color.Transparent;
            this.fjtype5.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold);
            this.fjtype5.Location = new System.Drawing.Point(165, 262);
            this.fjtype5.Name = "fjtype5";
            this.fjtype5.Size = new System.Drawing.Size(85, 18);
            this.fjtype5.TabIndex = 24;
            this.fjtype5.Text = "总统套房";
            this.fjtype5.UseVisualStyleBackColor = false;
            // 
            // inhome
            // 
            this.inhome.BackColor = System.Drawing.SystemColors.Info;
            this.inhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inhome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inhome.FlatAppearance.BorderSize = 2;
            this.inhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inhome.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inhome.Location = new System.Drawing.Point(139, 356);
            this.inhome.Name = "inhome";
            this.inhome.Size = new System.Drawing.Size(111, 39);
            this.inhome.TabIndex = 25;
            this.inhome.Text = "录入";
            this.inhome.UseVisualStyleBackColor = false;
            this.inhome.Click += new System.EventHandler(this.inhome_Click);
            // 
            // 回显
            // 
            this.回显.AutoSize = true;
            this.回显.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.回显.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.回显.Location = new System.Drawing.Point(323, 368);
            this.回显.Name = "回显";
            this.回显.Size = new System.Drawing.Size(0, 16);
            this.回显.TabIndex = 26;
            // 
            // lryj
            // 
            this.lryj.Location = new System.Drawing.Point(165, 312);
            this.lryj.Name = "lryj";
            this.lryj.Size = new System.Drawing.Size(140, 21);
            this.lryj.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(65, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "押   金：";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(0, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 24);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 房间录入
            // 
            this.房间录入.BackColor = System.Drawing.Color.SkyBlue;
            this.房间录入.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("房间录入.BackgroundImage")));
            this.房间录入.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.房间录入.Controls.Add(this.button2);
            this.房间录入.Controls.Add(this.label8);
            this.房间录入.Controls.Add(this.lryj);
            this.房间录入.Controls.Add(this.回显);
            this.房间录入.Controls.Add(this.inhome);
            this.房间录入.Controls.Add(this.fjtype5);
            this.房间录入.Controls.Add(this.fjtype4);
            this.房间录入.Controls.Add(this.fjtype3);
            this.房间录入.Controls.Add(this.fjtype2);
            this.房间录入.Controls.Add(this.fjtype1);
            this.房间录入.Controls.Add(this.label4);
            this.房间录入.Controls.Add(this.label3);
            this.房间录入.Controls.Add(this.lrjg);
            this.房间录入.Controls.Add(this.label2);
            this.房间录入.Controls.Add(this.lrfjh);
            this.房间录入.Location = new System.Drawing.Point(4, 22);
            this.房间录入.Name = "房间录入";
            this.房间录入.Padding = new System.Windows.Forms.Padding(3);
            this.房间录入.Size = new System.Drawing.Size(792, 426);
            this.房间录入.TabIndex = 1;
            this.房间录入.Text = "房间录入";
            // 
            // 房间信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "房间信息";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.房间信息_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJMlist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.房间查询.ResumeLayout(false);
            this.房间查询.PerformLayout();
            this.房间录入.ResumeLayout(false);
            this.房间录入.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox 房间号;
        private FJMlist fJMlist;
        private System.Windows.Forms.BindingSource fJBindingSource;
        private FJMlistTableAdapters.FJTableAdapter fJTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 房间查询;
        private System.Windows.Forms.Button gkcx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox jg;
        private System.Windows.Forms.TextBox rzqk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yj;
        private System.Windows.Forms.Label 回显1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button 房间删除;
        private System.Windows.Forms.TabPage 房间录入;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lryj;
        private System.Windows.Forms.Label 回显;
        private System.Windows.Forms.Button inhome;
        private System.Windows.Forms.RadioButton fjtype5;
        private System.Windows.Forms.RadioButton fjtype4;
        private System.Windows.Forms.RadioButton fjtype3;
        private System.Windows.Forms.RadioButton fjtype2;
        private System.Windows.Forms.RadioButton fjtype1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lrjg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lrfjh;
    }
}