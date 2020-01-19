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
    public partial class AddConsultant : Form
    {
        public AddConsultant()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                var myForm = new Views.ErrorPop();
                myForm.Show();
                return;
            }
            Consultant c = new Consultant(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, Convert.ToInt32(textBox7.Text), textBox8.Text);
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.addConsultant(c);
        }

        private void save_click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.saveConsultant();
        }
    }
}
