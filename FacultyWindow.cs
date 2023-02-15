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
    public partial class FacultyWindow : Form
    {
        public FacultyWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDB udb = new UserDB("UserDB.txt");
            ClassDB cdb = new ClassDB("ClassDB.txt", udb);
            List<string> r = new List<string>();
            string[] row;
            char[] ch = new char[] { ' ' };
            foreach (Class c in cdb.classes)
            {
                row = c.ToString().Split(ch);


                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Visible = true;
        }

   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
