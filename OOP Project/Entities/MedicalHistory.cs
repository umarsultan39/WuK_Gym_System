using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class MedicalHistory
    {
        private int id;
        private DateTime date;
        private string description;
        private int memberId;

        public int Id { set { id = value; } get { return id; } }
        public DateTime Date { set { date = value; } get { return date; } }

        public string Description { set { description = value; } get { return description; } }
        public int MemberId { set { memberId = value; } get { return memberId; } }
        public MedicalHistory(int id, DateTime date, string description, int memberId)
        {
            this.id = id;
            this.date = date;
            this.description = description;
            this.memberId = memberId;
        }
    }
}
