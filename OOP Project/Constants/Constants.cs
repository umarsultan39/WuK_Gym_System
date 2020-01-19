using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Constants
{
    class Constants
    {
        public static string memberFileName = System.IO.Path.GetFullPath("files/members.txt");
        public static string consultantFileName = System.IO.Path.GetFullPath("files/consultants.txt");
        public static string equipmentFileName = System.IO.Path.GetFullPath("files/equipment.txt"); 
        public static string exerciseFileName = System.IO.Path.GetFullPath("files/exercise.txt"); 
        public static string transactionFileName = System.IO.Path.GetFullPath("files/transaction.txt"); 
        public static string adminFileName = System.IO.Path.GetFullPath("files/admin.txt"); 
        public static string dietFileName = System.IO.Path.GetFullPath("files/diet.txt"); 
        public static string excerciseFileName = System.IO.Path.GetFullPath("files/excercise.txt");
        public static string feedbackFileName = System.IO.Path.GetFullPath("files/feedback.txt");
        public static string medicalFileName = System.IO.Path.GetFullPath("files/medical.txt");

        public static List<Member> members = new List<Member>();
        public static List<Consultant> consultants = new List<Consultant>();
        public static List<Transaction> transactions = new List<Transaction>();
        public static List<Equipment> equipments = new List<Equipment>();
        public static List<Diet> diet = new List<Diet>();
        public static List<Excercise> excercise = new List<Excercise>();
        public static List<Feedback> feedback = new List<Feedback>();
        public static List<MedicalHistory> medical = new List<MedicalHistory>();
    }
}
