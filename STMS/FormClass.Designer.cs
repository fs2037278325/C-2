
namespace Example_1
{
    partial class FormClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textclass = new System.Windows.Forms.TextBox();
            this.textnumber = new System.Windows.Forms.TextBox();
            this.textschool = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textsex = new System.Windows.Forms.TextBox();
            this.textbianhao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstClass = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textclassnumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lststudent = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textclass
            // 
            this.textclass.Location = new System.Drawing.Point(146, 288);
            this.textclass.Name = "textclass";
            this.textclass.Size = new System.Drawing.Size(122, 30);
            this.textclass.TabIndex = 15;
            // 
            // textnumber
            // 
            this.textnumber.Location = new System.Drawing.Point(146, 126);
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(122, 30);
            this.textnumber.TabIndex = 14;
            this.textnumber.TextChanged += new System.EventHandler(this.textnumber_TextChanged);
            // 
            // textschool
            // 
            this.textschool.Location = new System.Drawing.Point(146, 244);
            this.textschool.Name = "textschool";
            this.textschool.Size = new System.Drawing.Size(122, 30);
            this.textschool.TabIndex = 13;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(146, 76);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(122, 30);
            this.textname.TabIndex = 12;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(146, 345);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(187, 30);
            this.textpassword.TabIndex = 11;
            // 
            // textsex
            // 
            this.textsex.Location = new System.Drawing.Point(146, 183);
            this.textsex.Name = "textsex";
            this.textsex.Size = new System.Drawing.Size(122, 30);
            this.textsex.TabIndex = 10;
            // 
            // textbianhao
            // 
            this.textbianhao.Location = new System.Drawing.Point(146, 38);
            this.textbianhao.Name = "textbianhao";
            this.textbianhao.Size = new System.Drawing.Size(122, 30);
            this.textbianhao.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "班级";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(111, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "学院";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户编号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textclass);
            this.groupBox1.Controls.Add(this.textnumber);
            this.groupBox1.Controls.Add(this.textschool);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.textpassword);
            this.groupBox1.Controls.Add(this.textsex);
            this.groupBox1.Controls.Add(this.textbianhao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 471);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // lstClass
            // 
            this.lstClass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstClass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstClass.HideSelection = false;
            this.lstClass.Location = new System.Drawing.Point(6, 25);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(403, 581);
            this.lstClass.TabIndex = 3;
            this.lstClass.UseCompatibleStateImageBehavior = false;
            this.lstClass.View = System.Windows.Forms.View.Details;
            this.lstClass.SelectedIndexChanged += new System.EventHandler(this.liststudent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "  班级";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " 学号";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "   学生姓名";
            this.columnHeader3.Width = 156;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(422, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 411);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstClass);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(408, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 606);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "班级学生列表";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textclassnumber);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 129);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "班级查询";
            // 
            // textclassnumber
            // 
            this.textclassnumber.Location = new System.Drawing.Point(105, 58);
            this.textclassnumber.Name = "textclassnumber";
            this.textclassnumber.Size = new System.Drawing.Size(131, 28);
            this.textclassnumber.TabIndex = 2;
            this.textclassnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "班级";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lststudent);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(12, 615);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(803, 165);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "当前学生信息";
            // 
            // lststudent
            // 
            this.lststudent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lststudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lststudent.HideSelection = false;
            this.lststudent.Location = new System.Drawing.Point(6, 28);
            this.lststudent.Name = "lststudent";
            this.lststudent.Size = new System.Drawing.Size(791, 131);
            this.lststudent.TabIndex = 0;
            this.lststudent.UseCompatibleStateImageBehavior = false;
            this.lststudent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = " 用户编号";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "  姓名";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "  学号";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "  性别";
            this.columnHeader7.Width = 78;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "  学院";
            this.columnHeader8.Width = 87;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "  班级";
            this.columnHeader9.Width = 75;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 792);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormClass";
            this.Text = "班级管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textclass;
        private System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.TextBox textschool;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textsex;
        private System.Windows.Forms.TextBox textbianhao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstClass;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textclassnumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lststudent;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}