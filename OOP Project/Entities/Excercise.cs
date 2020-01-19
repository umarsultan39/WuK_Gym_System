using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Excercise
    {
        private int exId;
        private string exName;
        private int duration;
        public int ExId { set { exId = value; } get { return exId; } }
        public string ExName { set { exName = value; } get { return exName; } }
        public int Duration { set { duration = value; } get { return duration; } }

        public Excercise (int exId, string exName, int duration)
        {
            this.exId = exId;
            this.exName = exName;
            this.duration = duration;
        }
    }
}
