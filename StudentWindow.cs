using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDD
{
    internal partial class StudentWindow : Form
    {
        private RS rs;
        private Student user;
        private int rowIndex;
        public StudentWindow(ref RS rs, User u)
        {
            this.rs= rs;
            this.user = (Student)u;
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to add this course", "Add Course", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                add(false);

            }
        }
        
        private void add(bool doAnyway)
        {
            try
            {
                user.addClass(rs.classDB.classes[rowIndex], doAnyway);
            }
            catch (InvalidOperationException)
            {
                bool previous = false;
                bool taking = false;
                foreach (Class c in user.classHistory)
                {
                    if (rs.classDB.classes[rowIndex] == c)
                    {
                        previous = true; break;
                    }
                }
                foreach (Class c in user.classes)
                {
                    if (rs.classDB.classes.Contains(c))
                    {
                        taking = true; break;
                    }
                }
                if (previous && !taking)
                {

                    DialogResult dialogResult2 = MessageBox.Show("You have previously taken this course. Would you like to retake it?", "Add Course", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        add(true);
                    }


                }
                else
                {
                    MessageBox.Show("Could not add course: already taking or time conflict");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           rowIndex = e.RowIndex;
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
            button3.Visible = false;
            dataGridView1.Visible = true;
            button2.Visible = true;
            dataGridView3.Visible = false;
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex= e.RowIndex;
        }

        private void viewSceduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string[] row;
            char[] ch = new char[] { ' ' };
            dataGridView1.Visible = false;
            button2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView2.Rows.Clear();

            foreach (Class c in user.classes)
            {
                row = c.ToString().Split(ch);


                dataGridView2.Rows.Add(row);
            }


            dataGridView2.Visible = true;
            button3.Visible = true;
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
            button3.Visible = false;
            dataGridView1.Visible = false;
            button2.Visible = false;
            dataGridView3.Visible = true;
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
    }
}
