using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycourse
{
    public partial class Detail : Form
    {
        public Course C;
        public Detail()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Detail_Load(object sender, EventArgs e)
        {
            lbaddress.Text = C.address;
            lbcourname.Text = C.CourseName;
            lbcourseno.Text = C.CourseNo;
            lbcredit.Text = C.CourseCredit.ToString();
            lbsubno.Text = C.SubNo;
            lbteacher.Text = C.Teacher;
            lbtimes.Text = C.ctime.times.ToString();
            lbtype.Text = C.Type;
            lbweek.Text = C.ctime.weekbegin.ToString() + "-" + C.ctime.weekend.ToString() + "周";
            if (C.ctime.schooldays[0] != 0)
                day1.Text = C.ctime.schooldays[0].ToString();
            else
                day1.Text = "";
            if (C.ctime.schooldays[1] != 0)
                day2.Text = C.ctime.schooldays[1].ToString();
            else
                day2.Text = "";
            if (C.ctime.schooldays[2] != 0)
                day3.Text = C.ctime.schooldays[2].ToString();
            else
                day3.Text = "";
            if (C.ctime.schooldays[3] != 0)
                day4.Text = C.ctime.schooldays[3].ToString();
            else
                day4.Text = "";
            if (C.ctime.schooldays[4] != 0)
                day5.Text = C.ctime.schooldays[4].ToString();
            else
                day5.Text = "";
            if (C.ctime.schooldays[5] != 0)
                day6.Text = C.ctime.schooldays[5].ToString();
            else
                day6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
