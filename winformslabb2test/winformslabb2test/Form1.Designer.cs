namespace winformslabb2test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NewPerson = new System.Windows.Forms.Button();
            this.NewCourse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.ListBox();
            this.teacherList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.NewPerson);
            this.panel1.Controls.Add(this.NewCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 582);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NewPerson
            // 
            this.NewPerson.Location = new System.Drawing.Point(0, 132);
            this.NewPerson.Name = "NewPerson";
            this.NewPerson.Size = new System.Drawing.Size(164, 55);
            this.NewPerson.TabIndex = 2;
            this.NewPerson.Text = "New person";
            this.NewPerson.UseVisualStyleBackColor = true;
            this.NewPerson.Click += new System.EventHandler(this.newPerson_Click);
            // 
            // NewCourse
            // 
            this.NewCourse.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCourse.Location = new System.Drawing.Point(0, 71);
            this.NewCourse.Name = "NewCourse";
            this.NewCourse.Size = new System.Drawing.Size(164, 55);
            this.NewCourse.TabIndex = 1;
            this.NewCourse.Text = "New course";
            this.NewCourse.UseVisualStyleBackColor = true;
            this.NewCourse.Click += new System.EventHandler(this.newCourse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 586);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(709, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 381);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(292, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Teacher";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(709, 464);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(292, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "Apply Grade";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(170, 12);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(211, 550);
            this.studentList.TabIndex = 8;
            // 
            // teacherList
            // 
            this.teacherList.FormattingEnabled = true;
            this.teacherList.Location = new System.Drawing.Point(405, 12);
            this.teacherList.Name = "teacherList";
            this.teacherList.Size = new System.Drawing.Size(211, 550);
            this.teacherList.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 582);
            this.Controls.Add(this.teacherList);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NewPerson;
        private System.Windows.Forms.Button NewCourse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.ListBox teacherList;
    }
}

