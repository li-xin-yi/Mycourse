using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mycourse
{
    [Serializable]
    public class Course
    {
        /// <summary>
        /// 课程名
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// 课程号
        /// </summary>
        public string CourseNo { get; set; }
        /// <summary>
        /// 课序号
        /// </summary>
        public string SubNo { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 教师
        /// </summary>
        public string Teacher { get; set; }
        /// <summary>
        /// 学分
        /// </summary>
        public float CourseCredit { get; set; }
        /// <summary>
        /// 上课地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 选课班级
        /// </summary>
        public string Cclass { get; set; }
        /// <summary>
        /// 上课时间
        /// </summary>
        public CourseTime ctime = new CourseTime();
        /// <summary>
        /// 根据课程号和课序号获得课程信息
        /// </summary>
        public void getcourse(string Cno, string Csubno)
        {
            string sql = "select * from test where CourseNo='" + Cno + "' and SubNo='" + Csubno + "'";
            SqlConnection con = new SqlConnection("server=.;database=mycourse;integrated security=true");
            con.Open();
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader reder = cm.ExecuteReader();
            while (reder.Read())
            {
               CourseNo = reder["CourseNo"].ToString();
               CourseName = reder["CourseName"].ToString();
               SubNo = reder["SubNo"].ToString();
               Teacher = reder["Teacher"].ToString();
                Type = reder["Type"].ToString();
                Cclass = reder["Cclass"].ToString();
                address = reder["address"].ToString();
                CourseCredit = Convert.ToSingle(reder["CourseCredit"]);
                ctime.times = Convert.ToInt32(reder["times"]);
                ctime.weekbegin = Convert.ToInt32(reder["coursebegin"]);
                ctime.weekend = Convert.ToInt32(reder["courseend"]);
                ctime.schooldays[0] = Convert.ToInt32(reder["day1"]);
                ctime.schooldays[1] = Convert.ToInt32(reder["day2"]);
                ctime.schooldays[2] = Convert.ToInt32(reder["day3"]);
                ctime.schooldays[3] = Convert.ToInt32(reder["day4"]);
                ctime.schooldays[4] = Convert.ToInt32(reder["day5"]);
                ctime.schooldays[5] = Convert.ToInt32(reder["day6"]);
            }
            reder.Close();
            con.Close();
        }

        /// <summary>
        /// 对选课学生列表进行序列化保存信息
        /// </summary>
        public void SerializeStu(List<Student> L)
        {
            using (FileStream fopen = new FileStream(@"d:\CourseList/" + CourseNo + "_" + SubNo + ".data", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fopen,L);
            }
        }

        /// <summary>
        /// 对选课学生列表进行反序列化读取信息
        /// </summary>
        public List<Student>  DeSerializeStu()
        {
            List<Student> L;
            using (FileStream fread = new FileStream(@"d:\CourseList/" + CourseNo + "_" + SubNo + ".data", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                L = (List<Student>)formatter.Deserialize(fread);
            }
            return L;
        }

        /// <summary>
        /// 移除选课学生
        /// </summary>
        public List<Student> removestudent(string no)
        {
            List<Student> L=new List<Student>();
            if (File.Exists(@"d:\CourseList/" + CourseNo + "_" + SubNo + ".data"))
            {
                L = DeSerializeStu();
                foreach (Student S in L)
                {
                    if (S.StuNo == no)
                    {
                        L.Remove(S);
                        break;
                    }
                }
                SerializeStu(L);
            }
            return L;
        }

    }

 
}
