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
        UserDB db = new UserDB("UserDB.txt");
        User user;
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.validCredentials(username, password)){
                user = db.GetUser(username);
            }
          
            if(user.getStatus() == "faculty")
            {
                FacultyWindow window = new FacultyWindow();
                window.Show();
            }
            else if(user.getStatus() == "admin")
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
