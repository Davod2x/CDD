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
    
    public partial class login : Form
    {
        string username;
        string password;
        RS rs = new RS();
        User user;
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rs.userDB.validCredentials(username, password))
            {
                user = rs.userDB.GetUser(username);
                if (user.getStatus() == "faculty")
                {
                    FacultyWindow window = new FacultyWindow();
                    window.Show();
                }
                else if (user.getStatus() == "admin")
                {
                    AdminWindow window = new AdminWindow();
                    window.Show();
                }
                else
                {
                    StudentWindow window = new StudentWindow();
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
            username= textBox2.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            password= textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
