using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_1
{
    public partial class FormLock : Form
    {
        public FormLock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //检测用户是否输入用户名。

            if (textpassword.Text == string.Empty)
            {
                MessageBox.Show("请输入解锁码！");
                textpassword.Text = "";
                this.textpassword.Focus();
                return;
            }

            else
            {

                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";


                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取所填用户名的密码。
                SqlCommand myCommand = myConnection.CreateCommand();
                //string sql = "SELECT username, password, usertype FROM T_User WHERE (username = N'" + txtUsername.Text.Trim() + "')";
                string sql = "select * from T_User where password='" + textpassword.Text + "'";
                myCommand.CommandText = sql;
                SqlDataReader myDataReader = myCommand.ExecuteReader();

                //判断是否存在该用户。
                if (!myDataReader.HasRows)
                {
                    MessageBox.Show("解锁码不正确，请重新输入！");
                    textpassword.Text = "";
                    this.textpassword.Focus();
                }

                //读取数据库中的内容，并于当前输入比较。

                else
                {
                    //关闭数据库连接。
                    myDataReader.Close();
                    myConnection.Close();
                    this.Close();

                }

            }
        }

        private void FormLock_Load(object sender, EventArgs e)
        {

        }
    }
}
