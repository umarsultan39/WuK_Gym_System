using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Equipment
    {
        private int equipmentId;
        private string name;
        private string purchaseDate;

        public int EquipmentId { set { equipmentId = value; } get { return equipmentId; } }
        public string Name { set { name = value; } get { return name; } }
        public string PurchaseDate { set { purchaseDate = value; } get { return purchaseDate; } }

        public Equipment(int equipmentId, string name, string purchaseDate)
        {
            this.equipmentId = equipmentId;
            this.name = name;
            this.purchaseDate = purchaseDate;
        }
        public void PrintData()
        {
            Console.WriteLine(equipmentId);
            Console.WriteLine(name);
            Console.WriteLine(purchaseDate);
        }
    }
}
