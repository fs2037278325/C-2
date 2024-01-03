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
    public partial class FormChange : Form
    {
        public FormChange()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //检测用户是否输入用户名。
            if (this.textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入原密码！");
                this.textBox1.Focus();

                return;
            }
            //检测用户是否输入密码。
            else if (this.newpassword.Text == string.Empty)
            {
                MessageBox.Show("请输入新密码！");
                this.newpassword.Focus();
                return;
            }
            else if (this.confirm.Text == string.Empty)
            {
                MessageBox.Show("请确认输入的密码！");
                this.newpassword.Focus();
                return;
            }

            else
            {
                //设置用户字符串
                //此处为原代码 string connectionString = @"Data Source=WWW-C4074C4DF06\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;Pooling=False";

                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";


                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取所填用户名的密码。
                SqlCommand myCommand = myConnection.CreateCommand();
                //string sql = "SELECT username, password, usertype FROM T_User WHERE (password = '" + oldpassword.Text.Trim() + "')";
                string sql = "SELECT * FROM T_User WHERE (password = '" + textBox1.Text.Trim() + "')";
                myCommand.CommandText = sql;
                SqlDataReader myDataReader = myCommand.ExecuteReader();




                //读取数据库中的内容，并于当前输入比较。
                if (!myDataReader.HasRows)
                {
                    MessageBox.Show("用户名原密码不正确，请重新输入！");
                    this.textBox1.Focus();
                    this.textBox1.Text = "";
                    this.newpassword.Text = "";
                    this.confirm.Text = "";
                    return;

                }


                /* while (myDataReader.Read())
                 {
                     //判断用户输入与数据库内容是否匹配。
                     if (myDataReader["password"].ToString().Trim() != oldpassword.Text.Trim())
                     {
                         MessageBox.Show("用户名原密码不正确，请重新输入！");
                         oldpassword.Focus();
                         return;
                     }

                 }*/


                //关闭数据库连接。
                myDataReader.Close();
                myConnection.Close();
                this.Close();




                if (this.confirm.Text != this.newpassword.Text)
                {
                    MessageBox.Show("两次输入的密码不一致，请重新输入");
                    this.textBox1.Focus();
                    this.textBox1.Text = "";
                    this.newpassword.Text = "";
                    this.confirm.Text = "";
                    return;
                }



                else
                {
                    //设置用户字符串
                    //string connectionString = "server=localhost;uid=sa;pwd=123;database=Test";


                    //建立连接。
                    // SqlConnection myConnection = new SqlConnection(connectionString);
                    myConnection.Open();


                    //读取所填用户名的密码。
                    //SqlCommand myCommand = myConnection.CreateCommand();

                    string sql0 = "update T_User set password='" + newpassword.Text + "' where password='" + textBox1.Text + "'";
                    myCommand.CommandText = sql0;
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    MessageBox.Show("修改成功");
                    this.Close();

                    // string sql = "update t_address set addressname='" + txtAddress.Text + "' where idofaddress='" + lstAddress.SelectedItems[0].Text + "'";


                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.newpassword.Text = "";
            this.confirm.Text = "";
        }
    }
}
    
