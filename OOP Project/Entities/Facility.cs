using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Facility
    {
        private int facId;
        private string facName;
        private bool active;
        public int FacId { set {facId = value; } get { return facId; } }
        public string FacName { set { facName = value; } get { return facName; } }
        public bool Active { set { active = value; } get { return active; } }

        public Facility(int facId,string facName, bool active)
        {
            this.facId = facId;
            this.facName = facName;
            this.active = active;
        }
    }
}
