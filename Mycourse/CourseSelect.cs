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
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mycourse
{
    public partial class CourseSelect : Form
    {
        public Student stu;
        public StudentHomePage parent;
        public CourseSelect()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void CourseSelect_Load(object sender, EventArgs e)
        {
            displayallcourse();
            ridselected();
            txtsubno.Enabled = false;
        }

        public void displayallcourse()
        {
            dgvcourse.AutoGenerateColumns = false;
            SqlConnection con = new SqlConnection("server=.;database=mycourse;integrated security=true");
            con.Open();
            string sql = "select * from test";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader reder = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reder);
            dgvcourse.DataSource = dt;
            reder.Close();
            con.Close();
        }

         public void ridselected()
        {
            for (int i = 0; i < dgvcourse.Rows.Count-1; i++)
            {
                foreach (Course C in stu.Sche.Crs)
                {
                    if (dgvcourse.Rows[i].Cells[1].Value.ToString() == C.CourseNo)
                    {
                        dgvcourse.Rows[i].ReadOnly = true;
                        dgvcourse.Rows[i].Cells[0].Value = false;
                        dgvcourse.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                     }
                    
                }
            }
        }

        private void dgvcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayallcourse();
            ridselected();
        }

        private void txtcourseno_TextChanged(object sender, EventArgs e)
        {
            if (txtcourseno.Text == "")
                txtsubno.Enabled = false;
            else
                txtsubno.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcourseno.Text == "")
            {
                MessageBox.Show("请输入课程号");
                return;
            }
            else
            {
                string sql;
                if (txtsubno.Text == "")
                    sql = "select * from test where CourseNo='" + txtcourseno.Text + "'";
                else
                    sql = "select * from test where CourseNo='" + txtcourseno.Text + "' and SubNo='"+SubNo+"'";
                SqlConnection con = new SqlConnection("server=.;database=mycourse;integrated security=true");
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);
                SqlDataReader reder = cm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reder);
                dgvcourse.DataSource = dt;
                reder.Close();
                con.Close();
                ridselected();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            save();
            MessageBox.Show("保存成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            List<Course> tempList=new List<Course>();
            for (int i = 0; i < dgvcourse.Rows.Count - 1;i++ )
            {
 
                if (Convert.ToBoolean(dgvcourse.Rows[i].Cells[0].Value) == true)
                {
                    Course C = new Course();
                    C.getcourse(dgvcourse.Rows[i].Cells[1].Value.ToString(), dgvcourse.Rows[i].Cells[2].Value.ToString());
                    foreach (Course Cr in tempList)
                    {
                        if (Cr.CourseNo == C.CourseNo)
                        {
                            MessageBox.Show("不能选择相同的课程");
                            return;
                        }
                    }
                    tempList.Add(C);
                }
            }
      
            if (tempList.Count == 0)
            {
                MessageBox.Show("请选择课程");
                return;
            }
            if (!stu.Sche.check(tempList))
            {
                MessageBox.Show("课程冲突");
                return;
            }
            DialogResult result = MessageBox.Show("确认选课", " 您确定要选这些课程么", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;
            stu.Sche.addCourse(tempList);
            ridselected();
            MessageBox.Show("选课成功");
            parent.stu = stu;
        }



        private void button7_Click(object sender, EventArgs e)
        {
            save();
            DisplaySelectedCourse displayer = new DisplaySelectedCourse();
            displayer.parent = this;
            displayer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvcourse.Rows.Count - 1; i++)
            {
                    if (dgvcourse.Rows[i].ReadOnly ==false)
                    {
                        dgvcourse.Rows[i].Cells[0].Value =true;
                    }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvcourse.Rows.Count - 1; i++)
            {
                    dgvcourse.Rows[i].Cells[0].Value = false;
            }
        }

        private void contextMenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void dgvcourse_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvcourse.ClearSelection();
                dgvcourse.Rows[e.RowIndex].Selected = true;
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (contextMenuStrip1.Items[0].Selected == true)
            {
                Course C = new Course();
                C.getcourse(dgvcourse.SelectedRows[0].Cells[1].Value.ToString(), dgvcourse.SelectedRows[0].Cells[2].Value.ToString());
                {
                    Detail detail = new Detail();
                    detail.C = C;
                    detail.Show();
                }
            }
            if (contextMenuStrip1.Items[1].Selected == true)
            {
                if (dgvcourse.SelectedRows[0].ReadOnly == false)
                    dgvcourse.SelectedRows[0].Cells[0].Value = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select * from test where Cclass LIKE '%" + stu.StuClass + "%'";
            SqlConnection con = new SqlConnection("server=.;database=mycourse;integrated security=true");
            con.Open();
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader reder = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reder);
            reder.Close();
            string majority;
            if (stu.StuMajority == "软测")
                majority = "软件开发";
            else
                majority = stu.StuMajority;
            string sql2 = "select * from test where Cclass LIKE '%" + majority + "%'";
            SqlCommand cm2 = new SqlCommand(sql2, con);
            SqlDataReader reder2 = cm2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(reder2);
            reder2.Close();
            con.Close();
            foreach (DataRow dr in dt2.Rows)
            dt.Rows.Add(dr.ItemArray);
            dgvcourse.DataSource = dt;

            ridselected();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplaySchedulue ds = new DisplaySchedulue();
            ds.parent = this.parent;
            ds.Show();
        }

        public void save()
        {
            if (!Directory.Exists(stu.StuNo))
                Directory.CreateDirectory(@"d:\Course/" + stu.StuNo);
            stu.SerializeSche();
            foreach (Course C in stu.Sche.Crs)
            {
                List<Student> L;
                if (!File.Exists(@"d:\CourseList/" + C.CourseNo + "_" + C.SubNo + ".data"))
                {
                    L = new List<Student>();
                    L.Add(stu);
                    C.SerializeStu(L);
                }
                else
                {
                    bool flag = false;
                    L = C.DeSerializeStu();
                    foreach (Student S in L)
                    {
                        if (S.StuNo == stu.StuNo)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        L.Add(stu);
                        C.SerializeStu(L);
                    }
                }
            }
        }

        private void CourseSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
            this.Close();
        }
    }
}
