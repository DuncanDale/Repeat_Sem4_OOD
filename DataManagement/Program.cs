using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaleDuncan_S00123318;
using static DaleDuncan_S00123318.Computer;
using System.Data.Entity;

namespace DataManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputerData db = new ComputerData();


            using (db)
            {
                Computer c1 = new Computer() { Name = "Acer 714", Price = 599.99m, OperatingSystem = "Chrome OS", HardDrive = "128 GB eMMC", Memory = "8 GB", Processor = "Intel Core i3", Manufacturer_Image = "/images/acer_logo.jpg", Computer_Image = "images/acer.png"  };
                Computer c2 = new Computer() { Name = "HP Pavilion", Price = 539m, OperatingSystem = "Windows 10", HardDrive = "256 GB SSD", Memory = "8 GB", Processor = "Intel Core i3", Manufacturer_Image = "/images/hp_logo.jpg", Computer_Image = "images/hp_pavilion.png" };

                db.Computers.Add(c1);
                db.Computers.Add(c2);

                Console.WriteLine("added the computer to the database");

                db.SaveChanges();

                Console.WriteLine("saved to database");

            }
        }
    }
}
