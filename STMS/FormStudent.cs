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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            fillList();
        }
        private void fillList()
        {
            this.liststudent.Items.Clear();
            //设置用户字符串

            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //读取T_Address表中的所有内容，并填充到ListView中。    
            SqlCommand myCommand = myConnection.CreateCommand();
            string sql = "select username,idofstudent,[name],sex,school,class ";
            sql += "from T_Student,T_User ";
            sql += "where T_Student.idofuser=T_User.idofuser";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    ListViewItem item = new ListViewItem(myDataReader["username"].ToString());
                    item.SubItems.Add(myDataReader["name"].ToString());
                    item.SubItems.Add(myDataReader["idofstudent"].ToString());
                    item.SubItems.Add(myDataReader["sex"].ToString());
                    item.SubItems.Add(myDataReader["school"].ToString());
                    item.SubItems.Add(myDataReader["class"].ToString());
                    liststudent.Items.Add(item);
                }
            }
            myDataReader.Close();
            myConnection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断地址文本框中的内容是否为空，为空时不添加。
            if (textbianhao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户编号不能为空！");
                textbianhao.Focus();
            }
            else if (textnumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("学号不能为空！");
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
            else if (textclass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("班级不能为空！");
                textclass.Focus();
            }
            else if (textpassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码不能为空！");
                textpassword.Focus();
            }

            else
            {
                //设置用户字符串
               string  connectionString = "Data Source=LAPTOP-FACBHIB8;Initial Catalog=STMS;User ID=sa;pwd=MIAO090918";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //将新添加的内容添加到数据库中，并更新ListView的显示。
                SqlCommand myCommand = myConnection.CreateCommand();

                string sql0 = "select * from T_User where idofuser='" + textbianhao.Text + "'";

                myCommand.CommandText = sql0;
                SqlDataReader myDataReader = myCommand.ExecuteReader();

                //SqlDataAdapter da = new SqlDataAdapter(sql0, myConnection);
                //DataSet ds = new DataSet();
                //da.Fill(ds, "record");


                //if(myDataReader.HasRows)

                //if (ds.Tables["record"].Rows.Count>0)
                if (myDataReader.HasRows)
                {
                    MessageBox.Show("该用户编号已经存在，请重新输入！");
                    textbianhao.Text = "";
                    textname.Text = "";
                    textnumber.Text = "";
                    textname.Text = "";
                    textsex.Text = "";
                    textschool.Text = "";
                    textclass.Text = "";
                    textpassword.Text = "";
                    //myDataReader.Close();

                }
                else
                {
                    string sql = "insert into T_User(idofuser,username,password,usertype) values('" + textbianhao.Text + "','" + textname.Text + "','" + textpassword.Text + "','1')";

                    myDataReader.Close();

                    myCommand.CommandText = sql;
                    myCommand.ExecuteNonQuery();

                    string sql1 = "insert into T_Student(idofstudent,idofuser,[name],sex,birthday,school,class)";
                    sql1 += "values('" + textnumber.Text + "','" + textbianhao.Text + "','" + textname.Text + "','" + textsex.Text + "','" + textschool.Text + "','" + textclass.Text + "')";

                    myCommand.CommandText = sql1;
                   // myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    fillList();

                    textbianhao.Text = "";
                    textname.Text = "";
                    textnumber.Text = "";
                    textname.Text = "";
                    textsex.Text = "";
                    textschool.Text = "";
                    textclass.Text = "";
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

            if (liststudent.SelectedItems.Count < 1)
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

                string sql3 = "delete from T_Course_Student where idofstudent='" + textnumber.Text + "'";
                myCommand.CommandText = sql3;
                myCommand.ExecuteNonQuery();


                string sql = "delete from T_Student where idofstudent='" + textnumber.Text + "'";//liststudent.SelectedItems[2].Text

                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                fillList();

                textbianhao.Text = "";
                textnumber.Text = "";
                textname.Text = "";
                textsex.Text = "";
                textschool.Text = "";
                textclass.Text = "";
                textpassword.Text = "";

            }
        }

        private void liststudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选中选项时使得下方的文本框中内容与ListView相同。
            if (liststudent.SelectedItems.Count >= 1)
            {

                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                 
                SqlCommand myCommand = myConnection.CreateCommand();
                string sql = "select idofuser from T_User where idofstudent='" + liststudent.SelectedItems[0].SubItems[2].Text + "' ";

                myCommand.CommandText = sql;
                SqlDataReader myDataReader = myCommand.ExecuteReader();


                if (myDataReader.HasRows)
                {
                    while (myDataReader.Read())
                    {
                        textbianhao.Text = myDataReader["idofuser"].ToString();

                    }
                }
                textnumber.Text = liststudent.SelectedItems[0].SubItems[2].Text;
                textname.Text = liststudent.SelectedItems[0].SubItems[1].Text;
                textsex.Text = liststudent.SelectedItems[0].SubItems[3].Text;
                textschool.Text = liststudent.SelectedItems[0].SubItems[5].Text;
                textclass.Text = liststudent.SelectedItems[0].SubItems[6].Text;
                textpassword.Text = "*********";

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsex_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbianhao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textschool_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textclass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
