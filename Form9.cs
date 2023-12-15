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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            xskcb();
        }
        private void xskcb()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
            myCon.Open();
            SqlCommand cx = new SqlCommand("select 学号,专业,课程 from sk ", myCon);
            SqlDataAdapter custda = new SqlDataAdapter();
            custda.SelectCommand = cx;
            DataSet custds = new DataSet();
            custda.Fill(custds);
            this.dataGridView1.DataSource = custds.Tables[0];
            myCon.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 t = new Form3();
            t.Show();
        }
        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
