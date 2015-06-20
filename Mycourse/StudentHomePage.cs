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

namespace Mycourse
{
    public partial class StudentHomePage : Form
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }
        public Student stu;
        private void StudentHomePage_Load(object sender, EventArgs e)
        {
            lbstuname.Text = stu.StuName;
            lbstuno.Text = stu.StuNo;
            lbstugender.Text = stu.Gender;
            lbclass.Text = stu.StuClass;
            lbmajority.Text = stu.StuMajority;
        }


        private void StudentHomePage_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
         PassWordChange pwdchange=new PassWordChange();
         pwdchange.stu = this.stu;
         pwdchange.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
         CourseSelect courselect=new CourseSelect();
         courselect.stu = this.stu;
         courselect.parent = this;
         courselect.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DisplaySchedulue displayschedulue = new DisplaySchedulue();
            displayschedulue.parent = this;
            displayschedulue.Show();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 导出学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (!Directory.Exists(@"d:\Course/" + stu.StuNo))
                {
                    Directory.CreateDirectory(@"d:\Course/" + stu.StuNo);
                }
                FileStream fread = new FileStream(@"d:\Course/" + stu.StuNo + "/Information.txt", FileMode.Create);
                StreamWriter sw=new StreamWriter(fread);
                sw.WriteLine("学生姓名："+stu.StuName);
                sw.WriteLine("学号： "+stu.StuNo);
                sw.WriteLine("性别： "+stu.Gender);
                sw.WriteLine("学生班级"+stu.StuClass);
                sw.WriteLine("专业"+stu.StuMajority);
                sw.Close();
                fread.Close();
                MessageBox.Show("导出成功");
            }
        }    
    }
}
