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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
            fillList();
        }
        private void fillList()
        {
            this.listteacher.Items.Clear();
            //设置用户字符串

            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //读取T_Address表中的所有内容，并填充到ListView中。    
            SqlCommand myCommand = myConnection.CreateCommand();
            string sql = "select username,idofteacher,[name],sex,school ";
            sql += "from T_Teacher,T_User ";
            sql += "where T_Teacher.idofuser=T_User.idofuser";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    ListViewItem item = new ListViewItem(myDataReader["username"].ToString());
                    item.SubItems.Add(myDataReader["name"].ToString());
                    item.SubItems.Add(myDataReader["idofteacher"].ToString());
                    item.SubItems.Add(myDataReader["sex"].ToString());
                    item.SubItems.Add(myDataReader["school"].ToString());
                    listteacher.Items.Add(item);
                }
            }
            myDataReader.Close();
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbianhao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户编号不能为空！");
                textbianhao.Focus();
            }
            else if (textnumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("教师编号不能为空！");
                textnumber.Focus();
            }
            else if (textname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("学生姓名不能为空！");
                textname.Focus();

            }
            else if (textsex.Text.Trim() == string.Empty)
            {
                MessageBox.Show("性别不能为空！");
                textsex.Focus();
            }
            else if (textschool.Text.Trim() == string.Empty)
            {
                MessageBox.Show("学院不能为空！");
                textschool.Focus();
            }

            else if (textpassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码不能为空！");
                textpassword.Focus();
            }

            else
            {

                //设置用户字符串
                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //将新添加的内容添加到数据库中，并更新ListView的显示。
                SqlCommand myCommand = myConnection.CreateCommand();

                string sql0 = "select * from T_User where idofuser='" + textbianhao.Text + "'";

                myCommand.CommandText = sql0;
                SqlDataReader myDataReader = myCommand.ExecuteReader();


                if (myDataReader.HasRows)
                {
                    MessageBox.Show("该用户编号已经存在，请重新输入！");
                    textbianhao.Text = "";
                    textnumber.Text = "";
                    textname.Text = "";
                    textsex.Text = "";
                    textschool.Text = "";
                    textpassword.Text = "";
                    //myDataReader.Close();

                }
                else
                {
                    string sql = "insert into T_User(idofuser,username,password,usertype) values('" + textbianhao.Text + "','" + textpassword.Text + "','2')";

                    myDataReader.Close();

                    myCommand.CommandText = sql;
                    myCommand.ExecuteNonQuery();

                    string sql1 = "insert into T_Teacher(idofteacher,idofuser,[name],sex,birthday,school)";
                    sql1 += "values('" + textnumber.Text + "','" + textbianhao.Text + "','" + textname.Text + "','" + textsex.Text + "','" + textschool.Text + "')";

                    myCommand.CommandText = sql1;
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    fillList();

                    textbianhao.Text = "";
                    textnumber.Text = "";
                    textname.Text = "";
                    textsex.Text = "";
                    textschool.Text = "";
                    textpassword.Text = "";

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //未选中地址时不进行任何操作。

            if (listteacher.SelectedItems.Count < 1)
            {
                MessageBox.Show("未选中任何地址信息！");
            }
            else
            {
                //设置用户字符串
                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //删除数据库中相应的记录。
                SqlCommand myCommand = myConnection.CreateCommand();

                string sql3 = "delete from T_Course_Teacher where idofteacher='" + textnumber.Text + "'";
                myCommand.CommandText = sql3;
                myCommand.ExecuteNonQuery();



                string sql = "delete from T_Teacher where idofteacher='" + textnumber.Text + "'";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();

                myConnection.Close();
                fillList();

                textbianhao.Text = "";
                textnumber.Text = "";
                textname.Text = "";
                textsex.Text = "";

                textschool.Text = "";
                textpassword.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listteacher.SelectedItems.Count < 1)
            {
                MessageBox.Show("未选中任何地址信息！");
            }
            else
            {
                //设置用户字符串
                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //删除数据库中相应的记录。
                SqlCommand myCommand = myConnection.CreateCommand();



                string sql = "password='" + textpassword.Text + "'where idofuser='" + textbianhao.Text + "'";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();


                string sql1 = "update T_Teacher set idofuser='" + textbianhao.Text + "',[name]='" + textname.Text + "',sex='" + textsex.Text + "',school='" + textschool.Text + "' where idofteacher ='" + textnumber.Text + "'";

                myCommand.CommandText = sql1;
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                fillList();

                textbianhao.Text = "";
                textnumber.Text = "";
                textname.Text = "";
                textsex.Text = "";
                textschool.Text = "";
                textpassword.Text = "";
            }
        }
    }
}
