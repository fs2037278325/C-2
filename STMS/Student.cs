using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    /// <summary>
    /// Student类，继承自User类，用于表示学生。
    /// </summary>
    public class Student : User
    {
        private string name;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private User.SexType sex;

        /// <summary>
        /// 性别
        /// </summary>
        public User.SexType Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        private string stuednetnumber;

        /// <summary>
        /// 学号
        /// </summary>
        public string Teachernumber
        {
            get
            {
                return stuednetnumber;
            }
            set
            {
                stuednetnumber = value;
            }
        }

        private string school;

        /// <summary>
        /// 学院
        /// </summary>
        public string School
        {
            get
            {
                return school;
            }
            set
            {
                school = value;
            }
        }




        private string ownclass;

        /// <summary>
        /// 班级
        /// </summary>
        public string Ownclass
        {
            get
            {
                return ownclass;
            }
            set
            {
                ownclass = value;
            }
        }
    }
}
