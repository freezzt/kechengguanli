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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "学生成绩查询"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    if (Form14.czstr == "cz1") textBox1.Text = Form14.xuh;
                    String 学号 = textBox1.Text;
                    SqlConnection myCon = new SqlConnection("Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True");
                    myCon.Open();
                    SqlCommand scj = new SqlCommand("select 课程,成绩 from sk where 学号='" + 学号 + "';", myCon);
                    SqlDataAdapter custda = new SqlDataAdapter();
                    custda.SelectCommand = scj;
                    DataSet custds = new DataSet();
                    custda.Fill(custds);
                    this.dataGridView1.DataSource = custds.Tables[0];
                    myCon.Close();
                }
                else
                {
                    MessageBox.Show("请输入学号");
                }
            }else
                MessageBox.Show("您没有权限执行此操作");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String[] k = new string[100];
            k = dataGridView1.CurrentCell.Value.ToString().Split();
            linkLabel1.Text = k[0];
            linkLabel1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "学生成绩录入"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(linkLabel1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {
                    String s学号 = textBox1.Text;
                    String s课程 = linkLabel1.Text;
                    int s成绩 = Convert.ToInt32(textBox2.Text);
                    SqlConnection myCon = new SqlConnection("Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True");
                    myCon.Open();
                    SqlCommand up = new SqlCommand();
                    up.Connection = myCon;
                    up.CommandText = "update sk set 成绩=" + s成绩 + " where 学号='" + s学号 + "' and 课程='" + s课程 + "';";
                    int i = up.ExecuteNonQuery();
                    if (i == 1) MessageBox.Show("成绩录入成功");
                    myCon.Close();
                }
                else
                {
                    MessageBox.Show("请完整输入信息");
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
        private void Form6_Load(object sender, EventArgs e)
        {
            if (Form14.czstr == "cz1") textBox1.Text = Form14.xuh;
            textBox1.Show();
        }
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}