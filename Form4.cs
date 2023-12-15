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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“xsxkDataSet.k”中。您可以根据需要移动或删除它。
            //this.kTableAdapter.Fill(this.xsxkDataSet.k);
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            int j = dataGridView1.CurrentCell.ColumnIndex;
            if (j == 0)
            {
                String[] t1 = new string[100];
                t1 = dataGridView1.CurrentCell.Value.ToString().Split();
                linkLabel1.Text = t1[0];
                linkLabel1.Show();
                String[] t2 = new string[100];
                t2 = dataGridView1[1, i].Value.ToString().Split();
                linkLabel2.Text = t2[0];
                linkLabel2.Show();
            }
            if (j == 1)
            {
                String[] t1 = new string[100];
                t1 = dataGridView1.CurrentCell.Value.ToString().Split();
                linkLabel2.Text = t1[0];
                linkLabel2.Show();
                String[] t2 = new string[100];
                t2 = dataGridView1[0, i].Value.ToString().Split();
                linkLabel1.Text = t2[0];
                linkLabel1.Show();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "未开设课程查询"))
            {
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                myCon.Open();
                SqlCommand st = new SqlCommand("select 课程,专业 from k where k.状态='0';", myCon);
                SqlDataAdapter custda = new SqlDataAdapter();
                custda.SelectCommand = st;
                DataSet custds = new DataSet();
                custda.Fill(custds, "k");
                this.dataGridView1.DataSource = custds.Tables[0];
                myCon.Close();
            }else
            {
                MessageBox.Show("您没有权限执行此操作");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "课程开设"))
            {
                if (!String.IsNullOrEmpty(linkLabel2.Text) && !String.IsNullOrEmpty(linkLabel1.Text))
                {
                    SqlConnection myCon = new SqlConnection();
                    myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                    myCon.Open();
                    SqlCommand sd = new SqlCommand();
                    sd.Connection = myCon;
                    sd.CommandText = "update k set 状态='1' where 专业='" + linkLabel2.Text + "' and 课程='" + linkLabel1.Text + "';";
                    int i = sd.ExecuteNonQuery();
                    if (i == 1) MessageBox.Show("课程开设成功");
                    myCon.Close();
                }
                else
                {
                    MessageBox.Show("请选择完整");
                }
            }else
            MessageBox.Show("您没有权限执行此操作");
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 t = new Form3();
            t.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
