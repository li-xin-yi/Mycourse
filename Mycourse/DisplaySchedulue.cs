using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop;
using Excel=Microsoft.Office.Interop.Excel;

namespace Mycourse
{
    public partial class DisplaySchedulue : Form
    {
        public StudentHomePage parent;
        int index;
        public DisplaySchedulue()
        {
            InitializeComponent();
        }

        private void DisplaySchedulue_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                dgvschedule.Rows.Add();
                dgvschedule.Rows[i].Cells[0].Value = (i + 1);
            }
            cbcoursename.Checked = true;
            cbcoursename.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;
            for(int i=1;i<13;i++)
                for(int j=1;j<=6;j++)
                {
                   if(parent.stu.Sche.statetable[j-1,i,index])
                   foreach(Course C in parent.stu.Sche.Crs)
                   {
                      if(C.ctime.transtable()[j-1,i,index])
                      {
                          dgvschedule.Rows[i-1].Cells[j].Value = C.CourseName;
                          break;
                      }

                   }
                   else{
                       dgvschedule.Rows[i-1].Cells[j].Value = "";
                   }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("请选择周数");
                return;
            }
            Excel.Application exapp = getexcel(index);
            exapp.Visible = true;
                
        }

        public Excel.Application getexcel(int index)
       {
        Excel.Application exapp = new Excel.Application();
            if (exapp == null)
            {
                return null;
            }
            exapp.Visible = false;
            Excel.Workbook book = exapp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Sheets sheets = book.Worksheets;
            Excel.Worksheet sheet = (Excel.Worksheet)sheets.get_Item(1);
            sheet.Columns.ColumnWidth = 20;
            sheet.Rows.RowHeight = 20;
            sheet.Columns[1].ColumnWidth = 5;
            sheet.Rows[1].RowHeight = 10;
            for (int i = 1; i < 13; i++)
            {
                sheet.Cells[i + 1, 1] = i;
                for (int j = 1; j <= 6; j++)
                {
                    sheet.Cells[1, j + 1] = j;
                    if (parent.stu.Sche.statetable[j - 1, i, index])
                        foreach (Course C in parent.stu.Sche.Crs)
                        {
                            if (C.ctime.transtable()[j - 1, i, index])
                            {
                                string s = C.CourseName;
                                int height = 20;
                                if (cbteacher.Checked == true)
                                {
                                    s += '\n' + C.Teacher;
                                    height += 20;
                                }
                                if (cbaddress.Checked == true)
                                {
                                    s += '\n' + C.address;
                                    height += 20;
                                }
                                sheet.Rows[i + 1].RowHeight = height;
                                sheet.Cells[i + 1, j + 1] = s;
                                break;
                            }

                        }
                    else
                    {
                        sheet.Cells[i + 1, j + 1] = "";
                    }
                }
            }
            return exapp;
    }

        private void button2_Click(object sender, EventArgs e)
        {
         for(int i=0;i<19;i++)
         {
             Excel.Application temp = getexcel(i);
             if(File.Exists(@"d:\Course/" + parent.stu.StuNo+ "/schedule"+(i+1)+".xlsx"))
                 File.Delete(@"d:\Course/" + parent.stu.StuNo+ "/schedule"+(i+1)+".xlsx");
             if (!Directory.Exists(@"d:\Course/" + parent.stu.StuNo))
                 Directory.CreateDirectory(@"d:\Course/" + parent.stu.StuNo);
             temp.ActiveWorkbook.SaveAs(@"d:\Course/" + parent.stu.StuNo + "/schedule" + (i+1) + ".xlsx");
             temp.Quit();
         }
         MessageBox.Show("打印成功");
        }
    }
}
