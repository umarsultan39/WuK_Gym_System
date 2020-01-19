using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Transaction
    {
        private int transId;
        private String transdate;
        private int amount;
        private string type;

        public int TransId { set { transId = value; } get { return transId; } }
        public String Transdate { set { transdate = value; } get { return transdate; } }
        public int Amount { set { amount = value; } get { return amount; } }
        public string Type { set { type = value; } get { return type; } }
        public Transaction(int transId, string transdate, int amount, string type)
        {
            this.transId = transId;
            this.transdate = transdate;
            this.amount = amount;
            this.type = type;
        }
        public void PrintData()
        {
            Console.WriteLine(transId);
            Console.WriteLine(transdate);
            Console.WriteLine(amount);
        }
    }
}
