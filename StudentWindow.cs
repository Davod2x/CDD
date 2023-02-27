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
    public partial class StudentWindow : Form
    {
        Class c;
        login l = new login();
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDB udb = new UserDB("UserDB.txt", "CourseHistory.txt");
            ClassDB cdb = new ClassDB("ClassDB.txt", udb);
            
            string[] row;
            char[] ch = new char[] { ' ' };
            foreach (Class c in cdb.classes)
            {
                row = c.ToString().Split(ch);
              

                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            //c = new Class(row.Cells[0].ToString(), row.Cells[1].ToString(), row.Cells[2].ToString(), row.Cells[3].ToString(), row.Cells[4].ToString(), row.Cells[5].ToString(), row.Cells[6].ToString());

        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDB udb = new UserDB("UserDB.txt","CourseHistory.txt");
            ClassDB cdb = new ClassDB("ClassDB.txt", udb);

            string[] row;
            char[] ch = new char[] { ' ' };
            foreach (Class c in cdb.classes)
            {
                row = c.ToString().Split(ch);


                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Visible = true;
        }

        private void viewSceduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            
            
        }

        private void addDropCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //l.user.addClass(c);
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewCourseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
