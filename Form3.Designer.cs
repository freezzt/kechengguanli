
namespace 课程设计窗体2
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生选课录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生选课查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程选修情况查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生课程表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程开设计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据安全管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生ToolStripMenuItem,
            this.课程ToolStripMenuItem,
            this.系统维护ToolStripMenuItem,
            this.打印报表ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生ToolStripMenuItem
            // 
            this.学生ToolStripMenuItem.Checked = true;
            this.学生ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.学生ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生选课录入ToolStripMenuItem,
            this.学生选课查询ToolStripMenuItem,
            this.学生成绩录入ToolStripMenuItem});
            this.学生ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.学生ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.学生ToolStripMenuItem.Name = "学生ToolStripMenuItem";
            this.学生ToolStripMenuItem.Size = new System.Drawing.Size(66, 31);
            this.学生ToolStripMenuItem.Text = "学生";
            // 
            // 学生选课录入ToolStripMenuItem
            // 
            this.学生选课录入ToolStripMenuItem.Name = "学生选课录入ToolStripMenuItem";
            this.学生选课录入ToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.学生选课录入ToolStripMenuItem.Text = "学生选课录入";
            this.学生选课录入ToolStripMenuItem.Click += new System.EventHandler(this.学生选课录入ToolStripMenuItem_Click);
            // 
            // 学生选课查询ToolStripMenuItem
            // 
            this.学生选课查询ToolStripMenuItem.Name = "学生选课查询ToolStripMenuItem";
            this.学生选课查询ToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.学生选课查询ToolStripMenuItem.Text = "学生选课查询";
            this.学生选课查询ToolStripMenuItem.Click += new System.EventHandler(this.学生选课查询ToolStripMenuItem_Click);
            // 
            // 学生成绩录入ToolStripMenuItem
            // 
            this.学生成绩录入ToolStripMenuItem.Name = "学生成绩录入ToolStripMenuItem";
            this.学生成绩录入ToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.学生成绩录入ToolStripMenuItem.Text = "学生成绩录入查询";
            this.学生成绩录入ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩录入ToolStripMenuItem_Click);
            // 
            // 课程ToolStripMenuItem
            // 
            this.课程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课程输入ToolStripMenuItem,
            this.课程选修情况查询ToolStripMenuItem,
            this.学生课程表ToolStripMenuItem,
            this.课程开设计划ToolStripMenuItem});
            this.课程ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.课程ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.课程ToolStripMenuItem.Name = "课程ToolStripMenuItem";
            this.课程ToolStripMenuItem.Size = new System.Drawing.Size(66, 31);
            this.课程ToolStripMenuItem.Text = "课程";
            // 
            // 课程输入ToolStripMenuItem
            // 
            this.课程输入ToolStripMenuItem.Name = "课程输入ToolStripMenuItem";
            this.课程输入ToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.课程输入ToolStripMenuItem.Text = "课程输入";
            this.课程输入ToolStripMenuItem.Click += new System.EventHandler(this.课程输入ToolStripMenuItem_Click);
            // 
            // 课程选修情况查询ToolStripMenuItem
            // 
            this.课程选修情况查询ToolStripMenuItem.Name = "课程选修情况查询ToolStripMenuItem";
            this.课程选修情况查询ToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.课程选修情况查询ToolStripMenuItem.Text = "课程选修情况查询";
            this.课程选修情况查询ToolStripMenuItem.Click += new System.EventHandler(this.课程选修情况查询ToolStripMenuItem_Click);
            // 
            // 学生课程表ToolStripMenuItem
            // 
            this.学生课程表ToolStripMenuItem.Name = "学生课程表ToolStripMenuItem";
            this.学生课程表ToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.学生课程表ToolStripMenuItem.Text = "学生课程表";
            this.学生课程表ToolStripMenuItem.Click += new System.EventHandler(this.学生课程表ToolStripMenuItem_Click);
            // 
            // 课程开设计划ToolStripMenuItem
            // 
            this.课程开设计划ToolStripMenuItem.Name = "课程开设计划ToolStripMenuItem";
            this.课程开设计划ToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.课程开设计划ToolStripMenuItem.Text = "课程开设计划";
            this.课程开设计划ToolStripMenuItem.Click += new System.EventHandler(this.课程开设计划ToolStripMenuItem_Click);
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据安全管理ToolStripMenuItem,
            this.操作员管理ToolStripMenuItem,
            this.权限管理ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系统维护ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            // 
            // 数据安全管理ToolStripMenuItem
            // 
            this.数据安全管理ToolStripMenuItem.Name = "数据安全管理ToolStripMenuItem";
            this.数据安全管理ToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.数据安全管理ToolStripMenuItem.Text = "数据安全管理";
            this.数据安全管理ToolStripMenuItem.Click += new System.EventHandler(this.数据安全管理ToolStripMenuItem_Click);
            // 
            // 操作员管理ToolStripMenuItem
            // 
            this.操作员管理ToolStripMenuItem.Name = "操作员管理ToolStripMenuItem";
            this.操作员管理ToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.操作员管理ToolStripMenuItem.Text = "操作员管理";
            this.操作员管理ToolStripMenuItem.Click += new System.EventHandler(this.操作员管理ToolStripMenuItem_Click);
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            this.权限管理ToolStripMenuItem.Click += new System.EventHandler(this.权限管理ToolStripMenuItem_Click);
            // 
            // 打印报表ToolStripMenuItem
            // 
            this.打印报表ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.打印报表ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.打印报表ToolStripMenuItem.Name = "打印报表ToolStripMenuItem";
            this.打印报表ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.打印报表ToolStripMenuItem.Text = "打印报表";
            this.打印报表ToolStripMenuItem.Click += new System.EventHandler(this.打印报表ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出系统ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(365, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 381);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据安全管理";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "数据库恢复";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "数据库备份";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(191, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::课程设计窗体2.Properties.Resources.f6de184de1f109750ed5d316c3bbd324;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生选课录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生选课查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程输入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程选修情况查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生课程表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程开设计划ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据安全管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印报表ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}