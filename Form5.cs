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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 t = new Form3();
            t.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "新课程录入"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {
                    String s课程 = textBox1.Text;
                    String s专业 = textBox2.Text;
                    SqlConnection mycon = new SqlConnection();
                    mycon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                    mycon.Open();
                    SqlCommand cr = new SqlCommand();
                    cr.Connection = mycon;
                    cr.CommandText = "insert into k(课程,专业) values('" + s课程 + "','" + s专业 + "');";
                    int i = cr.ExecuteNonQuery();
                    if (i == 1) MessageBox.Show("课程录入成功");
                    mycon.Close();
                }
                else
                {
                    MessageBox.Show("请完整输入信息");
                }
            }else
            MessageBox.Show("您没有权限执行此操作");
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}