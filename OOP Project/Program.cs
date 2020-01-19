using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(1,"Saad","Johar Town","0300-1234567","Male","10/03/1984");
            FileManager fm = new FileManager();
            fm.WriteToJsonFile(Constants.Constants.adminFileName, admin);
       
            Application.EnableVisualStyles();
            Application.Run(new Home());
        }
    }
}
