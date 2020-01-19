using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Branch
    {
        private int branchId;
        private string location;

        public int BranchId { set { branchId = value; } get { return branchId; } }
        public string Location { set { location= value; } get { return location; } }

        public Branch(int branchId, string location)
        {
            this.branchId = branchId;
            this.location = location;
        }
    }
}
