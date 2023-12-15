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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog t = new FolderBrowserDialog();
            t.SelectedPath = "D:" + "\\" + "我的数据库" + "\\" + "数据库备份" + "\\" + "课程设计数据库备份";
            t.Description = "请选择文件夹路径";
            if (t.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = t.SelectedPath;
            }
            /*OpenFileDialog t1 = new OpenFileDialog();
            if(t1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = t1.FileName;
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                String str1 = textBox1.Text;
                String str2 = textBox2.Text;
                //MessageBox.Show("\\");
                String str3 = str1 + "\\";
                Directory.CreateDirectory(str1 + "\\" + str2);
                String str4 = str3 + str2 + "\\" + str2 + ".bak";
                String str5 = str3 + str2 + "\\" + str2 + "log.bak";
                FileStream k = File.Create(str4);
                k.Close();
                FileStream klog = File.Create(str5);
                klog.Close();
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                myCon.Open();
                SqlCommand s1 = new SqlCommand();
                s1.Connection = myCon;
                s1.CommandText = "backup database xsxk to disk='" + str4 + "';";
                SqlCommand s2 = new SqlCommand();
                s2.Connection = myCon;
                s2.CommandText = "backup log xsxk to disk='" + str5 + "';";
                try
                {                    
                    s1.ExecuteNonQuery();
                    s2.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("备份失败");
                }
                finally
                {
                    myCon.Close();
                }
                MessageBox.Show("备份成功");
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("请选择存储地址");
                }
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("请输入文件名");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog t = new FolderBrowserDialog();
            /*folderBrowserDialog1.SelectedPath = "D:" + "\\" + "我的数据库" + "\\" + "数据库备份" + "\\" + "课程设计数据库备份";
            folderBrowserDialog1.Description = "请选择文件夹路径";           
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = folderBrowserDialog1.SelectedPath;
            }*/
            String str = "D:" + "\\" + "我的数据库" + "\\" + "数据库备份" + "\\" + "课程设计数据库备份";
            //String s = Directory.GetCurrentDirectory();
            //MessageBox.Show(s);            
            String[] s = Directory.GetDirectories(str);            
            /*string[] filenames = Directory.GetFiles(str, "*.*", SearchOption.AllDirectories);//获取目录文件名称集合
            foreach (string filename in filenames)
            {
                s[i] = filename;
                comboBox1.Items.Add(s[i]);
            }  */
            foreach(string t in s)
            {
                String[] st = t.Split('\\');int i = st.Length;
                comboBox1.Items.Add(st[i - 1]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                String str = "D:" + "\\" + "我的数据库" + "\\" + "数据库备份" + "\\" + "课程设计数据库备份" + "\\" + comboBox1.Text;
                String[] s = str.Split('\\');
                int t = s.Length - 1;
                String str1 = s[t];
                //MessageBox.Show(comboBox1.Text);           
                String st = str + "\\" + str1 + ".bak";
                String stlog = str + "\\" + str1 + "log.bak";
                Directory.Delete(str, true);
                Directory.CreateDirectory(str);
                FileStream k = File.Create(st);
                k.Close();
                FileStream klog = File.Create(stlog); klog.Close();
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
                myCon.Open();
                SqlCommand s1 = new SqlCommand();
                s1.Connection = myCon;
                s1.CommandText = "backup database xsxk to disk='" + st + "';";
                SqlCommand s2 = new SqlCommand();
                s2.Connection = myCon;
                s2.CommandText = "backup log xsxk to disk='" + stlog + "';";
                try
                {
                    s1.ExecuteNonQuery();
                    s2.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("备份失败");
                }
                finally
                {
                    myCon.Close();
                }
                MessageBox.Show("备份成功");
            }
            else
            {
                MessageBox.Show("请选择文件夹");
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox1.Text = "D:" + "\\" + "我的数据库" + "\\" + "数据库备份" + "\\" + "课程设计数据库备份";
        }
    }
}
