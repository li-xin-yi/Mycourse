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
namespace Mycourse
{
    public partial class PassWordChange : Form
    {
        public PassWordChange()
        {
            InitializeComponent();
        }

        public Student stu;
        bool flag1=false;
        bool flag2 = false;
        bool flag3 = false;

        private void PassWordChange_Load(object sender, EventArgs e)
        {
            lbwarning0.Text = "请输入原密码";
            lbwarning1.Text = "";
            lbwarning2.Text = "";
            btnsave.Enabled = false;
        }

        private void txtformerpwd_TextChanged(object sender, EventArgs e)
        {
            if (txtformerpwd.Text == stu.StuPassWord)
            {
                lbwarning0.Text = "";
                flag1 = true;
            }
            else
            {
                lbwarning0.Text = "请输入正确的密码";
                flag1 = false;
            }
            if (flag1 && flag2 && flag3)
                btnsave.Enabled = true;
            else
                btnsave.Enabled = false;
        }

        private void txtnewpwd_TextChanged(object sender, EventArgs e)
        {
            if (txtnewpwd.Text.Length < 6)
            {
                lbwarning1.Text = "密码不能少于6个字符";
                flag2 = false;
            }
            else if (txtnewpwd.Text == stu.StuPassWord)
            {
                lbwarning1.Text = "不能与原密码相同";
                flag2 = false;
            }
            else
            {
                lbwarning1.Text = "";
                flag2 = true;
            }
            if (flag1 && flag2 && flag3)
                btnsave.Enabled = true;
            else
                btnsave.Enabled = false;
        }

        private void txtconfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtconfirm.Text == txtnewpwd.Text)
            {
                lbwarning2.Text = "";
                flag3 = true;
            }
            else
            {
                lbwarning2.Text = "两次输入密码不一致";
                flag3 = false;
            }
            if (flag1 && flag2 && flag3)
                btnsave.Enabled = true;
            else
                btnsave.Enabled = false;
        }

        private void PassWordChange_TextChanged(object sender, EventArgs e)
        {
            if (flag1 && flag2 && flag3)
                btnsave.Enabled = true;
            else
                btnsave.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定修改么？请牢记您的新密码", " 是否保存新密码", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;
            SqlConnection con = new SqlConnection("server=.;database=mycourse;integrated security=true");
            con.Open();
            string sql = "update  student set StuPassWord='"+txtnewpwd.Text+"' where StuNo='" + stu.StuNo + "'";
            SqlCommand cm = new SqlCommand(sql, con);
            if (cm.ExecuteNonQuery() <=0)
            {
                MessageBox.Show("保存失败");
                return;
            }
            con.Close();
            MessageBox.Show("保存成功");
            this.Close();
        }
    }
}
