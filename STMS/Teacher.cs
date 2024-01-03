using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    /// <summary>
    /// Teacher类，继承自User类，表示教师。
    /// </summary>
    public class Teacher : User
    {
        private string name;

        /// <summary>
        /// 教师姓名
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

        private string teachernumber;

        /// <summary>
        /// 教师号
        /// </summary>
        public string Teachernumber
        {
            get
            {
                return teachernumber;
            }
            set
            {
                teachernumber = value;
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
    }
}
