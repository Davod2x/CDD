namespace CDD
{
    partial class AdminWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewOfferedCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewButtonColumn();
            this.classDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOfferedCoursesToolStripMenuItem,
            this.studentViewToolStripMenuItem,
            this.facultyViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2127, 45);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewOfferedCoursesToolStripMenuItem
            // 
            this.viewOfferedCoursesToolStripMenuItem.Name = "viewOfferedCoursesToolStripMenuItem";
            this.viewOfferedCoursesToolStripMenuItem.Size = new System.Drawing.Size(293, 41);
            this.viewOfferedCoursesToolStripMenuItem.Text = "View Offered Courses";
            this.viewOfferedCoursesToolStripMenuItem.Click += new System.EventHandler(this.viewOfferedCoursesToolStripMenuItem_Click);
            // 
            // studentViewToolStripMenuItem
            // 
            this.studentViewToolStripMenuItem.Name = "studentViewToolStripMenuItem";
            this.studentViewToolStripMenuItem.Size = new System.Drawing.Size(195, 41);
            this.studentViewToolStripMenuItem.Text = "Student View";
            this.studentViewToolStripMenuItem.Click += new System.EventHandler(this.studentViewToolStripMenuItem_Click);
            // 
            // facultyViewToolStripMenuItem
            // 
            this.facultyViewToolStripMenuItem.Name = "facultyViewToolStripMenuItem";
            this.facultyViewToolStripMenuItem.Size = new System.Drawing.Size(186, 41);
            this.facultyViewToolStripMenuItem.Text = "Faculty View";
            this.facultyViewToolStripMenuItem.Click += new System.EventHandler(this.facultyViewToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.UName,
            this.Password,
            this.Login});
            this.dataGridView1.Location = new System.Drawing.Point(39, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1732, 509);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 11;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 225;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.MinimumWidth = 11;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Width = 225;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 11;
            this.LastName.Name = "LastName";
            this.LastName.Width = 225;
            // 
            // UName
            // 
            this.UName.HeaderText = "Username";
            this.UName.MinimumWidth = 11;
            this.UName.Name = "UName";
            this.UName.Width = 225;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 11;
            this.Password.Name = "Password";
            this.Password.Width = 225;
            // 
            // Login
            // 
            this.Login.HeaderText = "";
            this.Login.MinimumWidth = 11;
            this.Login.Name = "Login";
            this.Login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Login.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Login.Text = "Login";
            this.Login.UseColumnTextForButtonValue = true;
            this.Login.Width = 225;
            // 
            // classDBBindingSource
            // 
            this.classDBBindingSource.DataSource = typeof(CDD.ClassDB);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(70, 639);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 92;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(1412, 309);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2127, 1160);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewOfferedCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyViewToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn Login;
        private System.Windows.Forms.BindingSource classDBBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}