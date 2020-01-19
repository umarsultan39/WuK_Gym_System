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
    public partial class AddEquipment : Form
    {
        public AddEquipment()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                var myForm = new Views.ErrorPop();
                myForm.Show();
                return;
            }

            Equipment eq = new Equipment(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.addEquipment(eq);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.saveConsultant();
        }
    }
}
