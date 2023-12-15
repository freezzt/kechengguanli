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
    public partial class Form15 : Form
    {
        public static Boolean czpd(String x, String y)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
            myCon.Open();
            SqlCommand s = new SqlCommand("select zt from qx where bh='" + x + "' and qno='" + y + "';", myCon);
            SqlDataAdapter custda = new SqlDataAdapter();
            custda.SelectCommand = s;
            DataSet custds = new DataSet();
            custda.Fill(custds);
            bool t;
            try
            { t = Convert.ToBoolean(custds.Tables[0].Rows[0][0]); }
            catch
            {
                t = false;
            }
            if (x == "cz") { t = true; }
            myCon.Close();
            return t;
        }        
        public Form15()
        {
            InitializeComponent();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form15_Load(object sender, EventArgs e)
        {
            try
            {
                checkBox1.Checked = czpd("cz1", "学生选课");
                //MessageBox.Show(Convert.ToBoolean(custds.Tables[0].Rows[0][0]).ToString());
                checkBox1.Show();
                checkBox2.Checked = czpd("cz1", "学生信息录入");
                checkBox2.Show();
                checkBox3.Checked = czpd("cz1", "学生成绩查询");
                checkBox3.Show();
                checkBox4.Checked = czpd("cz1", "学生选修课程查询");
                checkBox4.Show();
                checkBox5.Checked = czpd("cz1", "学生成绩录入");
                checkBox5.Show();
                checkBox6.Checked = czpd("cz1", "学生课程表");
                checkBox6.Show();
                checkBox7.Checked = czpd("cz1", "未开设课程查询");
                checkBox7.Show();
                checkBox18.Checked = czpd("cz1", "打印报表");
                checkBox18.Show();
                checkBox8.Checked = czpd("cz2", "学生信息录入");
                checkBox8.Show();
                checkBox9.Checked = czpd("cz2", "学生选课");
                checkBox9.Show();
                checkBox10.Checked = czpd("cz2", "选修课程结果查询");
                checkBox10.Show();
                checkBox11.Checked = czpd("cz2", "学生成绩录入");
                checkBox11.Show();
                checkBox12.Checked = czpd("cz2", "未开设课程查询");
                checkBox12.Show();
                checkBox13.Checked = czpd("cz2", "课程开设");
                checkBox13.Show();
                checkBox14.Checked = czpd("cz2", "新课程录入");
                checkBox14.Show();
                checkBox15.Checked = czpd("cz2", "学生课程表");
                checkBox15.Show();
                checkBox16.Checked = czpd("cz2", "学生成绩查询");
                checkBox16.Show();
                checkBox17.Checked = czpd("cz2", "学生选修课程查询");
                checkBox17.Show();
                checkBox19.Checked = czpd("cz2", "打印报表");
                checkBox19.Show();
            }
            catch
            {
                MessageBox.Show("出现错误");
            }            
        }        
        public bool pd1(String x)
        {
            if(x=="true")
            {
                return true;
            }else
            {
                return false;
            }
        }
        public int pd2(CheckBox x)
        {
            if(x.Checked==true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                xg(checkBox1, "cz1", "学生选课");
                xg(checkBox2, "cz1", "学生信息录入");
                xg(checkBox3, "cz1", "学生成绩查询");
                xg(checkBox4, "cz1", "学生选修课程查询");
                xg(checkBox5, "cz1", "学生成绩录入");
                xg(checkBox6, "cz1", "学生课程表");
                xg(checkBox7, "cz1", "未开设课程查询");
                xg(checkBox18, "cz1", "打印报表");
                xg(checkBox8, "cz2", "学生信息录入");
                xg(checkBox9, "cz2", "学生选课");
                xg(checkBox10, "cz2", "选修课程结果查询");
                xg(checkBox11, "cz2", "学生成绩录入");
                xg(checkBox12, "cz2", "未开设课程查询");
                xg(checkBox13, "cz2", "课程开设");
                xg(checkBox14, "cz2", "新课程录入");
                xg(checkBox15, "cz2", "学生课程表");
                xg(checkBox16, "cz2", "学生成绩查询");
                xg(checkBox17, "cz2", "学生选修课程查询");
                xg(checkBox19, "cz2", "打印报表");
                MessageBox.Show("设置成功");
            }
            catch
            {
                MessageBox.Show("操作失败");
            }
        }
        public void xg(CheckBox x,String y,String z)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
            myCon.Open();
            String i = pd2(x).ToString();
            SqlCommand se = new SqlCommand("update qx set zt='" + i + "' where bh='" + y + "' and qno='" + z + "';");
            se.Connection = myCon;
            se.ExecuteNonQuery();
            myCon.Close();
        }
    }
}
