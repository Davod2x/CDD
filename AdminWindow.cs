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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
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
            UserDB udb = new UserDB("UserDB.txt","CourseHistory.txt");
            ClassDB cdb = new ClassDB("ClassDB.txt", udb);
            foreach (Class c in cdb.classes)
            {
                listBox1.Items.Add(c.ToString());
            }
            listBox1.Visible = true;
        }
    }
}
