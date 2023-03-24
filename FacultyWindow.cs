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
    internal partial class FacultyWindow : Form
    {
        protected RS rs;
        protected User user;
        public FacultyWindow(ref RS rs, User user)
        {
            this.rs = rs;
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<string> r = new List<string>();
            string[] row;
            char[] ch = new char[] { ' ' };
            foreach (Class c in rs.classDB.classes)
            {
                row = c.ToString().Split(ch);


                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Visible = true;
        }

   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] row;
            char[] ch = new char[] { ' ' };
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            //button2.Visible = false;
            //dataGridView3.Visible = false;
            dataGridView1.Rows.Clear();

            foreach (Class c in user.classes)
            {
                row = c.ToString().Split(ch);


                dataGridView1.Rows.Add(row);
            }


            dataGridView1.Visible = true;
        }

        private void FacultyWindow_Load(object sender, EventArgs e)
        {

        }

        private void viewEnrolledStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            dataGridView2.Rows.Clear();
            string[] row;
            foreach (Class c in user.classes)
            {
                if (c.Students.Count > 0)
                {
                    row = c.ToString().Split(' ');
                    dataGridView2.Rows.Add(row);
                    foreach (Student s in c.Students)
                    {
                        row = new string[] { "Students Enrolled", " ", " ", " ", " ", " ", " " };
                        dataGridView2.Rows.Add(row);
                        row = new string[] { s.ToString(), " ", " ", " ", " ", " ", " " };
                        dataGridView2.Rows.Add(row);
                    }
                }
            }
            dataGridView2.Visible = true;
        }

        private void viewAdviseeSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty f = (Faculty)user;
            dataGridView1.Visible=false;
            dataGridView2.Visible=false;
            dataGridView3.Rows.Clear();
            string[] row;
            foreach(Student s in f.Advisees)
            {
                row = s.ToString().Split(' ') ;
                dataGridView3.Rows.Add(row);
                foreach(Class c in s.classes)
                {
                    row = c.ToString().Split(' ');
                    dataGridView3.Rows.Add(row);
                }
            }
            dataGridView3.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
