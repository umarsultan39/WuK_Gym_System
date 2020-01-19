using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Diet
    {
        private int dId;
        private string items;

        public int DID { set { dId = value; } get { return dId; } }
        public string Items { set { items = value; } get { return items; } }

        public Diet (int dId, string items)
        {
            this.dId = dId;
            this.items = items;
        }

    }
}
