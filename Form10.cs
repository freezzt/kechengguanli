using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Spire.Xls;
//using Microsoft.Office.Core;
//using Microsoft.Office.Interop.Excel;
using System.Reflection;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
namespace 课程设计窗体2
{
    public partial class Form10 : Form
    {
        //private System.ComponentModel.Container components;
        //private System.Windows.Forms.Button printButton;
        //private System.Drawing.Font printFont;
        //private StreamReader streamToPrint;
        public Form10()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 t = new Form3();
            t.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“xsxkDataSet1.sk”中。您可以根据需要移动或删除它。
            //this.skTableAdapter.Fill(this.xsxkDataSet1.sk);
            // TODO: 这行代码将数据加载到表“xsxkDataSet1.sk”中。您可以根据需要移动或删除它。
            //this.skTableAdapter.Fill(this.xsxkDataSet1.sk);
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "Data Source=LAPTOP-A9O4VA5E;Initial Catalog=xsxk;Integrated Security=True";
            myCon.Open();
            String f = "D:" + "\\" + "我的数据库" + "\\" + "课程设计数据库" + "\\" + "查询结果.xlsx";
            if(Form14.czstr=="cz1")
            {
                String str = Form14.xuh;
                SqlCommand se = new SqlCommand("select * from sk where 学号='" + str + "';", myCon);
                SqlDataAdapter custda = new SqlDataAdapter();
                custda.SelectCommand = se;
                DataSet custds = new DataSet();
                custda.Fill(custds);                
                //File.Create("D:" + "\\" + "我的数据库" + "\\" + "课程设计数据库" + "\\" + "查询结果.xlsx");
                System.Data.DataTable biao = custds.Tables[0];
                dataGridView1.DataSource = biao;
                DataSetToExcel(biao, f);                
            }
            else
            {
                SqlCommand se = new SqlCommand("select * from sk ;", myCon);
                SqlDataAdapter custda = new SqlDataAdapter();
                custda.SelectCommand = se;
                DataSet custds = new DataSet();
                custda.Fill(custds);                
                System.Data.DataTable biao = custds.Tables[0];
                dataGridView1.DataSource = biao;
                DataSetToExcel(biao, f);
            }
        }
        public void DataSetToExcel(System.Data.DataTable x, string SaveFile)
        {
            /*int i = x.Rows.Count;
            int j = x.Columns.Count;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = false;
            for(int u=0;u<j;u++)
            {
                excel.Cells[1, u + 1] = x.Columns[u].ColumnName;
            }
            for (int r = 0; r < i; r++)
            {
                for (int c = 0; c < j; c++)
                {
                    excel.Cells[r + 2, c + 1] = x.Rows[r][c].ToString();
                }
            }
            excel.DisplayAlerts = false;
            excel.AlertBeforeOverwriting = false;
            excel.Application.Workbooks.Add(true).Save();
            excel.Save(SaveFile);
            excel.Quit();
            excel = null;*/
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");
            try
            {
                IRow row1 = sheet.CreateRow(0);
                for (int i = 0; i < x.Columns.Count; i++)
                {
                    ICell cell = row1.CreateCell(i);
                    cell.SetCellValue(x.Columns[i].ColumnName);
                }
                for (int i = 0; i < x.Rows.Count; i++)
                {
                    IRow row2 = sheet.CreateRow(i + 1);
                    for (int j = 0; j < x.Columns.Count; j++)
                    {
                        ICell cell = row2.CreateCell(j);
                        cell.SetCellValue(x.Rows[i][j].ToString());
                    }
                }
                MemoryStream stream = new MemoryStream();
                workbook.Write(stream);
                var buf = stream.ToArray();
                using(FileStream fs=new FileStream(SaveFile,FileMode.Create,FileAccess.Write))
                {
                    fs.Write(buf, 0, buf.Length);
                    fs.Flush();
                    fs.Close();
                }
                /*if (MessageBox.Show("导出成功，是否立即打开？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(SaveFile);
                }*/
                //printPreviewControl1.Document = excelToPrint;                
                try
                {
                    Workbook workbook1 = new Workbook();
                    workbook1.LoadFromFile(SaveFile);
                    Worksheet sheet1 = workbook1.Worksheets[0];
                    sheet1.SaveToImage("D:\\我的数据库\\课程设计数据库\\查询结果.jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
                /*StreamReader wj = new StreamReader(SaveFile);
                Image r = Image.FromFile("D:\\我的数据库\\课程设计数据库\\查询结果.bmp");
                Image t = new Bitmap(r);r.Dispose();*/
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void select1ToolStripButton_Click(object sender, EventArgs e)
        {            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            /*float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;*/
            ev.Graphics.DrawImage(Image.FromFile("D:\\我的数据库\\课程设计数据库\\查询结果.jpg"),ev.Graphics.VisibleClipBounds);
            ev.HasMorePages = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = (Form)printPreviewDialog1;
            f.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom =0.65;
            printPreviewDialog1.ShowDialog();
        }
    }
}