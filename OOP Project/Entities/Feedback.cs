using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Feedback
    {
        private DateTime fDate;
        private string description;
        private int memberId;
        public DateTime FDate { set { fDate = value; } get { return fDate; } }
        public string Description { set { description = value; } get { return description; } }

        public int MemberId { set { memberId = value; } get { return memberId; } }
        public Feedback(DateTime fDate, string description, int memberId)
        {
            this.fDate = fDate;
            this.description = description;
            this.memberId = memberId;
        }
        public void PrintData()
        {
            Console.WriteLine(fDate);
            Console.WriteLine(description);
         }
    }
}
