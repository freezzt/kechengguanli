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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True;";
            myCon.Open();
            SqlCommand select1 = new SqlCommand("select 账号 from 教务处 where 编号='cz';", myCon);
            SqlDataAdapter custda = new SqlDataAdapter();
            custda.SelectCommand = select1;
            DataSet custds = new DataSet();
            custda.Fill(custds);
            dataGridView1.DataSource = custds.Tables[0];
            myCon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String[] s = dataGridView1.CurrentCell.Value.ToString().Split();
            textBox3.Text = s[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String strz = textBox1.Text;
            String strm = textBox2.Text;
            if (!String.IsNullOrEmpty(strz) && !String.IsNullOrEmpty(strm))
            {
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True;";
                myCon.Open();
                SqlCommand sele = new SqlCommand();
                sele.Connection = myCon;
                sele.CommandText = "insert into 教务处(账号,密码,编号) values('" + strz + "','" + strm + "','cz');";
                int i = sele.ExecuteNonQuery();
                if (i == 1) MessageBox.Show("添加成功");
                //MessageBox.Show(strz);
                myCon.Close();
            }
            else
            {
                if (String.IsNullOrEmpty(strz))
                {
                    MessageBox.Show("请输入账号");
                }
                if (String.IsNullOrEmpty(strm))
                {
                    MessageBox.Show("请输入密码");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String str = textBox3.Text;
            if(!String.IsNullOrEmpty(str))
            {
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True;";
                myCon.Open();
                SqlCommand s1 = new SqlCommand();
                s1.Connection = myCon;
                s1.CommandText = "delete from 教务处 where 账号='" + str + "'";
                s1.ExecuteNonQuery();
                myCon.Close();
            }
            else
            {
                MessageBox.Show("请输入账号");
            }
        }
    }
}
