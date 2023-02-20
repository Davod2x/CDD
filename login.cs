﻿using System;
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
        public static string Username { get; set; }
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

        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string[] row;
            char[] ch = new char[] { ' ' };
            foreach (Class c in rs.classDB.classes)
            {
                row = c.ToString().Split(ch);


                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Visible = true;
            button2.Visible = true;
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
    }
}
