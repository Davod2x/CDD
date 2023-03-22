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
        private RS rs;
        User user;
        int rowIndex;
        public login()
            
        {
            this.rs= new RS();
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
                    FacultyWindow window = new FacultyWindow(ref rs, user);
                    window.Show();
                    
                }
                else if (user.getStatus() == "admin")
                {
                    AdminWindow window = new AdminWindow();
                    window.Show();
                }
                else
                {
                    StudentWindow window = new StudentWindow(ref rs, user);
                    window.Show();
                    

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
            Username = textBox2.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
           
        }






        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void viewSceduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void button3_Click(object sender, EventArgs e)
        {


            


        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewCourseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

