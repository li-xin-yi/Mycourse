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

namespace Mycourse
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }
        public List<Student> L=new List<Student>();
        public Course C = new Course();

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtcourseno.Text=="")
            {
                MessageBox.Show("请输入课程号");
                return;
            }
            if(txtsubno.Text=="")
            {
                MessageBox.Show("请输入课序号");
                return;
            }

            string sql = "select * from test where CourseNo='" + txtcourseno.Text+ "' and SubNo='" +txtsubno.Text + "'";
            SqlConnection con = new SqlConnection("server=.;database=mycourse;integrated security=true");
            con.Open();
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader reder = cm.ExecuteReader();
            if(reder.FieldCount==0)
            {
             MessageBox.Show("未开设此课程");
             reder.Close();
             con.Close();
                return;
            }
            C.getcourse(txtcourseno.Text,txtsubno.Text);
            txtcoursename.Text = C.CourseName;
            List<Student> L=new List<Student>();
            if(File.Exists(@"d:\CourseList/" + txtcourseno.Text + "_" + txtsubno.Text + ".data"))
            {
                L = C.DeSerializeStu();
            }
            dgvstudent.AutoGenerateColumns=false;
            dgvstudent.DataSource=L;
        }

        private void AdminHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvstudent_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvstudent.ClearSelection();
                dgvstudent.Rows[e.RowIndex].Selected = true;
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string stuno = dgvstudent.SelectedRows[0].Cells[0].Value.ToString();
            dgvstudent.ClearSelection();
            dgvstudent.DataSource = null;
            L=C.removestudent(stuno);
            StuHP shp=new StuHP();
            shp.getstudent(stuno);
            Student S=new Student();
            S=shp.temp;
            S.Sche.SubCourse(C);
            S.SerializeSche();
            MessageBox.Show("删除成功");
            dgvstudent.DataSource = L;
        }

        
    }
}
