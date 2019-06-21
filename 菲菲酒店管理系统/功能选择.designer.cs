namespace 菲菲酒店管理系统
{
    partial class 功能选择
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(功能选择));
            this.label1 = new System.Windows.Forms.Label();
            this.inhome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(232, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择您接下来要进行的操作：";
            // 
            // inhome
            // 
            this.inhome.BackColor = System.Drawing.SystemColors.Info;
            this.inhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inhome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inhome.FlatAppearance.BorderSize = 2;
            this.inhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inhome.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inhome.Location = new System.Drawing.Point(403, 151);
            this.inhome.Name = "inhome";
            this.inhome.Size = new System.Drawing.Size(181, 50);
            this.inhome.TabIndex = 1;
            this.inhome.Text = "顾客入住";
            this.inhome.UseVisualStyleBackColor = false;
            this.inhome.Click += new System.EventHandler(this.inhome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(403, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "套房信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(403, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "历史信息";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(403, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "系统管理";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(539, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 功能选择
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::菲菲酒店管理系统.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 612);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inhome);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "功能选择";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inhome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}