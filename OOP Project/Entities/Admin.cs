using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Admin:Person
    {
       
        FileManager fm = new FileManager();

        public Admin()
        {

        }
        public Admin (int id, string name, string address, string phone, string gender, string DOB): base(id, name, address, phone, gender, DOB) {
            
        }
        
        public void addMember (Member m)
        {
            Constants.Constants.members.Add(m); 
            fm.WriteToJsonFile(Constants.Constants.memberFileName, Constants.Constants.members);
        }

        public void setFeedback(Feedback f)
        {
            Constants.Constants.feedback.Add(f);
            fm.WriteToJsonFile(Constants.Constants.feedbackFileName, Constants.Constants.feedback);
        }
        public void setMedicalHistory(MedicalHistory mh)
        {
            Constants.Constants.medical.Add(mh);
            fm.WriteToJsonFile(Constants.Constants.medicalFileName, Constants.Constants.medical);
        }
        public void saveMember()
        {
            fm.WriteToJsonFile(Constants.Constants.memberFileName, Constants.Constants.members);
        }
        public void saveConsultant()
        {
            fm.WriteToJsonFile(Constants.Constants.consultantFileName, Constants.Constants.consultants);
        }
        public void addConsultant(Consultant c)
        {
            Constants.Constants.consultants.Add(c);
            fm.WriteToJsonFile(Constants.Constants.consultantFileName, Constants.Constants.consultants);
        }

        public void assignConsultant()
        {
            /////File Sysytem get random id from con list bs mazay kerro
        }
        public void addEquipment(Equipment e)
        {
            //Equipment equip = new Equipment(64, "Dumble", DateTime.Now);
            //equ.Add(equip);
            Constants.Constants.equipments.Add(e);
            fm.WriteToJsonFile(Constants.Constants.equipmentFileName, Constants.Constants.equipments);
        }
        
        public void makeTransactions(Transaction t)
        {
            //Transaction trans = new Transaction(23,"3-4 pm",44000, "Salary");
            //tran.Add(trans);
            Constants.Constants.transactions.Add(t);
            fm.WriteToJsonFile(Constants.Constants.transactionFileName, Constants.Constants.transactions);
        }

        public void assignDiet(Diet d)
        {
            Constants.Constants.diet.Add(d);
            fm.WriteToJsonFile(Constants.Constants.dietFileName, Constants.Constants.diet);
        }
        public void assignExcercise(Excercise e)
        {
            Constants.Constants.excercise.Add(e);
            fm.WriteToJsonFile(Constants.Constants.excerciseFileName, Constants.Constants.excercise);
        }
        
    }
}
