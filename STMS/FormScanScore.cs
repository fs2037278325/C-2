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
    public partial class FormScanScore : Form
    {
        public FormScanScore()
        {
            InitializeComponent();
            NAME.Visible = false;
            studentname.Visible = false;
        }
        private void fillList()
        {
            this.listscorequery.Items.Clear();
            //设置用户字符串
            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //读取T_Address表中的所有内容，并填充到ListView中。    
            SqlCommand myCommand = myConnection.CreateCommand();

            string sql = "select distinct coursename,score ";
            sql += "from T_Course_Student,T_Course,T_Student ";
            sql += "where  T_Course_Student.idofcourse = T_Course.idofcourse and T_Course_Student.idofstudent='" + textstudentnumber.Text + "'";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows)
            {
                while (myDataReader.Read())
                {
                    ListViewItem item = new ListViewItem(myDataReader["coursename"].ToString());
                    item.SubItems.Add(myDataReader["score"].ToString());
                    listscorequery.Items.Add(item);
                }
            }
            myDataReader.Close();
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //将新添加的内容添加到数据库中，并更新ListView的显示。
            SqlCommand myCommand = myConnection.CreateCommand();

            string sql0 = "select * from T_Student where idofstudent='" + textstudentnumber.Text + "'";

            myCommand.CommandText = sql0;
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            if (!myDataReader.HasRows)
            {
                MessageBox.Show("该学生不存在，请重新输入！");
                textstudentnumber.Text = "";

                //myDataReader.Close();
                return;
            }


            myDataReader.Close();

            fillList();
            NAME.Visible = true;
            studentname.Visible = true;


            string sql = "select [name] from T_Student where T_Student.idofstudent='" + textstudentnumber.Text + "'";
            myCommand.CommandText = sql;
            SqlDataReader myDataReader1 = myCommand.ExecuteReader();
            if (myDataReader1.HasRows)
            {
                while (myDataReader1.Read())
                {
                    studentname.Text = myDataReader1["name"].ToString();

                }
            }
            myDataReader1.Close();
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NAME.Visible = false;
            studentname.Visible = false;
            textstudentnumber.Text = "";
            this.listscorequery.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
