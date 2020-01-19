using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    class Person
    {
        protected int id;
        protected string name;
        protected string address;
        protected string phoneNo;
        protected string gender;
        protected string DOB;

        public int ID { set { id = value; } get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public string Address { set { address = value; } get { return address; } }
        public string PhoneNo { set { phoneNo = value; } get { return phoneNo; } }
        public string Gender { set { gender = value; } get { return gender; } }
        public string dob { set { DOB = value; } get { return DOB; } }
        public Person() { }
        public Person (int id, string name, string address, string phoneNo, string gender, string DOB)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phoneNo = phoneNo;
            this.gender = gender;
            this.DOB = DOB;
        }
        public virtual void PrintData()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(phoneNo);
            Console.WriteLine(gender);
            Console.WriteLine(DOB);
        }


    }
}
