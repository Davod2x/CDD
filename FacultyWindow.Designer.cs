﻿namespace CDD
{
    partial class FacultyWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEnrolledStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdviseeSchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.CourseName,
            this.Instructor,
            this.Credits,
            this.SeatsAvailable,
            this.Days,
            this.Time});
            this.dataGridView1.Location = new System.Drawing.Point(13, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1951, 405);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 11;
            this.Class.Name = "Class";
            this.Class.Width = 122;
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 11;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 194;
            // 
            // Instructor
            // 
            this.Instructor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Instructor.HeaderText = "instructor";
            this.Instructor.MinimumWidth = 11;
            this.Instructor.Name = "Instructor";
            this.Instructor.Width = 160;
            // 
            // Credits
            // 
            this.Credits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Credits.HeaderText = "Credits";
            this.Credits.MinimumWidth = 11;
            this.Credits.Name = "Credits";
            this.Credits.Width = 139;
            // 
            // SeatsAvailable
            // 
            this.SeatsAvailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SeatsAvailable.HeaderText = "Seats Available";
            this.SeatsAvailable.MinimumWidth = 11;
            this.SeatsAvailable.Name = "SeatsAvailable";
            this.SeatsAvailable.Width = 209;
            // 
            // Days
            // 
            this.Days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 11;
            this.Days.Name = "Days";
            this.Days.Width = 115;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 11;
            this.Time.Name = "Time";
            this.Time.Width = 118;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewScheduleToolStripMenuItem,
            this.viewEnrolledStudentsToolStripMenuItem,
            this.viewAdviseeSchedulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 45);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(211, 41);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            this.viewScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // viewEnrolledStudentsToolStripMenuItem
            // 
            this.viewEnrolledStudentsToolStripMenuItem.Name = "viewEnrolledStudentsToolStripMenuItem";
            this.viewEnrolledStudentsToolStripMenuItem.Size = new System.Drawing.Size(311, 41);
            this.viewEnrolledStudentsToolStripMenuItem.Text = "View Enrolled Students";
            this.viewEnrolledStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewEnrolledStudentsToolStripMenuItem_Click);
            // 
            // viewAdviseeSchedulesToolStripMenuItem
            // 
            this.viewAdviseeSchedulesToolStripMenuItem.Name = "viewAdviseeSchedulesToolStripMenuItem";
            this.viewAdviseeSchedulesToolStripMenuItem.Size = new System.Drawing.Size(321, 41);
            this.viewAdviseeSchedulesToolStripMenuItem.Text = "View Advisee Schedules";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(13, 729);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 92;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(1951, 405);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Class";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Course Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 194;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "instructor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Credits";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 139;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Seats Available";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 209;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Days";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 115;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Time";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 118;
            // 
            // FacultyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2064, 1219);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FacultyWindow";
            this.Text = "FacultyWindow";
            this.Load += new System.EventHandler(this.FacultyWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEnrolledStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAdviseeSchedulesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}