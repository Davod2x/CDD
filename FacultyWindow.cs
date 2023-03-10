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
            dataGridView1.Visible = false;
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
    }
}
