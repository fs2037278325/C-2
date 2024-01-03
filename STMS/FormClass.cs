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
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();
        }
        public string studentnumber = "";

        private void fillList()
        {
            this.lstClass.Items.Clear();
            //设置用户字符串

            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = myConnection.CreateCommand();
            string sql = "select class,idofstudent,name ";
            sql += "from T_Student ";
            sql += "where T_Student.class='" + textclass.Text + "'";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    ListViewItem item = new ListViewItem(myDataReader["class"].ToString());
                    item.SubItems.Add(myDataReader["idofstudent"].ToString());
                    item.SubItems.Add(myDataReader["name"].ToString());

                    lstClass.Items.Add(item);
                }
            }
            myDataReader.Close();
            myConnection.Close();
        }

        private void textnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lststudent.SelectedItems.Count < 1)
            {
                MessageBox.Show("未选中任何信息！");
            }
            else
            {
                //设置用户字符串
                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                studentnumber = textnumber.Text;
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //删除数据库中相应的记录。
                SqlCommand myCommand = myConnection.CreateCommand();



                string sql = "update T_User set password='" + textpassword.Text + "'where idofuser='" + textbianhao.Text + "'";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();


                string sql1 = "update T_Student set idofuser='" + textbianhao.Text + "',[name]='" + textname.Text + "',sex='" + textsex.Text + "',school='" + textschool.Text + "',class='" + textclassnumber.Text + "'where idofstudent ='" + textnumber.Text + "'";

                myCommand.CommandText = sql1;
                myCommand.ExecuteNonQuery();
                myConnection.Close();

                fillList();

                this.lststudent.Items.Clear();
                //设置用户字符串

                //string connectionString = "server=localhost;uid=sa;pwd=123;database=Test";
                //建立连接。
                //SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取T_Address表中的所有内容，并填充到ListView中。    
                //SqlCommand myCommand = myConnection.CreateCommand();
                string sql2 = "select username,idofstudent,[name],sex,convert(char(10),birthday,120)birthday,school,class ";
                sql2 += "from T_Student,T_User ";
                sql2 += "where T_Student.idofuser=T_User.idofuser and T_Student.idofstudent='" + textnumber.Text + "'";
                myCommand.CommandText = sql2;
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
                        lststudent.Items.Add(item);
                    }
                }
                myDataReader.Close();
                myConnection.Close();


                textbianhao.Text = "";
                textnumber.Text = "";
                textname.Text = "";
                textsex.Text = "";
                textschool.Text = "";
                textpassword.Text = "";
            }
        }

        private void lstClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选中选项时使得下方的文本框中内容与ListView相同。
            if (lstClass.SelectedItems.Count >= 1)
            {

                this.lststudent.Items.Clear();
                //设置用户字符串

                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取T_Address表中的所有内容，并填充到ListView中。    
                SqlCommand myCommand = myConnection.CreateCommand();
                string sql = "select username,idofstudent,[name],sex,convert(char(10),birthday,120)birthday,school,class ";
                sql += "from T_Student,T_User ";
                sql += "where T_Student.idofuser=T_User.idofuser and T_Student.idofstudent='" + lstClass.SelectedItems[0].SubItems[1].Text + "'";
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
                        lststudent.Items.Add(item);
                    }
                }
                myDataReader.Close();
                myConnection.Close();

            }

        }

        private void liststudent_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (lststudent.SelectedItems.Count < 1)
            {
                MessageBox.Show("未选中任何信息！");
            }
            else
            {
                //设置用户字符串
                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                studentnumber =  textnumber.Text;
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //删除数据库中相应的记录。
                SqlCommand myCommand = myConnection.CreateCommand();



                string sql = "update T_User set password='" + textpassword.Text + "'where idofuser='" + textbianhao.Text + "'";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();


                string sql1 = "update T_Student set idofuser='" + textbianhao.Text + "',[name]='" + textname.Text + "',sex='" + textsex.Text + "',school='" + textschool.Text + "',class='" + textclassnumber.Text + "'where idofstudent ='" + textnumber.Text + "'";

                myCommand.CommandText = sql1;
                myCommand.ExecuteNonQuery();
                myConnection.Close();

                fillList();

                this.lststudent.Items.Clear();
                //设置用户字符串

                //string connectionString = "server=localhost;uid=sa;pwd=123;database=Test";
                //建立连接。
                //SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取T_Address表中的所有内容，并填充到ListView中。    
                //SqlCommand myCommand = myConnection.CreateCommand();
                string sql2 = "select username,idofstudent,[name],sex,convert(char(10),birthday,120)birthday,school,class ";
                sql2 += "from T_Student,T_User ";
                sql2 += "where T_Student.idofuser=T_User.idofuser and T_Student.idofstudent='" + textnumber.Text + "'";
                myCommand.CommandText = sql2;
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
                        lststudent.Items.Add(item);
                    }
                }
                myDataReader.Close();
                myConnection.Close();


                textbianhao.Text = "";
                textnumber.Text = "";
                textname.Text = "";
                textsex.Text = "";
                textschool.Text = "";
                textclassnumber.Text = "";
                textpassword.Text = "";
            }
        }

    }
}

