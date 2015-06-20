using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Mycourse
{
   public class StuHP
    {
        /// <summary>
        /// 获取暂存的实例化学生
        /// </summary>
        public Student temp = new Student();
        /// <summary>
        /// 数据库Mycourse的打开的连接
        /// </summary>
        SqlConnection con = new SqlConnection("server=.;database=mycourse;integrated security=true");
        /// <summary>
        /// 查找是否存在学号为参数的学号，若存在则录入信息并返回true,否则返回false
        /// </summary>
        public bool Login(string user)
        {
            con.Open();
            string sqlquery = "SELECT * FROM student where StuNo='"+user+"'";
            SqlCommand cm = new SqlCommand(sqlquery, con);
            int count = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            if (count == 0)
                return false;
            else
                return true;
            
        }
        /// <summary>
        /// 查找是否存在学号和密码为参数的学号，若存在则录入信息并返回true,否则返回false
        /// </summary>
       public bool Login(string user,string pwd)
        {
            string password;
            bool result=false;
            con.Open();
            string sqlquery = "SELECT * FROM student where StuNo='" + user + "'";
            SqlCommand cm = new SqlCommand(sqlquery, con);
            SqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                password = reader["StuPassWord"].ToString();
                if (pwd == password)
                {
                    result = true;
                    temp.StuNo = user;
                    temp.StuName = reader["StuName"].ToString();
                    temp.StuClass = reader["StuClass"].ToString();
                    temp.Gender = reader["Gender"].ToString();
                    temp.StuMajority = reader["StuMajority"].ToString();
                    temp.StuPassWord = reader["StuPassWord"].ToString();

                    if (File.Exists(@"d:\Course/" + user + "/info.data"))
                    {
                        temp.DeSerializeSche();
                    }
                }
                
            }
            reader.Close();
            con.Close();
            return result;
        }

       /// <summary>
       /// 通过学生的学号获得学生信息，若查无此人返回false
       /// </summary>
       public bool getstudent(string no)
       {
           con.Open();
           string sqlquery = "SELECT * FROM student where StuNo='" + no + "'";
           SqlCommand cm = new SqlCommand(sqlquery, con);
           int count = Convert.ToInt32(cm.ExecuteScalar());
           if (count == 0) 
           { 
               con.Close();
               return false;
           }
           SqlDataReader reader = cm.ExecuteReader();
           while (reader.Read())
           {
                   temp.StuNo = no;
                   temp.StuName = reader["StuName"].ToString();
                   temp.StuClass = reader["StuClass"].ToString();
                   temp.Gender = reader["Gender"].ToString();
                   temp.StuMajority = reader["StuMajority"].ToString();
                   temp.StuPassWord = reader["StuPassWord"].ToString();
                   if (File.Exists(@"d:\Course/" + no + "/info.data"))
                   {
                       temp.DeSerializeSche();
                   }

           }
           reader.Close();
           con.Close();
           return true;
       }
    }
}
