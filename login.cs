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
        string id;
        string password;
        
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User person = new User(id, password);
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
