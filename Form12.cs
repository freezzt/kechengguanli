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
using System.Collections;
namespace 课程设计窗体2
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                String str = textBox1.Text;
                String[] s = str.Split('\\');
                int i = s.Length; String str1 = s[i - 1];
                String st = str + "\\" + str1 + ".bak";
                String stlog = str + "\\" + str1 + "log.bak";//MessageBox.Show(st);
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=master;Integrated Security=True";
                myCon.Open();
                SqlCommand se1 = new SqlCommand();
                se1.Connection = myCon;
                se1.CommandText = "select spid from sysprocesses,sysdatabases where sysprocesses.dbid=sysdatabases.dbid and sysdatabases.Name='xsxk';";
                List<short> list = new List<short>();
                try
                {
                    SqlDataReader k = se1.ExecuteReader();
                    while (k.Read())
                    {
                        list.Add(k.GetInt16(0));
                    }
                    k.Close();
                }
                catch
                {
                    MessageBox.Show("获取失败");
                }
                finally
                {
                    myCon.Close();
                }
                try
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        myCon.Open();
                        se1 = new SqlCommand(String.Format("kill {0}", list[j].ToString()), myCon);
                        se1.ExecuteNonQuery();
                        myCon.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("操作失败");
                }
                finally
                {
                    myCon.Close();
                }
                myCon.Open();
                se1 = new SqlCommand("restore database xsxk from disk='" + st + "' with replace");
                //SqlCommand se2 = new SqlCommand("restore log xsxk from disk='" + stlog + "' with recovery");
                //se1 = new SqlCommand("restore database xsxk from disk='D:"+"\\"+"我的数据库"+"\\"+"数据库备份"+"\\"+"课程设计数据库备份"+"\\"+"备份1"+"\\"+"备份1.bak' with replace;");
                try
                {
                    se1.Connection = myCon;
                    int p = se1.ExecuteNonQuery();
                    //se2.ExecuteNonQuery();
                    if (p == 1) MessageBox.Show("恢复成功");
                }
                catch
                {
                    MessageBox.Show("恢复失败");
                }
                finally
                {
                    myCon.Close();
                }
            }
            else
            {
                MessageBox.Show("请选择备份文件");
            }
        }
    }
}
