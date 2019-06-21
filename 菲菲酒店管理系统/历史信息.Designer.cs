namespace 菲菲酒店管理系统
{
    partial class 历史信息
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(历史信息));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.回显 = new System.Windows.Forms.Label();
            this.查询 = new System.Windows.Forms.Button();
            this.fjhview = new System.Windows.Forms.DataGridView();
            this.fjh = new System.Windows.Forms.ComboBox();
            this.fJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fJMlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fJMlist = new 菲菲酒店管理系统.FJMlist();
            this.label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.回显1 = new System.Windows.Forms.Label();
            this.xm = new System.Windows.Forms.TextBox();
            this.查询1 = new System.Windows.Forms.Button();
            this.gkView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.shijian = new System.Windows.Forms.DateTimePicker();
            this.回显2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.回显3 = new System.Windows.Forms.Label();
            this.allview = new System.Windows.Forms.DataGridView();
            this.allsearch = new System.Windows.Forms.Button();
            this.fJTableAdapter = new 菲菲酒店管理系统.FJMlistTableAdapters.FJTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fjhview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJMlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJMlist)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gkView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.回显);
            this.tabPage1.Controls.Add(this.查询);
            this.tabPage1.Controls.Add(this.fjhview);
            this.tabPage1.Controls.Add(this.fjh);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "按房间";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(762, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 24);
            this.button5.TabIndex = 36;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // 回显
            // 
            this.回显.AutoSize = true;
            this.回显.ForeColor = System.Drawing.Color.Firebrick;
            this.回显.Location = new System.Drawing.Point(385, 25);
            this.回显.Name = "回显";
            this.回显.Size = new System.Drawing.Size(0, 12);
            this.回显.TabIndex = 21;
            // 
            // 查询
            // 
            this.查询.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.查询.Location = new System.Drawing.Point(270, 16);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(75, 23);
            this.查询.TabIndex = 20;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = false;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // fjhview
            // 
            this.fjhview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fjhview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fjhview.Location = new System.Drawing.Point(21, 52);
            this.fjhview.Name = "fjhview";
            this.fjhview.RowTemplate.Height = 23;
            this.fjhview.Size = new System.Drawing.Size(750, 350);
            this.fjhview.TabIndex = 19;
            // 
            // fjh
            // 
            this.fjh.DataSource = this.fJBindingSource;
            this.fjh.DisplayMember = "FJH";
            this.fjh.FormattingEnabled = true;
            this.fjh.Location = new System.Drawing.Point(111, 17);
            this.fjh.Name = "fjh";
            this.fjh.Size = new System.Drawing.Size(121, 20);
            this.fjh.TabIndex = 18;
            this.fjh.ValueMember = "FJH";
            // 
            // fJBindingSource
            // 
            this.fJBindingSource.DataMember = "FJ";
            this.fJBindingSource.DataSource = this.fJMlistBindingSource;
            // 
            // fJMlistBindingSource
            // 
            this.fJMlistBindingSource.DataSource = this.fJMlist;
            this.fJMlistBindingSource.Position = 0;
            // 
            // fJMlist
            // 
            this.fJMlist.DataSetName = "FJMlist";
            this.fJMlist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(20, 16);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 21);
            this.label.TabIndex = 17;
            this.label.Text = "房间号：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.回显1);
            this.tabPage2.Controls.Add(this.xm);
            this.tabPage2.Controls.Add(this.查询1);
            this.tabPage2.Controls.Add(this.gkView);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按顾客";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(762, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 24);
            this.button4.TabIndex = 36;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 回显1
            // 
            this.回显1.AutoSize = true;
            this.回显1.ForeColor = System.Drawing.Color.Firebrick;
            this.回显1.Location = new System.Drawing.Point(385, 25);
            this.回显1.Name = "回显1";
            this.回显1.Size = new System.Drawing.Size(0, 12);
            this.回显1.TabIndex = 28;
            // 
            // xm
            // 
            this.xm.Location = new System.Drawing.Point(111, 17);
            this.xm.Name = "xm";
            this.xm.Size = new System.Drawing.Size(121, 21);
            this.xm.TabIndex = 27;
            // 
            // 查询1
            // 
            this.查询1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.查询1.Location = new System.Drawing.Point(270, 16);
            this.查询1.Name = "查询1";
            this.查询1.Size = new System.Drawing.Size(75, 23);
            this.查询1.TabIndex = 25;
            this.查询1.Text = "查询";
            this.查询1.UseVisualStyleBackColor = false;
            this.查询1.Click += new System.EventHandler(this.查询1_Click);
            // 
            // gkView
            // 
            this.gkView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gkView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gkView.Location = new System.Drawing.Point(21, 52);
            this.gkView.Name = "gkView";
            this.gkView.RowTemplate.Height = 23;
            this.gkView.Size = new System.Drawing.Size(750, 350);
            this.gkView.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "姓   名:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.shijian);
            this.tabPage3.Controls.Add(this.回显2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataView);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "按时间";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(762, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 24);
            this.button3.TabIndex = 36;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // shijian
            // 
            this.shijian.CustomFormat = "yyyy/MM/dd";
            this.shijian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.shijian.Location = new System.Drawing.Point(111, 17);
            this.shijian.Name = "shijian";
            this.shijian.Size = new System.Drawing.Size(135, 21);
            this.shijian.TabIndex = 34;
            this.shijian.Value = new System.DateTime(2019, 6, 20, 0, 0, 0, 0);
            // 
            // 回显2
            // 
            this.回显2.AutoSize = true;
            this.回显2.ForeColor = System.Drawing.Color.Firebrick;
            this.回显2.Location = new System.Drawing.Point(386, 21);
            this.回显2.Name = "回显2";
            this.回显2.Size = new System.Drawing.Size(0, 12);
            this.回显2.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(270, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(21, 52);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(750, 350);
            this.dataView.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "时   间:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.回显3);
            this.tabPage4.Controls.Add(this.allview);
            this.tabPage4.Controls.Add(this.allsearch);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "所有历史";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(361, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 37;
            this.button6.Text = "全部删除";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(755, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 24);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 回显3
            // 
            this.回显3.AutoSize = true;
            this.回显3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.回显3.Location = new System.Drawing.Point(523, 11);
            this.回显3.Name = "回显3";
            this.回显3.Size = new System.Drawing.Size(0, 12);
            this.回显3.TabIndex = 34;
            // 
            // allview
            // 
            this.allview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allview.Location = new System.Drawing.Point(8, 30);
            this.allview.Name = "allview";
            this.allview.RowTemplate.Height = 23;
            this.allview.Size = new System.Drawing.Size(776, 386);
            this.allview.TabIndex = 33;
            // 
            // allsearch
            // 
            this.allsearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.allsearch.Location = new System.Drawing.Point(261, 6);
            this.allsearch.Name = "allsearch";
            this.allsearch.Size = new System.Drawing.Size(75, 23);
            this.allsearch.TabIndex = 32;
            this.allsearch.Text = "查询";
            this.allsearch.UseVisualStyleBackColor = false;
            this.allsearch.Click += new System.EventHandler(this.allsearch_Click);
            // 
            // fJTableAdapter
            // 
            this.fJTableAdapter.ClearBeforeFill = true;
            // 
            // 历史信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "历史信息";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史信息";
            this.Load += new System.EventHandler(this.历史信息_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fjhview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJMlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fJMlist)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gkView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox fjh;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.BindingSource fJMlistBindingSource;
        private FJMlist fJMlist;
        private System.Windows.Forms.BindingSource fJBindingSource;
        private FJMlistTableAdapters.FJTableAdapter fJTableAdapter;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.DataGridView fjhview;
        private System.Windows.Forms.Label 回显;
        private System.Windows.Forms.Button 查询1;
        private System.Windows.Forms.DataGridView gkView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xm;
        private System.Windows.Forms.Label 回显1;
        private System.Windows.Forms.DateTimePicker shijian;
        private System.Windows.Forms.Label 回显2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView allview;
        private System.Windows.Forms.Button allsearch;
        private System.Windows.Forms.Label 回显3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}