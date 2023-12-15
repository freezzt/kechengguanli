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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void InitData()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
            myCon.Open();
            SqlCommand select1 = new SqlCommand("select distinct 专业 from sk ;", myCon);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = select1;
            DataSet ds = new DataSet();
            da.Fill(ds);
            comboBox2.DisplayMember = "专业";
            comboBox2.DataSource = ds.Tables[0].DefaultView;
            myCon.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 t = new Form3();
            t.Show();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] s = new string[10];
            s = comboBox2.Text.Split();
            String str = s[0];
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
            myCon.Open();
            SqlCommand select1 = new SqlCommand("select distinct 课程 from k where 专业='" + str + "';", myCon);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = select1;
            DataSet ds = new DataSet();
            da.Fill(ds);
            comboBox1.DisplayMember = "课程";
            comboBox1.DataSource = ds.Tables[0].DefaultView;
            myCon.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Form15.czpd(Form14.czstr, "选修课程结果查询"))
            {
                listView1.Items.Clear();
                String[] s = new string[10];
                s = comboBox2.Text.Split();
                String s专业 = s[0];
                String[] s1 = new string[10];
                s1 = comboBox1.Text.Split();
                String s课程 = s1[0];
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                myCon.Open();
                SqlCommand sele = new SqlCommand("select 学号,专业,课程 from sk where 专业='" + s专业 + "'and 课程='" + s课程 + "';", myCon);
                SqlDataReader dr = sele.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    listView1.Items.Add(lv);
                }
                dr.Close();
                myCon.Close();
            }
            else
                MessageBox.Show("您没有权限执行此操作");
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}