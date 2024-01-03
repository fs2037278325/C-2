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
using System.IO;

namespace Example_1
{
    public partial class FormAverage : Form
    {
        public FormAverage()
        {
            InitializeComponent();
        }
        public object filename;
        public string documentContents;
        public string stringToPrint;
        string fileName;


        System.IO.StreamReader fileToPrint;
        System.Drawing.Font printFont;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAverage_Load(object sender, EventArgs e)
        {
            //定义相应变量

            string connectionString;
            SqlConnection myConnection;

            //源代码   SqlCommand myCommand;

            SqlDataReader myDataReader;
            string sql;

            this.combcoursetime.Items.Clear();
            //设置用户字符串
           connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
            //建立连接。
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //sql = "SELECT * FROM T_Course_Time";
           // SqlCommand myCommand = new SqlCommand(sql, myConnection);
           // myDataReader = myCommand.ExecuteReader();
            //if (myDataReader.HasRows)
           // {
             //   while (myDataReader.Read())
                //{
                    //combcoursetime.Items.Add(myDataReader["coursetimename"].ToString());
               // }
          //  }
           // myDataReader.Close();
           // myConnection.Close();
           // combcoursetime.SelectedIndex = 0;

            //button1.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textxuehao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入要查询学生的学号！");
                textxuehao.Focus();
            }


            else
            {
                this.listView1.Items.Clear();
                string
                                //设置用户字符串

                                connectionString = "Data Source=LAPTOP-V1HUQMV6;Initial Catalog=STMS;Integrated Security=True";
                //建立连接。
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                //读取T_Address表中的所有内容，并填充到ListView中。    
                SqlCommand myCommand = myConnection.CreateCommand();
                string sql = "select coursename,T_Course_Time.coursetimename,T_Course_Student.idofstudent,[name],score ";
                sql += "from T_Student,T_User,T_Course,T_Course_Student,T_Course_Time ";
                sql += "where T_Student.idofuser=T_User.idofuser and T_Course_Student.idofcourse=T_Course.idofcourse and T_Course_Student.idofstudent=T_Student.idofstudent  and T_Course_Time.idofcoursetime=T_Course.idofcoursetime and T_Course_Time.coursetimename='" + combcoursetime.Text + "'and T_Course_Student.idofstudent='" + textxuehao.Text + "'";
                myCommand.CommandText = sql;
                SqlDataReader myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows)
                {
                    while (myDataReader.Read())
                    {

                        ListViewItem item = new ListViewItem(myDataReader["coursename"].ToString());
                        item.SubItems.Add(myDataReader["coursetimename"].ToString());
                        item.SubItems.Add(myDataReader["idofstudent"].ToString());
                        item.SubItems.Add(myDataReader["name"].ToString());
                        item.SubItems.Add(myDataReader["score"].ToString());
                        listView1.Items.Add(item);

                        textBox2.Text = myDataReader["name"].ToString();
                    }
                }
                myDataReader.Close();
                myConnection.Close();

                button1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = listView1.Items.Count;
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                if (listView1.Items[i].SubItems[4].Text.Trim() != string.Empty)
                {
                    sum += Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
                }


            }
            sum /= k;
            textBox4.Text = sum.ToString("f2");
        }
        public void CreateWordFile()
        {
            // public PrintDocument printDocument1 = new PrintDocument();


            Object Nothing = System.Reflection.Missing.Value;
            Directory.CreateDirectory(@"D:\print");  //创建文件所在目录 

            string name = "print_" + DateTime.Now.ToShortTimeString() + ".doc";


            filename = @"D:\print\学期成绩单" + System.DateTime.Now.ToShortDateString() + "日" + DateTime.Now.Hour.ToString() + "时" + DateTime.Now.Minute.ToString() + "分" + DateTime.Now.Second.ToString() + "秒" + ".txt";

            // filename = @"D:\print\print.txt";
            //DateTime.Now.Date.ToString("yyyy-mm-dd")

            int hang = listView1.Items.Count;
            int lie = 5;


            fileName = filename.ToString();
            StreamWriter rw = File.CreateText(fileName);

            string ss;
            //rw.Write(richTextBox1.Text + "\n");

            string kong = "                ";
            rw.WriteLine("课程" + kong + "学期" + kong + "学号" + kong + "学生姓名" + kong + "成绩");

            for (int i = 0; i < hang; i++)
            {
                int k = 0;
                for (int j = 0; j < lie; j++)
                {
                    ss = listView1.Items[i].SubItems[j].Text;
                    rw.Write(ss);
                    switch (j)
                    {
                        case 0: k = 20 - ss.Length * 2; break;
                        case 1: k = 20 - ss.Length * 2; break;
                        case 2: k = 20 - ss.Length; break;
                        case 3: k = 24 - ss.Length * 2; break;
                    }
                    for (int p = 0; p < k; p++) rw.Write(" ");
                }
                rw.WriteLine();
            }
            rw.Flush();
            rw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateWordFile();
            fileToPrint = new System.IO.StreamReader(fileName, Encoding.UTF8);
            printFont = new System.Drawing.Font("宋体", 10);
            printDocument1.Print();
            fileToPrint.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }
    }
}
