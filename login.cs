using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CDD
{
    
    public partial class login : Form
    {
        public static string Username { get; set; }
        string password;
        RS rs = new RS();
        User user;
        int rowIndex;
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rs.userDB.validCredentials(Username, password))
            {
                user = rs.userDB.GetUser(Username);
                if (user.getStatus() == "faculty")
                {
                    FacultyWindow window = new FacultyWindow();
                    panel1.Visible = false;
                }
                else if (user.getStatus() == "admin")
                {
                    AdminWindow window = new AdminWindow();
                    window.Show();
                }
                else
                {
                    pictureBox1.Visible= false;
                    label3.Text = "Welcome " + user.getfName();
                    label3.Visible = true;
                    panel1.Visible=false;
                    menuStrip1.Visible = true;
                    
                }
            }
            else
            {
                textBox3.Visible = true;
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            Username= textBox2.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            password= textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            
        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string[] row;
            char[] ch = new char[] { ' ' };
            if (dataGridView1.Rows.Count < rs.classDB.classes.Count)
            {
                foreach (Class c in rs.classDB.classes)
                {
                    row = c.ToString().Split(ch);


                    dataGridView1.Rows.Add(row);
                }
            }
            dataGridView2.Visible= false;
            button3.Visible=false;
            dataGridView1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to add this course", "Add Course", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    user.addClass(rs.classDB.classes[rowIndex]);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Could not add course: already taking or time conflict");
                }
              
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void viewSceduleToolStripMenuItem_Click(object sender, EventArgs e)
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
            button3.Visible= true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex= e.RowIndex;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex= e.RowIndex;
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[rowIndex].Visible = false;
            user.removeClass(user.classes[rowIndex]);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            menuStrip1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            panel1.Visible = true;
            pictureBox1.Visible = true;
            label3.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            rs.userDB.users[rs.userDB.users.IndexOf(rs.userDB.GetUser(user.getUsername()))] = user;
        }

        private void viewCourseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] row;
            if (dataGridView3.Rows.Count < user.classHistory.Count)
            {
                foreach (Class c in user.classHistory)
                {
                    row = c.ToString().Split(new char[] {' '});
                    dataGridView3.Rows.Add(row);
                }
            }
            dataGridView2.Visible = false;
            button3.Visible = false;
            dataGridView1.Visible = false;
            button2.Visible = false;
            dataGridView3.Visible = true;
        }
    }
}
