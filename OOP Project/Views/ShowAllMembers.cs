using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class ShowAllMembers : Form
    {
        public ShowAllMembers()
        {
            InitializeComponent();
            FileManager fm = new FileManager();
            dataGridView1.DataSource = fm.ReadAll<Member>(Constants.Constants.memberFileName);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
