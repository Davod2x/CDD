using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CDD
{
    internal partial class StudentWindow : Form
    {
        private RS rs;
        private Student user;
        private int rowIndex;
        private bool Overridden = false;
        private int index;
        public StudentWindow(ref RS rs, User u)
        {
            this.rs = rs;
            this.user = (Student)u;
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Are you sure you would like to add this course", "Add Course", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    add(false);

            //}
        }

        private void add(bool doAnyway, int index)
        {
            Class cl = rs.classDB.classes[index];
            try
            {
                user.addClass(ref cl, doAnyway);
            }
            catch (InvalidOperationException)
            {
                bool previous = false;
                bool taking = false;
                bool toMany = false;
                bool conflict = false;
                foreach (Class c in user.classes)
                {
                    if (cl == c)
                    {
                        taking = true;
                    }
                    else if (c.StartTime == cl.StartTime)
                    {
                        foreach (char x in cl.Days)
                        {
                            if (c.Days.Contains(x))
                            {
                                conflict = true;
                            }
                        }
                    }
                }
                foreach (Class c in user.classHistory)
                {
                    if (cl == c)
                    {
                        previous = true; break;
                    }
                }
                foreach (Class c in user.classes)
                {
                    if (c == cl)
                    {
                        taking = true; break;
                    }
                }
                int count = 0;
                foreach (Class c in user.classes)
                {
                    count++;
                }
                if (count >= 4)
                {
                    toMany = true;
                }
                if (previous && !taking)

                {

                    MessageBox.Show("Warning: Previously Taken Course");
                    add(true, index);


                }
                else if(conflict && !taking)
                {
                    MessageBox.Show("Warning: Time Conflict");
                    add(true, index);
                }
                else if (taking)
                {
                    DialogResult dialogResult = MessageBox.Show("Could Not Add Course: Already Registered \n" + "Administrator Override?", "Add Course", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        panel1.Visible = true;
                        

                    }

                }
                else if (toMany)
                {
                    DialogResult dialogResult = MessageBox.Show("Could Not Add Course: Overload Error \n" + "Administrator Override?", "Add Course", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        panel1.Visible = true;


                    }
                }
                else if(cl.SeatsAvail == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Could Not Add Course: No Open Seats \n" + "Administrator Override?", "Add Course", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        panel1.Visible = true;


                    }
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "AddCourse1")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to add this course", "Add Course", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    add(false, e.RowIndex);
                    index = e.RowIndex;

                }
            }
        }

        private void viewCoursesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string[] row;
            char[] ch = new char[] { ' ' };
            dataGridView1.Rows.Clear();

            foreach (Class c in rs.classDB.classes)
            {
                row = c.ToString().Split(ch);


                dataGridView1.Rows.Add(row);
            }

            dataGridView2.Visible = false;

            dataGridView1.Visible = true;

            dataGridView3.Visible = false;
            label1.Visible = false;
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "DropCourse")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to drop this course", "Add Course", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    user.removeClass(user.classes[e.RowIndex]);
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                    user.ScheduleApproved = false;


                }
            }

        }

        private void viewSceduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void viewCourseHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Student student = (Student)user;
            string[] row;
            dataGridView3.Rows.Clear();

            foreach (Class c in user.classHistory)
            {
                row = c.ToString().Split(new char[] { ' ' });
                dataGridView3.Rows.Add(row);
            }

            row = new string[] { " ", " ", " ", "Total Credits Earned", "Cumalative GPA" };
            dataGridView3.Rows.Add(row);
            row = new string[] { " ", " ", " ", student.totalCredits().ToString(), student.gpaEarned.ToString() };


            dataGridView3.Rows.Add(row);
            dataGridView2.Visible = false;

            dataGridView1.Visible = false;

            dataGridView3.Visible = true;
            label1.Visible = false;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rs.userDB.users[rs.userDB.users.IndexOf(rs.userDB.GetUser(user.getUsername()))] = user;
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            user.removeClass(user.classes[rowIndex]);
            dataGridView2.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {
            if (user.ScheduleApproved == true)
            {
                label1.Text = "Schedule Approved";
                label1.ForeColor = Color.LimeGreen;
            }
            else
            {
                label1.Text = "Schedule Not Yet Approved";
                label1.ForeColor = Color.Red;
            }
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void advisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = user.Advisor;
        }

        private void viewNextTermScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] row;
            char[] ch = new char[] { ' ' };
            dataGridView1.Visible = false;

            dataGridView3.Visible = false;
            dataGridView2.Rows.Clear();

            foreach (Class c in user.classes)
            {
                row = c.ToString().Split(ch);
                dataGridView2.Rows.Add(row);

            }


            dataGridView2.Visible = true;
            if (user.ScheduleApproved == true)
            {
                label1.Text = "Schedule Approved";
                label1.ForeColor = Color.LimeGreen;
            }
            else
            {
                label1.Text = "Schedule Not Yet Approved";
                label1.ForeColor = Color.Red;
            }


            label1.Visible = true;
        }

        private void viewCurrentTermScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = (Student)user;
            string[] row;
            dataGridView3.Rows.Clear();

            foreach (Class c in user.classHistory)
            {
                if (c.Grade == "N" && c.Term == rs.classDB.CurTerm)
                {
                    row = c.ToString().Split(new char[] { ' ' });
                    dataGridView3.Rows.Add(row);
                }
            }


            dataGridView2.Visible = false;

            dataGridView1.Visible = false;

            dataGridView3.Visible = true;
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox2.Text;
            string password = textBox1.Text;
            if (rs.userDB.validCredentials(Username, password))
            {
                User u;
                u = rs.userDB.GetUser(Username);

                if (u.getStatus() == "admin")
                {
                    add(true, index);
                    MessageBox.Show("Success");
                }
                
            }
            else
            {

                MessageBox.Show("INVALID CREDENTIALS");

            }
            panel1.Visible = false;
        }
    }
}
