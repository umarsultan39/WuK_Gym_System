using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Consultant:Person
    {
        private int yearsOfExperience;
        private string timings;

        public int YearsOfExperience { set { yearsOfExperience = value; } get { return yearsOfExperience; } }
        public string Timings { set { timings = value; } get { return timings; } }
      
        
        public Consultant(int id, string name, string address, string phone, string gender, string DOB, int yearsOfExperience, string timings): base(id, name, address, phone, gender, DOB)
        {
            this.yearsOfExperience = yearsOfExperience;
            this.timings = timings;
        }
        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine(yearsOfExperience);
            Console.WriteLine(timings);
        }
    }
}
