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
    public partial class AddMember : Form
    {
        int refId, did, exid;
        List<Facility> fac = new List<Facility>();
        Branch branch;
        public AddMember()
        {
            InitializeComponent();
            List<Consultant> consultants = new List<Consultant>();
            List<Diet> diet=new List<Diet>();
            List<Excercise> ex=new List<Excercise>();
            FileManager fm = new FileManager();
            consultants = fm.ReadAll<Consultant>(Constants.Constants.consultantFileName);
            diet= fm.ReadAll<Diet>(Constants.Constants.dietFileName);
            ex=fm.ReadAll<Excercise>(Constants.Constants.excerciseFileName);

            List<string> consultantDt = new List<string>();
            List<string> dietDt = new List<string>();
            List<string> exerciseDt = new List<string>();
            List<int> ids = new List<int>();
            // populate list with test strings
            for (int i = 0; i < consultants.Count; i++)
                consultantDt.Add(consultants[i].Name);
            comboBox1.DataSource = consultantDt;
            

            for (int i = 0; i < diet.Count; i++)
                dietDt.Add(diet[i].Items);
            comboBox2.DataSource = dietDt;
            
            for (int i = 0; i < ex.Count; i++)
                exerciseDt.Add(ex[i].ExName);
            comboBox3.DataSource = exerciseDt;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //refId = comboBox1.SelectedIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fac.Clear();
            if (poolYes.Checked)
            {
                Facility f1 = new Facility(1, "Pool", true);
                fac.Add(f1);
            }

            if (saunaYes.Checked)
            {
                Facility f1 = new Facility(2, "Sauna", true);
                fac.Add(f1);
            }
            if (jakuziYes.Checked)
            {
                Facility f1 = new Facility(1, "Jacuzi", true);
                fac.Add(f1);
            }

            if (lockerYes.Checked)
            {
                Facility f1 = new Facility(1, "Lockers", true);
                fac.Add(f1);
            }
            if (radioButton1.Checked)
            {
                branch = new Branch(1, "Johar Town");
            }
            if (radioButton2.Checked)
            {
                branch = new Branch(2, "DHA");
            }
            refId = comboBox1.SelectedIndex;
            did = comboBox2.SelectedIndex;
            exid = comboBox3.SelectedIndex;

            if (feedbackTextField.Text == "")
            {
                var myForm = new Views.ErrorPop();
                myForm.Show();
                return;
            }
            Member m = new Member(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,Convert.ToDouble(textBox8.Text),Convert.ToDouble(textBox9.Text),textBox10.Text,textBox11.Text,textBox12.Text,refId,did,exid, fac, branch);
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.addMember(m);

            // Set FeedBack
            Feedback f = new Feedback(DateTime.Now, feedbackTextField.Text, m.ID);
            admin.setFeedback(f);

            // Set Medical History
            MedicalHistory mh = new MedicalHistory(m.ID, DateTime.Now, textBox10.Text, m.ID);
            admin.setMedicalHistory(mh);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            Admin admin = fm.ReadFromJsonFile<Admin>(Constants.Constants.adminFileName);
            admin.saveMember();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refId = comboBox1.SelectedIndex + 1;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //did = comboBox2.SelectedIndex + 1;
  
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //exid = comboBox3.SelectedIndex + 1; 
        }

        private void jakuziYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
