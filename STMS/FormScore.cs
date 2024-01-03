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
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
            label6.Visible = false;
            label5.Visible = false;
        }
        private void fillList()
        {
            this.listscore.Items.Clear();
            //设置用户字符串

            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //读取T_Address表中的所有内容，并填充到ListView中。    
            SqlCommand myCommand = myConnection.CreateCommand();

            string sql = "select distinct T_Course_Student.idofcourse,coursename,T_Course_Student.idofstudent,T_Student.[name] as studentname,score ";
            sql += "from T_Teacher,T_Course,T_Student,T_Course_Teacher,T_Course_Student ";
            sql += "where  T_Course_Teacher.idofcourse = T_Course.idofcourse and T_Course_Teacher.idofteacher='" + textteachernumber.Text + "' ";
            sql += "and T_Course_Student.idofcourse=T_Course_Teacher.idofcourse ";
            sql += "and T_Course_Student.idofstudent=T_Student.idofstudent";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    ListViewItem item = new ListViewItem(myDataReader["idofcourse"].ToString());
                    item.SubItems.Add(myDataReader["coursename"].ToString());
                    item.SubItems.Add(myDataReader["idofstudent"].ToString());
                    item.SubItems.Add(myDataReader["studentname"].ToString());
                    item.SubItems.Add(myDataReader["score"].ToString());
                    listscore.Items.Add(item);
                }
            }
            myDataReader.Close();
            myConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listscore.SelectedItems.Count < 1)
            {
                MessageBox.Show("未选中任何信息！");
            }
            else
            {


                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取T_Address表中的所有内容，并填充到ListView中。    
                SqlCommand myCommand = myConnection.CreateCommand();


                string sql1 = "update T_Course_Student set score='" + textscore.Text + "' ";
                sql1 += "where  T_Course_Student.idofcourse='" + listscore.SelectedItems[0].SubItems[0].Text + "' and T_Course_Student.idofstudent='" + listscore.SelectedItems[0].SubItems[2].Text + "'";



                myCommand.CommandText = sql1;
                myCommand.ExecuteNonQuery();



                myConnection.Close();
                fillList();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //将新添加的内容添加到数据库中，并更新ListView的显示。
            SqlCommand myCommand = myConnection.CreateCommand();

            string sql0 = "select * from T_Teacher where idofteacher='" + textteachernumber.Text + "'";

            myCommand.CommandText = sql0;
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            if (!myDataReader.HasRows)
            {
                MessageBox.Show("该教师不存在，请重新输入！");
                textteachernumber.Text = "";

                //myDataReader.Close();
                return;
            }
            myDataReader.Close();
            fillList();

            label6.Visible = true;
            label5.Visible = true;



            string sql = "select [name] from T_Teacher where T_Teacher.idofteacher='" + textteachernumber.Text + "'";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader1 = myCommand.ExecuteReader();
            if (myDataReader1.HasRows)
            {
                while (myDataReader1.Read())
                {
                    label5.Text = myDataReader1["name"].ToString();

                }
            }
            myDataReader1.Close();
            myConnection.Close();



        }

        private void listscore_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选中选项时使得下方的文本框中内容与ListView相同。

            if (listscore.SelectedItems.Count >= 1)
            {

                string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                SqlCommand myCommand = myConnection.CreateCommand();

                textcourse.Text = listscore.SelectedItems[0].SubItems[1].Text;
                textstudentname.Text = listscore.SelectedItems[0].SubItems[3].Text;
                textscore.Text = "";


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textcourse.Text = "";
            textstudentname.Text = "";
            textscore.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
