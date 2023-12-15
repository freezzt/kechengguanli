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
    public partial class Form14 : Form
    {
        public static String czsql;
        public static String xuh;
        public static String czstr;
        public Form14()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text)&&!String.IsNullOrEmpty(textBox2.Text))
            {
                String strz = textBox1.Text;String strm = textBox2.Text;
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                myCon.Open();
                SqlCommand se = new SqlCommand();
                se.Connection = myCon;
                se.CommandText = "select 编号 from 教务处 where 账号='" + strz + "' and 密码='" + strm + "';";
                SqlDataAdapter custda = new SqlDataAdapter();
                custda.SelectCommand = se;
                DataSet custds = new DataSet();
                custda.Fill(custds);
                int i = custds.Tables[0].Rows.Count;
                if(i==0)
                {
                    MessageBox.Show("账号或密码错误");
                }
                else if(i==1)
                {
                    String[] s = custds.Tables[0].Rows[0][0].ToString().Split();
                    czstr = s[0];
                    //MessageBox.Show(czstr);
                    if(czstr=="cz")
                    {
                        czsql = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                    }else if(czstr=="cz1")
                    {
                        czsql = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;User ID=cz1;Password=cz1";//"Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;" + ";User ID=" + czstr + ";Password=" + czstr;
                        xuh = textBox1.Text;
                    }
                    else if(czstr=="cz2")
                    {
                        czsql = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;User ID=cz2;Password=cz2";
                    }
                    this.Hide();                    
                    Form3 t = new Form3();
                    t.Show();
                }                
                myCon.Close();
            }
            else
            {
                MessageBox.Show("请正确填写内容");
            }
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 t = new Form1();
            t.Show();
        }
        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Application.Exit();
        }
    }
}