using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mycourse
{
    [Serializable]
    public class CourseSchedule
    {
        /// <summary>
        /// 已选课程列表
        /// </summary>
        public List<Course> Crs = new List<Course>();
        /// <summary>
        /// 占用时间状态表，true表示占用，false表示空闲
        /// </summary>
        public bool[,,] statetable = new bool[6, 13, 19];
        /// <summary>
        /// 总学分
        /// </summary>
        public float totalcredit = 0;
        /// <summary>
        /// 添加课程
        /// </summary>
        public void addCourse(Course C)
        {
            bool[, ,] temp = new bool[6, 13, 19];
            temp = C.ctime.transtable();
            
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 13; j++)
                    for (int k = 0; k < 19; k++)
                            statetable[i, j, k] = temp[i, j, k] ||statetable[i, j, k];
            Crs.Add(C);
            totalcredit += C.CourseCredit;
        }

        /// <summary>
        /// 检查课程是否与已选课程冲突
        /// </summary>
        public bool check(Course C)
        {
            bool[, ,] temp = new bool[6, 13, 19];
            temp = C.ctime.transtable();
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 13; j++)
                    for (int k = 0; k < 19; k++)
                        if (temp[i, j, k] && statetable[i, j, k])
                            return false;
            return true;
        }

        /// <summary>
        /// 检查课程组是否与已选课程冲突
        /// </summary>
        public bool check(List<Course> L)
        {
            CourseSchedule temp=new CourseSchedule();
            temp.statetable = this.statetable;
          foreach(Course C in L)
         {
             if (temp.check(C) == false)
                 return false;
             else
                 temp.addCourse(C);
         }
          return true;
        }

        /// <summary>
        /// 添加课程组
        /// </summary>
        public void addCourse(List<Course> L)
        {
            foreach (Course C in L)
            {
              addCourse(C);
            }
        }

        /// <summary>
        /// 删除课程
        /// </summary>
        public void SubCourse(Course C)
        {
            bool[, ,] temp = new bool[6, 13, 19];
            temp = C.ctime.transtable();
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 13; j++)
                    for (int k = 0; k < 19; k++)
                        if (temp[i, j, k])
                            statetable[i, j, k] = false;
            foreach(Course Cr in Crs)
            {
              if(Cr.CourseNo==C.CourseNo&&Cr.SubNo==C.SubNo)
              {
                  C = Cr;
                  break;
              }
            }
            Crs.Remove(C);
            totalcredit -= C.CourseCredit;
        }
    }
}
