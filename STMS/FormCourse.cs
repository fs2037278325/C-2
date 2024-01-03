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
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
            fillList();
        }
        private void fillList()
        {
            this.lstCourse.Items.Clear();
            //设置用户字符串

            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = myConnection.CreateCommand();
            string sql = "select coursename,capacity,coursetypename,credit,time,coursetimename ";
            //sql += "from T_Course ";
            //sql += "where T_Course.idofcoursetype=T_Coursetype.idofcoursetype and T_Course.idofaddress=T_Address.idofaddress and T_Course.idofcoursetime=T_Course_Time.idofcoursetime";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    ListViewItem item = new ListViewItem(myDataReader["coursename"].ToString());
                    item.SubItems.Add(myDataReader["capacity"].ToString());
                    item.SubItems.Add(myDataReader["addressname"].ToString());
                    item.SubItems.Add(myDataReader["coursetypename"].ToString());
                    item.SubItems.Add(myDataReader["credit"].ToString());
                    item.SubItems.Add(myDataReader["time"].ToString());
                    item.SubItems.Add(myDataReader["coursetimename"].ToString());

                    lstCourse.Items.Add(item);
                }
            }
            myDataReader.Close();
            myConnection.Close();
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            //定义相应变量
            string connectionString;
            SqlConnection myConnection;

            //源代码   SqlCommand myCommand;

            SqlDataReader myDataReader;
            string sql;

            //设置用户字符串

            connectionString = "server=localhost;uid=sa;pwd=123;database=Test";

            //建立连接。
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            this.cmbCourseType.Items.Clear();
            //设置用户字符串
            connectionString = "server=localhost;uid=sa;pwd=123;database=Test";
            //建立连接。
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand

          //读取T_Coursetype表中的所有内容，并填充到ComboBox中。
            myCommand = myConnection.CreateCommand();
            sql = "SELECT * FROM T_Coursetype";
            myCommand.CommandText = sql;
            myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    cmbCourseType.Items.Add(myDataReader["coursetypename"].ToString());
                }
            }
            myDataReader.Close();
            myConnection.Close();

            cmbCourseType.SelectedIndex = 0;



            this.cmbCourseTime.Items.Clear();
            //设置用户字符串
            connectionString = "server=localhost;uid=sa;pwd=123;database=Test";
            //建立连接。
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //读取T_Course_Time表中的所有内容，并填充到ComboBox中。
            myCommand = myConnection.CreateCommand();
            sql = "SELECT * FROM T_Course_Time";
            myCommand.CommandText = sql;
            myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    cmbCourseTime.Items.Add(myDataReader["coursetimename"].ToString());
                }
            }
            myDataReader.Close();
            myConnection.Close();
            cmbCourseTime.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idofaddress = null;
            string idofcoursetype = null;
            string idofcoursetime = null;

            if (textbianhao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("课程编号不能为空！");
                textbianhao.Focus();

            }
            else if (textname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("课程名不能为空！");
                textname.Focus();
            }
            else if (textcapacity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("课程容量不能为空！");
                textcapacity.Focus();
            }
            else if (cmbCourseType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("课程类型不能为空！");
                cmbCourseType.Focus();
            }
            else if (textcredit.Text.Trim() == string.Empty)
            {
                MessageBox.Show("课程学分不能为空！");
                textcredit.Focus();
            }
            else if (texttime.Text.Trim() == string.Empty)
            {
                MessageBox.Show("上课时间不能为空！");
                texttime.Focus();
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

                string sql0 = "select * from T_Course where idofcourse='" + textbianhao.Text + "'";

                myCommand.CommandText = sql0;
                SqlDataReader myDataReader = myCommand.ExecuteReader();

                if (myDataReader.HasRows)
                {
                    MessageBox.Show("该课程编号已经存在，请重新输入！");
                    textbianhao.Text = "";
                    textname.Text = "";
                    cmbCourseType.Text = "";
                    textcapacity.Text = "";
                    textcredit.Text = "";
                    texttime.Text = "";

                    //myDataReader.Close();

                }
                else
                {

                    myDataReader.Close();

                    //myCommand.CommandText = sql;
                    // myCommand.ExecuteNonQuery();

                    /////////string idofaddress;
                    /////////string idofcoursetype;


                    //建立连接。



                    //将新添加的内容添加到数据库中，并更新ListView的显示。


                    string sql2 = "select idofaddress,idofcoursetype,idofcoursetime from T_Address,T_Coursetype,T_Course_Time ' and T_Coursetype.coursetypename='" + cmbCourseType.Text + "'and T_Course_Time.coursetimename='" + cmbCourseTime.Text + "'";

                    //........

                    myCommand.CommandText = sql2;
                    SqlDataReader myDataReader1 = myCommand.ExecuteReader();

                    if (myDataReader1.HasRows)
                    {
                        while (myDataReader1.Read())
                        {
                            idofaddress = myDataReader1["idofaddress"].ToString();
                            idofcoursetype = myDataReader1["idofcoursetype"].ToString();
                            idofcoursetime = myDataReader1["idofcoursetime"].ToString();

                        }


                    }
                    myDataReader1.Close();

                    string sql1 = "insert into T_Course(idofcourse,coursename,capacity,idofaddress,idofcoursetype,credit,[time],idofcoursetime)";

                    sql1 += "values('" + textbianhao.Text + "','" + textname.Text + "','" + textcapacity.Text + "','" + idofaddress + " ','" + idofcoursetype + " ','" + textcredit.Text + "','" + texttime.Text + "','" + idofcoursetime + " ')";

                    myCommand.CommandText = sql1;
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    fillList();

                    textbianhao.Text = "";
                    textname.Text = "";
                    cmbCourseType.Text = "";
                    textcapacity.Text = "";
                    textcredit.Text = "";
                    texttime.Text = "";
                    cmbCourseTime.Text = "";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //未选中地址时不进行任何操作。

            if (lstCourse.SelectedItems.Count < 1)
            {
                MessageBox.Show("未选中任何课程信息！");
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



                string sql1 = "delete from T_Course_Student where idofcourse='" + textbianhao.Text + "'";

                string sql2 = "delete from T_Course_Teacher where idofcourse='" + textbianhao.Text + "'";

                string sql = "delete from T_Course where idofcourse='" + textbianhao.Text + "'";


                myCommand.CommandText = sql1;
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = sql2;
                myCommand.ExecuteNonQuery();


                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();

                myConnection.Close();
                fillList();

                textbianhao.Text = "";
                textname.Text = "";
                textcapacity.Text = "";
                textcredit.Text = "";
                texttime.Text = "";
            }
        }

        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选中选项时使得下方的文本框中内容与ListView相同。

            if (lstCourse.SelectedItems.Count >= 1)
            {

                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                SqlCommand myCommand = myConnection.CreateCommand();
                string sql = "select idofcourse from T_Course where coursename='" + lstCourse.SelectedItems[0].SubItems[0].Text + "' ";

                myCommand.CommandText = sql;
                SqlDataReader myDataReader = myCommand.ExecuteReader();


                if (myDataReader.HasRows)
                {
                    while (myDataReader.Read())
                    {
                        textbianhao.Text = myDataReader["idofcourse"].ToString();

                    }
                }
                textname.Text = lstCourse.SelectedItems[0].SubItems[0].Text;
                cmbCourseType.Text = lstCourse.SelectedItems[0].SubItems[3].Text;
                textcapacity.Text = lstCourse.SelectedItems[0].SubItems[1].Text;
                textcredit.Text = lstCourse.SelectedItems[0].SubItems[4].Text;
                texttime.Text = lstCourse.SelectedItems[0].SubItems[5].Text;
                cmbCourseTime.Text = lstCourse.SelectedItems[0].SubItems[6].Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idofaddress = null;
            string idofcoursetype = null;
            string idofcoursetime = null;

            if (lstCourse.SelectedItems.Count < 1)
            {
                MessageBox.Show("未选中任何课程信息！");
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


                string sql2 = "select idofaddress,idofcoursetype,idofcoursetime from T_Address,T_Coursetype,T_Course_Time'and T_Coursetype.coursetypename='" + cmbCourseType.Text + "'and T_Course_Time.coursetimename='" + cmbCourseTime.Text + "'";

                myCommand.CommandText = sql2;
                SqlDataReader myDataReader1 = myCommand.ExecuteReader();

                if (myDataReader1.HasRows)
                {
                    while (myDataReader1.Read())
                    {
                        idofaddress = myDataReader1["idofaddress"].ToString();
                        idofcoursetype = myDataReader1["idofcoursetype"].ToString();
                        idofcoursetime = myDataReader1["idofcoursetime"].ToString();
                    }


                }
                myDataReader1.Close();


                string sql = "update T_Course set coursename='" + textname.Text + "',capacity='" + textcapacity.Text + "',credit='" + textcredit.Text + "',time='" + texttime.Text + "',idofaddress='" + idofaddress + "',idofcoursetype='" + idofcoursetype + "',idofcoursetime='" + idofcoursetime + "' where idofcourse='" + textbianhao.Text + "'";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();



                myConnection.Close();
                fillList();


                textbianhao.Text = "";
                textname.Text = "";
                textcapacity.Text = "";
                textcredit.Text = "";
                texttime.Text = "";
            }
        }
    }
}
