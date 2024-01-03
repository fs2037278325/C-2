using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChange frm = new FormChange();
            frm.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //创建登录窗体，并以模式窗体显示模式显示之。
            FormLogin formlogin = new FormLogin();
            formlogin.ShowDialog();
            //this.修改密码ToolStripMenuItem.Enabled = false;

            //检测用户登录状态，如为登录成功，则在状态栏显示相应信息，如不成功则关闭程序
            if (formlogin.IsLogin)
            {
                switch (formlogin.type)
                {
                    case 0:
                        {
                            this.成绩查询ToolStripMenuItem.Enabled = false;
                            this.成绩录入ToolStripMenuItem.Enabled = false;
                            this.学生查找ToolStripMenuItem.Enabled = false;
                            this.统计分析ToolStripMenuItem.Enabled = false;
                           
                            break;
                        }

                    case 1:
                        {
                            this.学生管理ToolStripMenuItem.Enabled = false;
                            this.教师管理ToolStripMenuItem.Enabled = false;
                            this.成绩查询ToolStripMenuItem.Enabled = false;
                            this.成绩录入ToolStripMenuItem.Enabled = false;
                            this.班级管理ToolStripMenuItem.Enabled = false;
                         
                            break;
                        }
                    case 2:
                        {
                            this.学生管理ToolStripMenuItem.Enabled = false;
                            this.教师管理ToolStripMenuItem.Enabled = false;
                          
                            this.成绩录入ToolStripMenuItem.Enabled = false;
                            this.学生查找ToolStripMenuItem.Enabled = false;
                            this.统计分析ToolStripMenuItem.Enabled = false;
                            this.班级管理ToolStripMenuItem.Enabled = false;
                            break;


                        }
                }
                this.toolStripStatusLabel1.Text = "当前登录用户：" + formlogin.CurrentUser.Username;
                this.toolStripStatusLabel2.Text = "登录时间： " + System.DateTime.Now.ToString();

            }
            else
            {
                this.Close();
            }
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormStudent frm = new FormStudent();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void 教师管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormTeacher frm = new FormTeacher();
           // frm.MdiParent = this;
            frm.Show();
        }

        private void 班级管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormClass frm = new FormClass();
           // frm.MdiParent = this;
            frm.Show();
        }

   

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormScore frm = new FormScore();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 学生查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormStudent frm = new FormStudent();
           // frm.MdiParent = this;
            frm.Show();
        }

        private void 平均成绩计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormAverage frm = new FormAverage();
            //frm.MdiParent = this;
            frm.Show();

        }




       

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormScanScore frm = new FormScanScore();
           // frm.MdiParent = this;
            frm.Show();
        }

        private void 修改密码ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormChange frm = new FormChange();
            //frm.MdiParent = this;
            frm.Show();
        }
        private void 锁定系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            FormLock frm = new FormLock();
           // frm.MdiParent = this;
            frm.Show();
        }
    }
}

