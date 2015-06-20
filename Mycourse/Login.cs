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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public StuHP StuMan=new StuHP();

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pwd = textBox2.Text;
            if(StuMan.Login(user)==false)
            {
                MessageBox.Show("无此用户");
             return;
            }
            if(StuMan.Login(user,pwd)==false)
            {
                MessageBox.Show("密码错误");
                return;
            }
            StudentHomePage studenthomepage = new StudentHomePage();
            studenthomepage.stu = StuMan.temp;
            studenthomepage.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        if(textBox1.Text=="Admin" && textBox2.Text=="Admin")
        {
            AdminHomePage ahp = new AdminHomePage();
            ahp.Show();
            this.Visible = false;
        }
        else
        {
            MessageBox.Show("密码错误");
            return;
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
