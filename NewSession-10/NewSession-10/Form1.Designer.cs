﻿namespace NewSession_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LdStudents = new System.Windows.Forms.Label();
            this.LbCourse = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LbScheduledCourses = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.LbGrades = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClmStID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmStRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmStCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmGradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSceduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmScCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmScProfID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCallendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmStID,
            this.ClmName,
            this.ClmSurname,
            this.ClmAge,
            this.ClmStRegistrationNumber,
            this.ClmStCourses});
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(814, 98);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LdStudents
            // 
            this.LdStudents.AutoSize = true;
            this.LdStudents.Location = new System.Drawing.Point(12, 166);
            this.LdStudents.Name = "LdStudents";
            this.LdStudents.Size = new System.Drawing.Size(66, 20);
            this.LdStudents.TabIndex = 1;
            this.LdStudents.Text = "Students";
            this.LdStudents.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbCourse
            // 
            this.LbCourse.AutoSize = true;
            this.LbCourse.Location = new System.Drawing.Point(12, 291);
            this.LbCourse.Name = "LbCourse";
            this.LbCourse.Size = new System.Drawing.Size(60, 20);
            this.LbCourse.TabIndex = 3;
            this.LbCourse.Text = "Courses";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCourseID,
            this.ClmCourseCode,
            this.ClmSubject});
            this.dataGridView2.Location = new System.Drawing.Point(12, 314);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(814, 98);
            this.dataGridView2.TabIndex = 2;
            // 
            // LbScheduledCourses
            // 
            this.LbScheduledCourses.AutoSize = true;
            this.LbScheduledCourses.Location = new System.Drawing.Point(12, 540);
            this.LbScheduledCourses.Name = "LbScheduledCourses";
            this.LbScheduledCourses.Size = new System.Drawing.Size(129, 20);
            this.LbScheduledCourses.TabIndex = 7;
            this.LbScheduledCourses.Text = "ScheduledCourses";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 563);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(814, 0);
            this.dataGridView3.TabIndex = 6;
            // 
            // LbGrades
            // 
            this.LbGrades.AutoSize = true;
            this.LbGrades.Location = new System.Drawing.Point(12, 415);
            this.LbGrades.Name = "LbGrades";
            this.LbGrades.Size = new System.Drawing.Size(55, 20);
            this.LbGrades.TabIndex = 5;
            this.LbGrades.Text = "Grades";
            this.LbGrades.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmGradeID,
            this.ClmStuID,
            this.ClmGrade});
            this.dataGridView4.Location = new System.Drawing.Point(12, 438);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(814, 98);
            this.dataGridView4.TabIndex = 4;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmSceduleID,
            this.ClmScCourseID,
            this.ClmScProfID,
            this.ClmCallendar});
            this.dataGridView5.Location = new System.Drawing.Point(12, 563);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 29;
            this.dataGridView5.Size = new System.Drawing.Size(814, 98);
            this.dataGridView5.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(126, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "UNIVERSITY";
            // 
            // ClmStID
            // 
            this.ClmStID.HeaderText = "ID";
            this.ClmStID.MinimumWidth = 6;
            this.ClmStID.Name = "ClmStID";
            this.ClmStID.ReadOnly = true;
            this.ClmStID.Width = 125;
            // 
            // ClmName
            // 
            this.ClmName.HeaderText = "Name";
            this.ClmName.MinimumWidth = 6;
            this.ClmName.Name = "ClmName";
            this.ClmName.Width = 125;
            // 
            // ClmSurname
            // 
            this.ClmSurname.HeaderText = "Surname";
            this.ClmSurname.MinimumWidth = 6;
            this.ClmSurname.Name = "ClmSurname";
            this.ClmSurname.Width = 125;
            // 
            // ClmAge
            // 
            this.ClmAge.HeaderText = "Age";
            this.ClmAge.MinimumWidth = 6;
            this.ClmAge.Name = "ClmAge";
            this.ClmAge.Width = 125;
            // 
            // ClmStRegistrationNumber
            // 
            this.ClmStRegistrationNumber.HeaderText = "Registration Number";
            this.ClmStRegistrationNumber.MinimumWidth = 6;
            this.ClmStRegistrationNumber.Name = "ClmStRegistrationNumber";
            this.ClmStRegistrationNumber.Width = 125;
            // 
            // ClmStCourses
            // 
            this.ClmStCourses.HeaderText = "Courses";
            this.ClmStCourses.MinimumWidth = 6;
            this.ClmStCourses.Name = "ClmStCourses";
            this.ClmStCourses.Width = 125;
            // 
            // ClmCourseID
            // 
            this.ClmCourseID.HeaderText = "ID";
            this.ClmCourseID.MinimumWidth = 6;
            this.ClmCourseID.Name = "ClmCourseID";
            this.ClmCourseID.ReadOnly = true;
            this.ClmCourseID.Width = 125;
            // 
            // ClmCourseCode
            // 
            this.ClmCourseCode.HeaderText = "Code";
            this.ClmCourseCode.MinimumWidth = 6;
            this.ClmCourseCode.Name = "ClmCourseCode";
            this.ClmCourseCode.Width = 125;
            // 
            // ClmSubject
            // 
            this.ClmSubject.HeaderText = "Subject";
            this.ClmSubject.MinimumWidth = 6;
            this.ClmSubject.Name = "ClmSubject";
            this.ClmSubject.Width = 125;
            // 
            // ClmGradeID
            // 
            this.ClmGradeID.HeaderText = "ID";
            this.ClmGradeID.MinimumWidth = 6;
            this.ClmGradeID.Name = "ClmGradeID";
            this.ClmGradeID.ReadOnly = true;
            this.ClmGradeID.Width = 125;
            // 
            // ClmStuID
            // 
            this.ClmStuID.HeaderText = "Student ID";
            this.ClmStuID.MinimumWidth = 6;
            this.ClmStuID.Name = "ClmStuID";
            this.ClmStuID.ReadOnly = true;
            this.ClmStuID.Width = 125;
            // 
            // ClmGrade
            // 
            this.ClmGrade.HeaderText = "Grade";
            this.ClmGrade.MinimumWidth = 6;
            this.ClmGrade.Name = "ClmGrade";
            this.ClmGrade.ReadOnly = true;
            this.ClmGrade.Width = 125;
            // 
            // ClmSceduleID
            // 
            this.ClmSceduleID.HeaderText = "ID";
            this.ClmSceduleID.MinimumWidth = 6;
            this.ClmSceduleID.Name = "ClmSceduleID";
            this.ClmSceduleID.Width = 125;
            // 
            // ClmScCourseID
            // 
            this.ClmScCourseID.HeaderText = "Course ID";
            this.ClmScCourseID.MinimumWidth = 6;
            this.ClmScCourseID.Name = "ClmScCourseID";
            this.ClmScCourseID.Width = 125;
            // 
            // ClmScProfID
            // 
            this.ClmScProfID.HeaderText = "Professor ID";
            this.ClmScProfID.MinimumWidth = 6;
            this.ClmScProfID.Name = "ClmScProfID";
            this.ClmScProfID.Width = 125;
            // 
            // ClmCallendar
            // 
            this.ClmCallendar.HeaderText = "Callendar";
            this.ClmCallendar.MinimumWidth = 6;
            this.ClmCallendar.Name = "ClmCallendar";
            this.ClmCallendar.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.LbScheduledCourses);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.LbGrades);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.LbCourse);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.LdStudents);
            this.Controls.Add(this.dataGridView1);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label LdStudents;
        private Label LbCourse;
        private DataGridView dataGridView2;
        private Label LbScheduledCourses;
        private DataGridView dataGridView3;
        private Label LbGrades;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridViewTextBoxColumn ClmStID;
        private DataGridViewTextBoxColumn ClmName;
        private DataGridViewTextBoxColumn ClmSurname;
        private DataGridViewTextBoxColumn ClmAge;
        private DataGridViewTextBoxColumn ClmStRegistrationNumber;
        private DataGridViewTextBoxColumn ClmStCourses;
        private DataGridViewTextBoxColumn ClmCourseID;
        private DataGridViewTextBoxColumn ClmCourseCode;
        private DataGridViewTextBoxColumn ClmSubject;
        private DataGridViewTextBoxColumn ClmGradeID;
        private DataGridViewTextBoxColumn ClmStuID;
        private DataGridViewTextBoxColumn ClmGrade;
        private DataGridViewTextBoxColumn ClmSceduleID;
        private DataGridViewTextBoxColumn ClmScCourseID;
        private DataGridViewTextBoxColumn ClmScProfID;
        private DataGridViewTextBoxColumn ClmCallendar;
    }
}