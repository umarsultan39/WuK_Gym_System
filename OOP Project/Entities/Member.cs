using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    class Member : Person
    {
        private string height;
        private double weight;
        private double BMI;
        private string medicalHistory;
        private string section;
        private string shift;
        private int refId;
        private int did;
        private int exid;
        private List<Facility> fac;
        private Branch branch;
        public string Height { set { height = value; } get { return height; } }
        public double Weight { set { weight = value; } get { return weight; } }
        public double bmi { set { BMI = value; } get { return BMI; } }
        public string MedicalHistory { set { medicalHistory = value; } get { return medicalHistory; } }
        public string Section { set { section = value; } get { return section; } }
        public string Shift { set { shift = value; } get { return shift; } }
        public int RefId { set { refId = value; } get { return refId; } }
        public int Did { set { did = value; } get { return did; } }
        public int Exid { set { exid = value; } get { return exid; } }
        public List<Facility> Fac { set { } get { return fac; } }
        public Branch Branch { set { branch = value; } get { return branch; } }

        public Member() { }
        public Member(int id, string name, string address, string phone, string gender, string DOB, string height, double weight, double bmi, string medicalHistory, string section, string shift, int refId, int did, int exid, List<Facility> fac, Branch branch): base(id, name, address, phone, gender, DOB)
        {
            this.height = height;
            this.weight = weight;
            this.bmi = bmi;
            this.medicalHistory = medicalHistory;
            this.section = section;
            this.shift = shift;
            this.refId = refId;
            this.did = did;
            this.exid = exid;
            this.fac = fac;
            this.branch = branch;
        }
        
        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine(height);
            Console.WriteLine(weight);
            Console.WriteLine(bmi);
            Console.WriteLine(medicalHistory);
        }
    }
}
