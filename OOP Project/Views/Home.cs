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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            FileManager fm = new FileManager();
            memberCount.Text = fm.ReadAllCount<Member>(Constants.Constants.memberFileName).ToString();
            consultantCount.Text = fm.ReadAllCount<Consultant>(Constants.Constants.consultantFileName).ToString();
            equipmentCount.Text = fm.ReadAllCount<Equipment>(Constants.Constants.equipmentFileName).ToString();
            //fm.ReadAllCount<Transaction>(Constants.Constants.transactionFileName);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new AddMember();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new AddConsultant();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new AddTransaction();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new AddEquipment();
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var myForm = new Views.AddDiet();
            myForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myForm = new AddExcercise();
            myForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var myForm = new Views.ShowAllConsultants();
            myForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var myForm = new ShowAllMembers();
            myForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var myForm = new ShowAllTransactions();
            myForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var myForm = new ShowAllEquipment();
            myForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var myForm = new ShowAllDiet();
            myForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var myForm = new ShowAllExcercise();
            myForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void equipmentCount_Click(object sender, EventArgs e)
        {

        }

        private void consultantCount_Click(object sender, EventArgs e)
        {

        }

        private void lab_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
