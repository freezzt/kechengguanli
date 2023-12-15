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
namespace 课程设计窗体2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "学生信息录入"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
                {
                    String str1 = textBox1.Text;
                    String str2 = textBox3.Text;
                    String str3 = textBox4.Text;
                    SqlConnection mycon = new SqlConnection();
                    mycon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                    mycon.Open();
                    SqlCommand cr = new SqlCommand();
                    cr.Connection = mycon;
                    cr.CommandText = "insert into s(学号,姓名,专业) values('" + str1 + "','" + str2 + "','" + str3 + "');";
                    int i = cr.ExecuteNonQuery();
                    if (i == 1) MessageBox.Show("录入成功");
                    mycon.Close();
                    mycon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                    mycon.Open();
                    cr.CommandText = "insert into 教务处(账号,密码,编号) values('" + str1 + "','123456','cz1')";
                    cr.ExecuteNonQuery();
                    mycon.Close();
                }
                else
                {
                    MessageBox.Show("信息未填写完整");
                }
            }
            else
            {
                MessageBox.Show("您没有权限执行此操作");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 t = new Form3();
            t.Show();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox5.Text))
            {
                if (Form14.czstr == "cz1") textBox5.Text = Form14.xuh;
                String str = textBox5.Text;
                SqlConnection myCon = new SqlConnection("Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True");
                myCon.Open();
                SqlCommand t = new SqlCommand();
                t.Connection = myCon;
                t.CommandText = "select 课程" + " from s, k " + "where k.状态=1 and s.学号='" + str + "' and s.专业 = k.专业 and k.课程!=all(select sk.课程 from sk where sk.学号='" + str + "')";
                SqlDataAdapter cust = new SqlDataAdapter();
                cust.SelectCommand = t;
                DataSet custds = new DataSet();
                cust.Fill(custds);
                this.dataGridView1.DataSource = custds.Tables[0];
                SqlCommand u = new SqlCommand(); u.Connection = myCon;
                u.CommandText = "select 专业 from s where 学号='" + str + "';";
                SqlDataReader custdr = u.ExecuteReader();
                custdr.Read();
                String[] ustr = new string[100];
                ustr = custdr.GetString(custdr.GetOrdinal("专业")).Split();
                linkLabel1.Text = ustr[0];
                myCon.Close();
            }
            else
            {
                MessageBox.Show("请输入学号");
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Form14.czstr == "cz1") textBox5.Text = Form14.xuh;            
            textBox5.Show();
        }
        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "学生选课"))
            {
                if (!String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(linkLabel1.Text) && !String.IsNullOrEmpty(linkLabel2.Text))
                {
                    String s学号 = textBox5.Text;
                    String s专业 = linkLabel1.Text;
                    String s课程 = linkLabel2.Text;
                    SqlConnection mycon = new SqlConnection();
                    mycon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                    mycon.Open();
                    SqlCommand cr = new SqlCommand();
                    cr.Connection = mycon;
                    cr.CommandText = "insert into sk(学号,专业,课程) values('" + s学号 + "','" + s专业 + "','" + s课程 + "');";
                    int i = cr.ExecuteNonQuery();
                    if (i == 1) MessageBox.Show("选课成功");
                    mycon.Close();
                }
                else
                {
                    MessageBox.Show("请正确填写信息");
                }
            }
            else
            {
                MessageBox.Show("您没有权限执行此操作");
            }
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form14.czstr == "cz1") textBox5.Text = Form14.xuh;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String[] s = new string[100];
            s = dataGridView1.CurrentCell.Value.ToString().Split();
            linkLabel2.Text = s[0];linkLabel2.Show();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}