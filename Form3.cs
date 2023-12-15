using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace 课程设计窗体2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 学生选课录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 t = new Form2();
            t.Show();
        }
        private void 课程开设计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 t = new Form4();
            t.Show();
        }
        private void 课程输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 t = new Form5();
            t.Show();
        }
        private void 学生成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 t = new Form6();
            t.Show();
        }
        private void 学生选课查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 t = new Form7();
            t.Show();
        }
        private void 课程选修情况查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form8 t = new Form8();
            t.Show();
        }
        private void 学生课程表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "学生课程表"))
            {
                this.Hide();
                Form9 t = new Form9();
                t.Show();
            }
            else
                MessageBox.Show("您没有权限执行此操作");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=master;Integrated Security=True";
            myCon.Open();
            SqlCommand st = new SqlCommand("select status From master.dbo.sysdatabases where name='xsxk';", myCon);
            SqlDataAdapter custda = new SqlDataAdapter();
            custda.SelectCommand = st;
            DataSet custds = new DataSet();
            custda.Fill(custds);
            int i = custds.Tables[0].Rows.Count;
            //MessageBox.Show(i.ToString());
            myCon.Close();
            if (i != 0)
            {
                MessageBox.Show("数据库已存在，无需恢复");
            }
            else
            {
                Form12 t = new Form12();
                t.Show();
            }           
        }
        private void button1_Click_2(object sender, EventArgs e)
        {            
                groupBox1.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        private void button6_Click(object sender, EventArgs e)
        {            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form11 t = new Form11();
            t.Show();            
        }
        private void Form3_Load(object sender, EventArgs e)
        {            
            groupBox1.Hide();            
        }
        private void 数据安全管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form14.czsql == "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True")
                groupBox1.Show();
            else
            {
                MessageBox.Show("您没有权限执行此操作");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void 操作员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form14.czstr == "cz")
            {
                Form13 t = new Form13();
                t.Show();
            }
            else
            {
                MessageBox.Show("您没有权限执行此操作");
            }
        }
        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form14.czstr == "cz")
            {
                Form15 t = new Form15();
                t.Show();
            }
            else
            {
                MessageBox.Show("您没有权限执行此操作");
            }
        }
        private void 打印报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "打印报表"))
            {
                this.Hide();
                Form10 t = new Form10();
                t.Show();
            }
            else
                MessageBox.Show("您没有权限执行此操作");
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}