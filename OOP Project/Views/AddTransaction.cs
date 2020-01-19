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
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                var myForm = new Views.ErrorPop();
                myForm.Show();
                return;
            }
            Transaction t = new Transaction(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text);
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.makeTransactions(t);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.saveConsultant();
        }
    }
}
