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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "学生选修课程查询"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    if (Form14.czstr == "cz1") textBox1.Text = Form14.xuh;
                    String s学号 = textBox1.Text;
                    SqlConnection myCon = new SqlConnection("Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True");
                    myCon.Open();
                    SqlCommand t = new SqlCommand();
                    t.Connection = myCon;
                    t.CommandText = "select 课程,成绩 from sk where 学号='" + s学号 + "';";
                    SqlDataAdapter cust = new SqlDataAdapter();
                    cust.SelectCommand = t;
                    DataSet custds = new DataSet();
                    cust.Fill(custds);
                    this.dataGridView1.DataSource = custds.Tables[0];
                    SqlCommand u = new SqlCommand(); u.Connection = myCon;
                    u.CommandText = "select 专业 from s where 学号='" + s学号 + "';";
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
            else
                MessageBox.Show("您没有权限执行此操作");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 t = new Form3();
            t.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Form14.czstr == "cz1") textBox1.Text = Form14.xuh;
            textBox1.Show();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            if (Form14.czstr == "cz1") textBox1.Text = Form14.xuh;
            textBox1.Show();
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}