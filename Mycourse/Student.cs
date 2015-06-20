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
    public class Student
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string StuNo { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string StuName { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        public string StuClass { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 专业
        /// </summary>
        public string StuMajority { get; set;}
        /// <summary>
        /// 密码
        /// </summary>
        public string StuPassWord { get; set; }
        /// <summary>
        /// 课程表
        /// </summary>
        public CourseSchedule Sche=new CourseSchedule();
        /// <summary>
        /// 通过学号进入数据库查找，得到该学生所有信息
        /// </summary>
        public void getinfo(string StudentNo)
        {
           
        }
        public Student() { }

        /// <summary>
        /// 序列化课程表，写入文件保存
        /// </summary>
        public void SerializeSche()
        {
            using (FileStream fopen = new FileStream(@"d:\Course/" + StuNo + "/info.data", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fopen, Sche);
            }
        }

        /// <summary>
        /// 反序列化课程表，得到存储的Schedule课程表信息
        /// </summary>
        public void DeSerializeSche()
        {
            using (FileStream fread = new FileStream(@"d:\Course/" + StuNo + "/info.data", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Sche = (CourseSchedule)formatter.Deserialize(fread);
            }
        }

    }
}
