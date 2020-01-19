using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project.Views
{
    public partial class AddDiet : Form
    {
        public AddDiet()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                var myForm = new Views.ErrorPop();
                myForm.Show();
                return;
            }

            Diet d = new Diet(Convert.ToInt32(textBox1.Text), textBox2.Text);
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.assignDiet(d);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.saveMember();
        }
    }
}
