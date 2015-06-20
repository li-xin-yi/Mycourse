using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mycourse
{
    [Serializable]
    public class CourseTime
    {
        /// <summary>
        /// 每次课时长（几节课，例如5-6为2节课）
        /// </summary>
        public int times;//每次课时长（几节课，例如5-6为2节课）
        /// <summary>
        /// int[6],记录周一至周六，若无课，则schooldays[i]=0,否则为第一节课的节次
        /// </summary>
        public int[] schooldays = new int[6];
        /// <summary>
        /// 起始周
        /// </summary>
        public int weekbegin;//起始周
        /// <summary>
        /// 结束周
        /// </summary>
        public int weekend;//结束周

        /// <summary>
        /// 将课程时间转化为6*13*19的bool型向量，true代表占用,false代表空闲
        /// </summary>
        public bool[,,] transtable()
        {
             bool[,,] result=new bool[6,13,19];
             for (int i = weekbegin-1; i < weekend-1; i++)
            {
                for(int j=0;j<6;j++)
                if(schooldays[j]!=0)
                {
                    for (int k = 0; k < times; k++)
                        result[j, schooldays[j] + k, i] = true;
                }
            }
            return result;
        } 
    }
}
