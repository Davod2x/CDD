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
    internal partial class AdminWindow : Form
    {
        private RS rs;
        private Admin user;
        public AdminWindow(ref RS rs, User user)
        {
            this.rs = rs;
            this.user = (Admin)user;   
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserDB udb = new UserDB("UserDB.txt","CourseHistory.txt");
            //ClassDB cdb = new ClassDB("ClassDB.txt", udb);
            //foreach (Class c in cdb.classes)
            //{
            //    listBox1.Items.Add(c.ToString());
            //}
            //listBox1.Visible = true;
        }

        private void viewOfferedCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.DataSource = rs.classDB.classes;
            dataGridView2.Visible = true;
            //string[] row;
            //char[] ch = new char[] { ' ' };
            //dataGridView2.Rows.Clear();

            //foreach (Class c in rs.classDB.classes)
            //{
            //    row = c.ToString().Split(ch);


            //    dataGridView1.Rows.Add(row);
            //}
        }

        private void studentViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            string[] row;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[4].HeaderText = "Advisor";
            foreach(User u in rs.userDB.users)
            {
                if (u.getStatus() == "student")
                {
                    row = u.ToString().Split(' ');
                    dataGridView1.Rows.Add(row);
                }
            }
            dataGridView1.Visible = true;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            User s = rs.userDB.GetUser((string)dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            
            Student st = (Student)s;
            Faculty f = (Faculty)rs.userDB.GetUser(st.Advisor);
            f.removeAdvisee(st);
            if (e.ColumnIndex == 4)
            {
                st.Advisor = (string) dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            }
            Faculty newAdvisor = (Faculty)rs.userDB.GetUser(st.Advisor);
            newAdvisor.addStudent(st);
            rs.userDB.users[rs.userDB.users.IndexOf(s)] = st;
            rs.userDB.users[rs.userDB.users.IndexOf(f)] = f;
            rs.userDB.users[rs.userDB.users.IndexOf(newAdvisor)] = newAdvisor;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Login")
            {
                User u = rs.userDB.GetUser((string)dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                if (u.getStatus() == "student")
                {
                    StudentWindow sWindow = new StudentWindow(ref rs, u);
                    sWindow.Show();
                }
                else
                {
                    FacultyWindow fWindow = new FacultyWindow(ref rs, u);
                    fWindow.Show();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "RemoveUser")
            {
                rs.userDB.removeUser(rs.userDB.GetUser((string)dataGridView1.Rows[e.RowIndex].Cells[3].Value));
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void facultyViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible=false;
            string[] row;
            dataGridView1.Rows.Clear();
            foreach (User u in rs.userDB.users)
            {
                if (u.getStatus() == "faculty")
                {
                    row = u.ToString().Split(' ');
                    dataGridView1.Rows.Add(row);
                }
            }
            dataGridView1.Visible = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Remove")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to remove this course", "Add Course", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    rs.classDB.removeClass(e.RowIndex);
                }
            }
            dataGridView2.Update();
        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //rs.classDB.editClass(e.RowIndex, dataGridView2.Columns[e.ColumnIndex].Name, dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            Class c = new Class((string)dataGridView2.Rows[e.RowIndex].Cells[3].Value, (string)dataGridView2.Rows[e.RowIndex].Cells[4].Value, (string)dataGridView2.Rows[e.RowIndex].Cells[5].Value, (string)dataGridView2.Rows[e.RowIndex].Cells[2].Value,
               (string)dataGridView2.Rows[e.RowIndex].Cells[6].Value, (string)dataGridView2.Rows[e.RowIndex].Cells[7].Value, (string)dataGridView2.Rows[e.RowIndex].Cells[8].Value, (string)dataGridView2.Rows[e.RowIndex].Cells[12].Value,
               (string)dataGridView2.Rows[e.RowIndex].Cells[11].Value, (string)dataGridView2.Rows[e.RowIndex].Cells[10].Value);
            rs.classDB.classes[e.RowIndex] = c;
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
