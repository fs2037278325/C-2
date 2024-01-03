
namespace Example_1
{
    partial class FormStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textclass = new System.Windows.Forms.TextBox();
            this.textnumber = new System.Windows.Forms.TextBox();
            this.textschool = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textsex = new System.Windows.Forms.TextBox();
            this.textbianhao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liststudent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textclass
            // 
            this.textclass.Location = new System.Drawing.Point(603, 102);
            this.textclass.Name = "textclass";
            this.textclass.Size = new System.Drawing.Size(122, 30);
            this.textclass.TabIndex = 15;
            this.textclass.TextChanged += new System.EventHandler(this.textclass_TextChanged);
            // 
            // textnumber
            // 
            this.textnumber.Location = new System.Drawing.Point(603, 48);
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(122, 30);
            this.textnumber.TabIndex = 14;
            this.textnumber.TextChanged += new System.EventHandler(this.textnumber_TextChanged);
            // 
            // textschool
            // 
            this.textschool.Location = new System.Drawing.Point(372, 102);
            this.textschool.Name = "textschool";
            this.textschool.Size = new System.Drawing.Size(119, 30);
            this.textschool.TabIndex = 13;
            this.textschool.TextChanged += new System.EventHandler(this.textschool_TextChanged);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(372, 41);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(119, 30);
            this.textname.TabIndex = 12;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(146, 165);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(187, 30);
            this.textpassword.TabIndex = 11;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // textsex
            // 
            this.textsex.Location = new System.Drawing.Point(146, 102);
            this.textsex.Name = "textsex";
            this.textsex.Size = new System.Drawing.Size(111, 30);
            this.textsex.TabIndex = 10;
            this.textsex.TextChanged += new System.EventHandler(this.textsex_TextChanged);
            // 
            // textbianhao
            // 
            this.textbianhao.Location = new System.Drawing.Point(146, 38);
            this.textbianhao.Name = "textbianhao";
            this.textbianhao.Size = new System.Drawing.Size(111, 30);
            this.textbianhao.TabIndex = 9;
            this.textbianhao.TextChanged += new System.EventHandler(this.textbianhao_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "密码";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Location = new System.Drawing.Point(678, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "返回";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "班级";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(558, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "学院";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(444, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "性别";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(339, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "学号";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户编号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // liststudent
            // 
            this.liststudent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.liststudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.liststudent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.liststudent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.liststudent.HideSelection = false;
            this.liststudent.Location = new System.Drawing.Point(12, 253);
            this.liststudent.Name = "liststudent";
            this.liststudent.Size = new System.Drawing.Size(776, 294);
            this.liststudent.TabIndex = 1;
            this.liststudent.UseCompatibleStateImageBehavior = false;
            this.liststudent.View = System.Windows.Forms.View.Details;
            this.liststudent.SelectedIndexChanged += new System.EventHandler(this.liststudent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " 用户编号";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " 姓名";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = " 学号";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "  性别";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "  学院";
            this.columnHeader5.Width = 106;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 568);
            this.Controls.Add(this.liststudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormStudent";
            this.Text = "学生管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView liststudent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textclass;
        private System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.TextBox textschool;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textsex;
        private System.Windows.Forms.TextBox textbianhao;
    }
}