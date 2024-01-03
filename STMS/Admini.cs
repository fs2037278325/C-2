using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    /// <summary>
    /// Admini类，继承自User，表示管理员
    /// </summary>
    public class Admini : User
    {
        private string name;

        /// <summary>
        /// 管理员姓名
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
    }
}

