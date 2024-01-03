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

namespace Example_1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool islogin = false;
        public int type = -1;

        /// <summary>
        /// IsLogin属性，用于判断用户是否正确登录
        /// </summary>
        public bool IsLogin
        {
            get
            {
                return islogin;
            }
            set
            {
                this.islogin = value;
            }
        }

        private int usertype = 0;

        public int Usertype
        {
            get
            {
                return usertype;
            }
            set
            {
                this.usertype = value;
            }
        }
        private User user = new User();

        /// <summary>
        /// 当前登录用户
        /// </summary>
        public User CurrentUser
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        /// <summary>
        /// 窗体的Load事件，在窗体显示前触发，在Load方法中设置用户类型的默认选择为管理员。
        /// </summary>

        private void FormLogin_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
        }
        /// <summary>
        /// 取消按钮，退出登录窗体。
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //检测用户是否输入用户名。
            if (this.textName.Text == string.Empty)
            {
                MessageBox.Show("请输入用户名！");
                this.textName.Focus();
                return;
            }
            //检测用户是否输入密码。
            else if (this.textPassword.Text == string.Empty)
            {
                MessageBox.Show("请输入密码！");
                this.textPassword.Focus();
                return;
            }
            else
            {
                //设置用户字符串
                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取所填用户名的密码。
                SqlCommand myCommand = myConnection.CreateCommand();
                string sql = "SELECT username, password, usertype FROM T_User WHERE (username = N'" + textName.Text.Trim() + "')";
                myCommand.CommandText = sql;
                SqlDataReader myDataReader = myCommand.ExecuteReader();

                //判断是否存在该用户。
                if (!myDataReader.HasRows)
                {
                    MessageBox.Show("用户名不存在，请重新输入！");
                }

                //读取数据库中的内容，并于当前输入比较。
                while (myDataReader.Read())
                {
                    //判断用户输入与数据库内容是否匹配。
                    if (myDataReader["password"].ToString().Trim() != textPassword.Text.Trim())
                    {
                        MessageBox.Show("用户名密码不正确，请重新输入！");
                        textName.Focus();
                        return;
                    }
                    else
                    {
                        //匹配时，使用User对象，储存相应的内容，并将islogin的值置为true。
                        user.Username = myDataReader["username"].ToString().Trim();
                        user.Password = myDataReader["password"].ToString().Trim();
                        /*switch (Convert.ToInt32(myDataReader["usertype"]))
                        {
                            case 0:
                                user.Usertype = User.UserType.Admin;
                                this.usertype = 1;
                                break;
                            case 1:
                                user.Usertype = User.UserType.Teacher;
                                this.usertype = 2;
                                break;
                            case 2:
                                user.Usertype = User.UserType.Student;
                                this.usertype = 3;
                                break;
                            default:
                                MessageBox.Show("数据错误！");
                                return;
                        }*/
                        this.islogin = true;
                    }
                }
                //关闭数据库连接。
                myDataReader.Close();
                myConnection.Close();
                this.Close();
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
