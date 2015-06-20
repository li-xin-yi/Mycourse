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
    public partial class DisplaySelectedCourse : Form
    {
        public CourseSelect parent;
        public DisplaySelectedCourse()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (contextMenuStrip1.Items[0].Selected == true)
            {
                Course C = new Course();
                C.getcourse(dgvcourse.SelectedRows[0].Cells[0].Value.ToString(), dgvcourse.SelectedRows[0].Cells[1].Value.ToString());
                {
                    Detail detail = new Detail();
                    detail.C = C;
                    detail.Show();
                }
            }
            if (contextMenuStrip1.Items[1].Selected == true)
            {
                Course C = new Course();
                C.getcourse(dgvcourse.SelectedRows[0].Cells[0].Value.ToString(), dgvcourse.SelectedRows[0].Cells[1].Value.ToString());
                dgvcourse.ClearSelection();
                dgvcourse.DataSource = null;
                parent.stu.Sche.SubCourse(C);
                C.removestudent(parent.stu.StuNo);
                dgvcourse.DataSource = parent.stu.Sche.Crs;
                MessageBox.Show("删除成功");
                lbcount.Text = parent.stu.Sche.Crs.Count.ToString();
                lbcredit.Text = parent.stu.Sche.totalcredit.ToString();
                parent.ridselected();
            }
        }

        private void DisplaySelectedCourse_Load(object sender, EventArgs e)
        {
            dgvcourse.AutoGenerateColumns = false;
            dgvcourse.DataSource = parent.stu.Sche.Crs;
            lbcount.Text = parent.stu.Sche.Crs.Count.ToString();
            lbcredit.Text = parent.stu.Sche.totalcredit.ToString();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
        }

        private void DisplaySelectedCourse_MouseClick(object sender, MouseEventArgs e)
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

        private void dgvcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
