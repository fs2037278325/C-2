using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    /// <summary>
    /// 用户类，与数据库中T_User表相对应。
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用于标识用户类型的枚举
        /// </summary>
        public enum UserType
        {
            /// <summary>
            /// 管理员
            /// </summary>
            Admin,
            /// <summary>
            /// 教师
            /// </summary>
            Teacher,
            /// <summary>
            /// 学生
            /// </summary>
            Student
        }

        /// <summary>
        /// 用于标识用户性别的枚举
        /// </summary>
        public enum SexType
        {
            /// <summary>
            /// 男
            /// </summary>
            Male,
            /// <summary>
            /// 女
            /// </summary>
            Female
        }

        private string username;

        /// <summary>
        /// 用户名
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        private string password;

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        private UserType usertype;

        /// <summary>
        /// 用户类型
        /// </summary>
        public UserType Usertype
        {
            get
            {
                return usertype;
            }
            set
            {
                usertype = value;
            }
        }
    }
}
