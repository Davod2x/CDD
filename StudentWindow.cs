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
            UserDB udb = new UserDB("UserDB.txt");
            ClassDB cdb = new ClassDB("ClassDB.txt", udb);
            //string[] row;
            foreach (Class c in cdb.classes)
            {
                //row = new string[]{ c.Dpt, c.Name, c.Prof, c.Seats.ToString(), c.Credits, c.TimeBlocks + " " + c.Days };
                //dataGridView1.Rows.Add(row);
                //for(int i = 0; i < dataGridView1.ColumnCount; i++)
                //{
                //    dataGridView1.AutoResizeColumn(1);
                //}

                listBox1.Items.Add(c.ToString());
                listBox1.Items.Add('\n');
            }
            label1.Visible = true;
            listBox1.Visible = true;
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
    }
}
